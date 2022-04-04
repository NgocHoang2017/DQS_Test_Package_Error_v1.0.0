using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Timers;

namespace DQS_Test_Package_Error_ver_1._0
{
    

    public partial class Form1 : Form
    {
        
        static SerialPort _serialPort = new SerialPort();
        private delegate void SetTextDeleg(string text);
        System.Timers.Timer t;
       
        int iLQI;
        float fError;
        string strSetLQI;
        string strSetMinutes;
        int checkLQI;
        int h = 0, m,s;
       
        private string fileName = @"C:\\LOG\\Log " + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
        public Form1()
        {
            InitializeComponent();
            vGetPortName();
            vInit();
            vTimer();
            //vResetAllPort();
        }
      
       
        // Function time counter up
        private void vTimer()
        {
            

            t = new System.Timers.Timer();
            t.Interval = 1000; // 1s
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(()=>
            {

                if(m > 0)
                {
                    if(s > 0)
                    {
                        s--;
                    }    
                    else
                    {
                        s = 59;
                        m--;
                    }    
                } 
                else
                {
                    s--;
                    
                }    
                  
                lbCounter.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
               
            }));
            
        }

        // Function time counter down
       
        private void vInit()
        {
            vCreateLog();

           

        }
        private void vCreateLog()
        {
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (!File.Exists(fileName))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        sw.WriteLine("[BEGIN LOG TEST PACKAGE ERROR]");
                        //sw.WriteLine("* Seen | Total | PER | CCA Fail | Retrys | LQI * ");
                    }
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void vLog(string strData)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(strData.Trim());
            }
        }
        // Send data 
       
        private void vResetAllPort()
        {        
            Int32 numOfDevices = 0;
            CP210x.CP210x.GetNumDevices(ref numOfDevices);
            IntPtr handle = IntPtr.Zero;
            Thread.Sleep(200);
            CP210x.CP210x.Reset(handle);

            Byte[] prtNum = new Byte[1];
          
            CP210x.CP210x.Open(0, ref handle);
            CP210x.CP210x.GetPartNumber(handle, prtNum);
           


            CP210x.CP210x.Close(handle);

        }
        private void bStart_Click(object sender, EventArgs e)
        {
            tbError.Text = "";
            tbLQI.Text = "";
            vStart();
           
        }
        private void vStart()
        {
            try
            {
                if (cbPortName.Text == "")
                {
                    MessageBox.Show("Vui lòng kết nối COM");
                }
                else
                {
                    
                    if(tbSetLQI.Text == "" || tbMinutes.Text =="")
                    {
                        MessageBox.Show("Vui lòng thiết lập các thông số");
                    }  
                    else
                    {
                        if (tbSetLQI.Enabled == false || tbMinutes.Enabled == false)
                        {
                            if (_serialPort.IsOpen)
                            {
                                tbError.Clear();
                                tbLQI.Clear();
                                lbStatus.Text = "COM KHÔNG KẾT NỐI";
                                string strData = DateTime.Now.ToString("HH:mm:ss.ff") + "->" + "Disconnect OK!----------------------------------------*\n";
                                bStart.Text = "BẮT ĐẦU (Q)";

                                //rtxStatus.Text = "";
                                bRefresh.Enabled = true;
                                t.Stop();
                                s = 0;
                                lbCounter.Text = "00:00:00";

                                tbStatus.Text = "N/A";
                                tbStatus.BackColor = Color.White;

                                _serialPort.Close();
                                

                                vLog(strData);
                            }
                            else
                            {

                                string strData = "";
                                vGetPortName();
                                lbStatus.Text = cbPortName.Text + " - ĐÃ KẾT NỐI";
                                _serialPort.PortName = cbPortName.Text;
                                _serialPort.BaudRate = 38400;
                                strData = DateTime.Now.ToString("HH:mm:ss.ff") + "->" + "Connect OK!-----------------------------------------*\n";
                                bRefresh.Enabled = false;
                                bStart.Text = "DỪNG LẠI (Q)";
                               

                                _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                                _serialPort.Open();
                                //vResetAllPort();
                                _serialPort.Write(new byte[] { 0x58 }, 0, 1); // press x
                                vLog(strData);

                                Thread.Sleep(10);

                            }
                        }    
                        else
                        {
                            MessageBox.Show("Vui lòng lưu thông số thiết lập");
                        }    
                    }
                    
                   
                }





            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);

            }
        }    
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Close();

                }
                else
                {
                    
                     
                        //Thread.Sleep(10);
                        string data = _serialPort.ReadExisting();
                       
                        this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
                        
                        
                        string strData = DateTime.Now.ToString("HH:mm:ss") + data + "\n";
                        vLog(strData);
                   
                   
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
                
                
        }
      
        private void si_DataReceived(string data) {
            try
            {
                //Thread.Sleep(100);
                string strReceiver = data.Trim();
                //Console.WriteLine(strReceiver);
                //string[] arrList = strReceiver.Split('|');
            
                //string strNewReceiver = strReceiver.Substring(strReceiver.Length - 60, 60);
                if (strReceiver.Length > 0)
                {
                    t.Start(); // Start timer
                    if (strReceiver.Contains('|'))
                    {
                       
                        Console.WriteLine(strReceiver);
                        string[] arrList = strReceiver.Split('|');
                        tbLQI.Text = arrList[5].Substring(0, 5);
                        tbError.Text = arrList[2].Substring(0, 6);

                        if (m == 0 && s == 0)
                        {

                            if (Int32.TryParse(tbLQI.Text, out iLQI) && float.TryParse(tbError.Text, out fError))
                            {
                                if (iLQI > checkLQI && fError < 1) // LQI > 70
                                {


                                    tbStatus.Text = "ĐẠT";
                                    tbStatus.BackColor = Color.Lime;

                                    _serialPort.Close();
                                    bStart.Enabled = false;
                                    bRefresh.Enabled = true;
                                    s = 0;
                                    m = 0;


                                }
                                else
                                {
                                    tbStatus.Text = "KHÔNG ĐẠT";
                                    tbStatus.BackColor = Color.Red;
                                    _serialPort.Close();
                                    bStart.Enabled = false;
                                    bRefresh.Enabled = true;
                                    s = 0;
                                    m = 0;
                                }


                            }

                            t.Stop();
                            



                        }

                        

                    }
                    else
                    {
                        Console.WriteLine("Waiting read data...");
                        tbError.Text = "Loading...";
                        tbLQI.Text = "Loading...";
                    }
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
            
           
           
              

          
            
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // not change size form
            //vResetAllPort();
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                vStart();
                tbError.Text = "";
                tbLQI.Text = "";
            }
            if(e.KeyCode == Keys.W)
            {
                
                vRefresh();
            } 
            
            
        }


        // Get infor Port name
        private void vGetPortName()
        {
            foreach(string strPort in SerialPort.GetPortNames())
            {
                //cbPortName.Items.Add(strPort);
                cbPortName.Text = strPort;
                
              
            }
           

        }
        // Display Infor

        private void Infor(object sender, EventArgs e)
        {
            MessageBox.Show("Đang cập nhật");
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            //vResetAllPort();
            vRefresh();
            bSetting.Enabled = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản: 1.0.0 - Design by Dien Quang IOT", "Thông tin", MessageBoxButtons.OK);
        }

        private void tbSetLQI_TextChanged(object sender, EventArgs e)
        {
            if(checkLQI > 255)
            {
                MessageBox.Show("Không được vượt quá 255");
            }
              
        }

        private void tbMinutes_TextChanged(object sender, EventArgs e)
        {
            //if(m > 60)
            //{
            //    MessageBox.Show("Lỗi thiết lập thời gian");
            //}    
        }

        // Setting
        private void bSetting_Click(object sender, EventArgs e)
        {

            bSetting.Enabled = false;
            strSetLQI = tbSetLQI.Text;
            strSetMinutes = tbMinutes.Text;
            if(tbSetLQI.Text =="")
            {
                MessageBox.Show("Vui lòng nhập giá trị LQI");
            }
            else
            {
               
                tbSetLQI.Enabled = false;
               
                checkLQI = Int32.Parse(tbSetLQI.Text);
            }    

            if(tbMinutes.Text =="")
            {
                MessageBox.Show("Vui lòng nhập thời gian thực hiện");
            }
            else
            {
                tbMinutes.Enabled = false;
                m = Int32.Parse(tbMinutes.Text);
            }    
            
        }

        private void vRefresh()
        {
            cbPortName.Text = "";
            tbError.Text = "";
            tbLQI.Text = "";
            tbStatus.Text = "N/A";
            tbStatus.BackColor = Color.White;
            //_serialPort.Close();
            bStart.Text = "BẮT ĐẦU  (Q)";
            bStart.Enabled = true;
            tbSetLQI.Text = "";
            tbMinutes.Text = "";
            tbMinutes.Enabled = true;
            tbSetLQI.Enabled = true;
            //bSetting.Enabled = false;
            vGetPortName();
        }
        
    }
}
