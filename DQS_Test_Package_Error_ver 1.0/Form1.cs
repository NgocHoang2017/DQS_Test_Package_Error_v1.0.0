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
        int s=60;
        int h=0, m=2;
        int iLQI;
        float fError;

        private string fileName = @"C:\\LOG\\Log " + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
        public Form1()
        {
            InitializeComponent();
            vGetPortName();
            vInit();
            vTimer();
            
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
                s -= 01;
                if (s == 0)
                {
                    m -= 1;
                    s = 0;
                    if (m == 1)
                    {
                        s = 60;
                        s -= 01;
                        m -= 1;

                    }
                    else if (m == 0)
                    {
                        s = 60;
                        s -= 01;
                        m = 0;
                    }
                    else if (s == 0)
                    {
                        m = 00;
                        s = 00;
                        lbCounter.Text = "00:00:00";
                    }
                }

                //s = 0;
                lbCounter.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                if (s == 0)
                {
                    s = 0;
                }
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
            //Int32 retVal = CP210x.CP210x.GetNumDevices(ref numOfDevices);
            IntPtr handle = IntPtr.Zero;
            Byte[] prtNum = new Byte[1];
            UInt16[] latch = new UInt16[8];
            UInt16 mask = 0x01;
            if (numOfDevices > 0)
            {
                CP210x.CP210x.Open(0, ref handle);
                CP210x.CP210x.GetPartNumber(handle, prtNum);
                
                CP210x.CP210x.ReadLatch(handle, latch);

                for (Int32 idx = 0; idx < 16; idx++)
                {
                        CP210x.CP210x.WriteLatch(handle, (UInt16)(mask << idx), 0x01);
                }
               
            }
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            //vResetAllPort();
            //Thread.Sleep(100);
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
                        
                        lbCounter.Text = "00:00:00";
                        
                        tbStatus.Text = "N/A";
                        tbStatus.BackColor = Color.White;
                        //_serialPort.ReadTimeout = 500;
                        Thread.Sleep(100);
                        _serialPort.Close();
                       
                        
                        //s = 00;
                        vLog(strData);
                    }
                    else
                    {

                        vGetPortName();
                        lbStatus.Text = cbPortName.Text + " - ĐÃ KẾT NỐI";
                        _serialPort.PortName = cbPortName.Text;
                        _serialPort.BaudRate = 38400;
                        string strData = DateTime.Now.ToString("HH:mm:ss.ff") + "->" + "Connect OK!-----------------------------------------*\n";
                        bRefresh.Enabled = false;
                        bStart.Text = "DỪNG LẠI (Q)";
                       
                        t.Start(); // Start timer
                      
                        _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                        _serialPort.Open();
                        vLog(strData);


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
                    while(_serialPort.BytesToRead > 0)
                    {
                        Thread.Sleep(500);
                        string data = _serialPort.ReadExisting();

                        this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
                        Application.DoEvents();
                        //Console.WriteLine(data);
                        string strData = DateTime.Now.ToString("HH:mm:ss.ff") + data + "\n";
                        vLog(strData);
                    }    
                   
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
                
                
        }
        private void si_DataReceived(string data) {
            
            
            string strReceiver = data.Trim();
            string[] arrList = strReceiver.Split('|');
            
            for(int i =0; i<= arrList.Length; i++)
            {
                //Console.WriteLine(arrList.Length);
                tbError.Text = string.Empty;
                tbLQI.Text = string.Empty;
              
                tbLQI.Text = arrList[5].Substring(0, 5);
                tbError.Text = arrList[2].Substring(0,6);
               
               
                //t.Start();
                
                    if (m == 00 && s == 00)
                    {

                        if (Int32.TryParse(tbLQI.Text, out iLQI) && float.TryParse(tbError.Text, out fError))
                        {
                            if (iLQI > 70) // LQI > 70
                            {
                                
                                if (fError <= 1)
                                {
                                    tbStatus.Text = "ĐẠT";
                                    tbStatus.BackColor = Color.Lime;
                                    
                                }
                                else
                                {
                                    tbStatus.Text = "KHÔNG ĐẠT";
                                    tbStatus.BackColor = Color.Red;
                                }
                               

                            }
                            else
                            {
                           
                                tbStatus.Text = "KHÔNG ĐẠT";
                                tbStatus.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        } 
                        
                        
                        t.Stop();


                    }
              
                     if(tbError.Text =="" || tbLQI.Text =="")
                     {
                        tbStatus.Text = "KHÔNG CÓ DỮ LIỆU";
                        tbStatus.BackColor = Color.Red;
                     }    

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
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
            //MessageBox.Show(" Design by Dien Quang IOT \n") ;
            MessageBox.Show(" Điều kiện test trên 1 đường thẳng và <= 10m \n");
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            vRefresh();
           
        }

        

        private void vRefresh()
        {
            cbPortName.Text = "";
            tbError.Text = "";
            tbLQI.Text = "";
            tbStatus.Text = "N/A";
            tbStatus.BackColor = Color.White;
            //_serialPort.Close();
            vGetPortName();
        }
        
    }
}
