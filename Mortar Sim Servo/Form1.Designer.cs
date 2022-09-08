namespace Mortar_Sim_Servo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_comPortSettings = new System.Windows.Forms.GroupBox();
            this.progressBar_uno = new System.Windows.Forms.ProgressBar();
            this.button_unoClose = new System.Windows.Forms.Button();
            this.button_unoOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_unoBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_unoComPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_degree = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.textBox_ammo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort_uno = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_comPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_comPortSettings
            // 
            this.groupBox_comPortSettings.Controls.Add(this.progressBar_uno);
            this.groupBox_comPortSettings.Controls.Add(this.button_unoClose);
            this.groupBox_comPortSettings.Controls.Add(this.button_unoOpen);
            this.groupBox_comPortSettings.Controls.Add(this.label2);
            this.groupBox_comPortSettings.Controls.Add(this.label1);
            this.groupBox_comPortSettings.Controls.Add(this.comboBox_unoBaudRate);
            this.groupBox_comPortSettings.Controls.Add(this.comboBox_unoComPort);
            this.groupBox_comPortSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_comPortSettings.Name = "groupBox_comPortSettings";
            this.groupBox_comPortSettings.Size = new System.Drawing.Size(329, 216);
            this.groupBox_comPortSettings.TabIndex = 1;
            this.groupBox_comPortSettings.TabStop = false;
            this.groupBox_comPortSettings.Text = "COM PORT SETTINGS";
            // 
            // progressBar_uno
            // 
            this.progressBar_uno.Location = new System.Drawing.Point(6, 180);
            this.progressBar_uno.Name = "progressBar_uno";
            this.progressBar_uno.Size = new System.Drawing.Size(317, 23);
            this.progressBar_uno.TabIndex = 6;
            // 
            // button_unoClose
            // 
            this.button_unoClose.Location = new System.Drawing.Point(166, 129);
            this.button_unoClose.Name = "button_unoClose";
            this.button_unoClose.Size = new System.Drawing.Size(114, 39);
            this.button_unoClose.TabIndex = 5;
            this.button_unoClose.Text = "CLOSE";
            this.button_unoClose.UseVisualStyleBackColor = true;
            this.button_unoClose.Click += new System.EventHandler(this.button_unoClose_Click);
            // 
            // button_unoOpen
            // 
            this.button_unoOpen.Location = new System.Drawing.Point(35, 129);
            this.button_unoOpen.Name = "button_unoOpen";
            this.button_unoOpen.Size = new System.Drawing.Size(114, 39);
            this.button_unoOpen.TabIndex = 4;
            this.button_unoOpen.Text = "OPEN";
            this.button_unoOpen.UseVisualStyleBackColor = true;
            this.button_unoOpen.Click += new System.EventHandler(this.button_unoOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM PORT:";
            // 
            // comboBox_unoBaudRate
            // 
            this.comboBox_unoBaudRate.FormattingEnabled = true;
            this.comboBox_unoBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_unoBaudRate.Location = new System.Drawing.Point(135, 91);
            this.comboBox_unoBaudRate.Name = "comboBox_unoBaudRate";
            this.comboBox_unoBaudRate.Size = new System.Drawing.Size(145, 24);
            this.comboBox_unoBaudRate.TabIndex = 1;
            // 
            // comboBox_unoComPort
            // 
            this.comboBox_unoComPort.FormattingEnabled = true;
            this.comboBox_unoComPort.Location = new System.Drawing.Point(135, 49);
            this.comboBox_unoComPort.Name = "comboBox_unoComPort";
            this.comboBox_unoComPort.Size = new System.Drawing.Size(145, 24);
            this.comboBox_unoComPort.TabIndex = 0;
            this.comboBox_unoComPort.DropDown += new System.EventHandler(this.comboBox_unoComPort_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_degree);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_distance);
            this.groupBox1.Controls.Add(this.textBox_ammo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(347, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ELEVATION CONTROL";
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_degree.Location = new System.Drawing.Point(211, 166);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(0, 26);
            this.label_degree.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "ELEVATION DEGREE:";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(324, 59);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 36);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "SEND";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_distance
            // 
            this.textBox_distance.Location = new System.Drawing.Point(164, 88);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.Size = new System.Drawing.Size(133, 22);
            this.textBox_distance.TabIndex = 3;
            // 
            // textBox_ammo
            // 
            this.textBox_ammo.Location = new System.Drawing.Point(164, 48);
            this.textBox_ammo.Name = "textBox_ammo";
            this.textBox_ammo.Size = new System.Drawing.Size(133, 22);
            this.textBox_ammo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "DISTANCE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "AMMUNITION:";
            // 
            // serialPort_uno
            // 
            this.serialPort_uno.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_uno_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_comPortSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MORTAR SERVO SIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_comPortSettings.ResumeLayout(false);
            this.groupBox_comPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_comPortSettings;
        private System.Windows.Forms.ProgressBar progressBar_uno;
        private System.Windows.Forms.Button button_unoClose;
        private System.Windows.Forms.Button button_unoOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_unoBaudRate;
        private System.Windows.Forms.ComboBox comboBox_unoComPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_distance;
        private System.Windows.Forms.TextBox textBox_ammo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort_uno;
        private System.Windows.Forms.Label label_degree;
    }
}

