using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using PROFINET_STEP_7.Profinet;
using PROFINET_STEP_7.Types;
using DataType = S7.Net.DataType;

namespace S7_NET
{
    public partial class Form1 : Form
    {
        private Plc plc = null;
        private ExceptionCode errorList;
        //private Exception Code errorState = Exception Code.ExceptionNo;
        Plc _S71200 = new Plc(CpuType.S71200, "172.20.10.10", 0, 1); 
        //string ip = "192.168.3.1";
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.DataSource = Enum.GetNames(typeof(CpuType));
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Informaiton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {             
                txtStatus.Text = " ";
                CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), comboBox1.SelectedValue.ToString());
                short rack = Convert.ToInt16(txtRack.Text);
                short slot = Convert.ToInt16(txtSlot.Text);
                string ip = Convert.ToString(txtIP.Text);
                plc = new Plc(cpu, ip, rack, slot);
           try
           {
                if (plc.IsConnected != true)
                {
                    plc.Open();
                    txtStatus.Text = "CONNECTED";
                }
            }
        
            catch ( Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _S71200.Close();
           // plc.Close();
            txtStatus.Text = "DisConnected";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string Address = txtAddress.Text;
            object result = plc.Read(Address);
            txtPresentValue.Text = string.Format("{0}", result.ToString());

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string Address = txtAddress.Text;
            object setPoint =  Convert.ToInt32(txtSetPoint.Text);
            plc.Write(Address , setPoint);          
        }

        private void btnSendString_Click(object sender, EventArgs e)
        {
            try
            {
                int dbNumber = 1;
                int startAddr = 0;

                string input = txtEnterString.Text;
                byte[] dataBytes = S7.Net.Types.String.ToByteArray(input,10); 

                //List<byte> values = new List<byte>();
                //byte maxLength = (byte)input.Length;
                //byte actualLength = (byte)input.Length;
                //values.Add(maxLength);
                //values.Add(actualLength);
                //values.AddRange(dataBytes);
                
                //byte[] values = System.Text.Encoding.ASCII.GetBytes(input);
                plc.WriteBytes(DataType.DataBlock, dbNumber, startAddr, dataBytes);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Informaiton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWriteDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    DataType dataType = S7.Net.DataType.DataBlock;
                    int DB = 1;
                    int StartByteAdr = 0;
                    ushort[] values = ProcessData(txtDAW.Text.Split(','));
                    byte[] value = Word.ToByteArray(values);
                    plc.Write(dataType, DB, StartByteAdr, value);
                }
                else
                {
                    throw new Exception("null exception");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }              
        }

        private void btnReadDA_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc != null)
                {
                    DataType dataType = S7.Net.DataType.DataBlock;
                    int DB = 1;
                    int StartByteAdr = 0;
                    int count = 10;
                ///    ushort[] values = ProcessData(txtDAW.Text.Split(','));
                    byte[] byteArray = plc.ReadBytes(dataType, DB, StartByteAdr, count);
                    ushort[] result = Word.ToArray(byteArray);
                    txtDAR.Text = string.Empty;
                    foreach (ushort item in result)
                    {
                        txtDAR.Text += string.Format("{0}/", item);
                    }
                }
                else
                {
                    throw new Exception("null exception");
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ushort[] ProcessData(string[] dataString)
        {
            if (dataString == null) throw new Exception("Data is null");
            ushort[] result = new ushort[dataString.Length];
            for (int i = 0; i < dataString.Length; i++)
            {
                result[i] = ushort.Parse(dataString[i]);
            }
            return result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(plc !=null)
                {
                    plc.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Informaiton", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
        }
    }
}
