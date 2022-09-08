using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortar_Sim_Servo
{

    public partial class Form1 : Form
    {
        string unoDataIn, degree;
        sbyte indexOfA;

        string[] isian0 = { "100", "150", "200", "250", "300", "350", "400", "450" };
        string[] isian1 = { "200", "250", "300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800" };
        string[] isian2 = { "300", "350", "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900", "950",
                      "1000", "1050", "1100", "1150", "1200", "1250", "1300", "1350" };
        string[] isian3 = { "600", "700", "800", "900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800",
                      "1900", "2000", "2100", "2200", "2300", "2400", "2500", "2600" };
        string[] isian4 = { "1900", "2000", "2100", "2200", "2300", "2400", "2500", "2600", "2700", "2800", "2900", "3000",
                      "3100", "3200", "3300", "3400", "3500", "3600", "3700" };
        string[] isian5 = { "2400", "2500", "2600", "2700", "2800", "2900", "3000", "3100", "3200", "3300", "3400", "3500",
                      "3600", "3700", "3800", "3900", "4000", "4100", "4200", "4300", "4400", "4500", "4600", "4700" };
        string[] isian6 = { "3500", "3600", "3700", "3800", "3900", "4000", "4100", "4200", "4300", "4400", "4500", "4600",
                      "4700", "4800", "4900", "5000", "5100", "5200", "5300", "5400", "5500", "5600" };
        string[] isian7 = { "3900", "4000", "4100", "4200", "4300", "4400", "4500", "4600", "4700", "4800", "4900", "5000",
                      "5100", "5200", "5300", "5400", "5500", "5600", "5700", "5800", "5900", "6000", "6100", "6200", "6300" };
        string[] isian8 = { "4500", "4600", "4700", "4800", "4900", "5000", "5100", "5200", "5300", "5400", "5500", "5600",
                      "5700", "5800", "5900", "6000", "6100", "6200", "6300", "6400", "6500" };

        int[] sudut0 = { 83, 80, 76, 73, 69, 64, 58, 45 };
        int[] sudut1 = { 82, 80, 78, 77, 74, 72, 70, 68, 65, 62, 59, 55, 45 };
        int[] sudut2 = { 83, 82, 81, 80, 79, 77, 76, 75, 74, 73, 71, 70, 68, 67, 65, 64, 62, 60, 68, 55, 52, 45 };
        int[] sudut3 = { 83, 82, 81, 79, 78, 77, 76, 75, 73, 72, 71, 69, 68, 66, 64, 63, 61, 58, 56, 53, 46 };
        int[] sudut4 = { 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 62, 61, 60, 58, 56, 54, 51, 46 };
        int[] sudut5 = { 74, 73, 72, 72, 71, 70, 69, 68, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 57, 56, 54, 52, 49, 46 };
        int[] sudut6 = { 69, 69, 68, 67, 67, 66, 65, 64, 63, 63, 62, 61, 60, 59, 58, 57, 55, 54, 52, 50, 47, 45 };
        int[] sudut7 = { 69, 69, 68, 68, 67, 66, 66, 65, 64, 64, 63, 62, 61, 60, 60, 59, 58, 57, 55, 54, 53, 51, 49, 47, 45 };
        int[] sudut8 = { 68, 67, 66, 66, 65, 64, 64, 63, 62, 61, 61, 60, 59, 58, 57, 56, 55, 53, 52, 50, 45 };


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_unoComPort_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_unoComPort.Items.Clear();
            comboBox_unoComPort.Items.AddRange(portLists);
        }

        private void button_unoOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_uno.PortName = comboBox_unoComPort.Text;
                serialPort_uno.BaudRate = Convert.ToInt32(comboBox_unoBaudRate.Text);
                serialPort_uno.Open();

                button_unoOpen.Enabled = false;
                button_unoClose.Enabled = true;
                progressBar_uno.Value = 100;
                serialPort_uno.Write("45" + "#" + "\n");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_unoClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_uno.Write("45" + "#" + "\n");
                serialPort_uno.Close();
                button_unoOpen.Enabled = true;
                button_unoClose.Enabled = false;
                progressBar_uno.Value = 0;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {


            if (textBox_ammo.Text == "0")
            {
                string distance = textBox_distance.Text;
                int x = isian0.findIndex(distance);
                int y = sudut0[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "1")
            {
                string distance = textBox_distance.Text;
                int x = isian1.findIndex(distance);
                int y = sudut1[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "2")
            {
                string distance = textBox_distance.Text;
                int x = isian2.findIndex(distance);
                int y = sudut2[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "3")
            {
                string distance = textBox_distance.Text;
                int x = isian3.findIndex(distance);
                int y = sudut3[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "4")
            {
                string distance = textBox_distance.Text;
                int x = isian4.findIndex(distance);
                int y = sudut4[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "5")
            {
                string distance = textBox_distance.Text;
                int x = isian5.findIndex(distance);
                int y = sudut5[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "6")
            {
                string distance = textBox_distance.Text;
                int x = isian6.findIndex(distance);
                int y = sudut6[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "7")
            {
                string distance = textBox_distance.Text;
                int x = isian7.findIndex(distance);
                int y = sudut7[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
            if (textBox_ammo.Text == "8")
            {
                string distance = textBox_distance.Text;
                int x = isian8.findIndex(distance);
                int y = sudut8[x];
                label_degree.Text = Convert.ToString(y) + "°";
                serialPort_uno.Write(y + "#" + "\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_unoOpen.Enabled = true;
            button_unoClose.Enabled = false;
            progressBar_uno.Value = 0;
            comboBox_unoBaudRate.Text = "9600";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort_uno.Write("45" + "#" + "\n");
                serialPort_uno.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort_uno_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            unoDataIn = serialPort_uno.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(unoDataIn.IndexOf("A"));
                degree = unoDataIn.Substring(0, indexOfA);
                label_degree.Text = String.Format(degree + "°");
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
    public static class Extensions
    {
        public static int findIndex<T>(this T[] isian0, T stringtoFind)
        {
            return Array.IndexOf(isian0, stringtoFind);
        }
    }
}
