namespace SerialPortCom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParityBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbDataBirts = new System.Windows.Forms.ComboBox();
            this.cbBaundRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbComPortStatus = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btUnlock = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btLock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbParityBits);
            this.groupBox1.Controls.Add(this.cbStopBits);
            this.groupBox1.Controls.Add(this.cbDataBirts);
            this.groupBox1.Controls.Add(this.cbBaundRate);
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(351, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bıts";
            // 
            // cbParityBits
            // 
            this.cbParityBits.FormattingEnabled = true;
            this.cbParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParityBits.Location = new System.Drawing.Point(120, 195);
            this.cbParityBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbParityBits.Name = "cbParityBits";
            this.cbParityBits.Size = new System.Drawing.Size(136, 28);
            this.cbParityBits.TabIndex = 8;
            this.cbParityBits.Text = "None";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(120, 158);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(136, 28);
            this.cbStopBits.TabIndex = 7;
            this.cbStopBits.Text = "One";
            // 
            // cbDataBirts
            // 
            this.cbDataBirts.FormattingEnabled = true;
            this.cbDataBirts.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbDataBirts.Location = new System.Drawing.Point(120, 120);
            this.cbDataBirts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDataBirts.Name = "cbDataBirts";
            this.cbDataBirts.Size = new System.Drawing.Size(136, 28);
            this.cbDataBirts.TabIndex = 6;
            this.cbDataBirts.Text = "8";
            // 
            // cbBaundRate
            // 
            this.cbBaundRate.FormattingEnabled = true;
            this.cbBaundRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cbBaundRate.Location = new System.Drawing.Point(120, 82);
            this.cbBaundRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBaundRate.Name = "cbBaundRate";
            this.cbBaundRate.Size = new System.Drawing.Size(136, 28);
            this.cbBaundRate.TabIndex = 5;
            this.cbBaundRate.Text = "9600";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(120, 42);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(136, 28);
            this.cbComPort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baund Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btClose);
            this.groupBox2.Controls.Add(this.btOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(14, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(351, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbComPortStatus);
            this.groupBox6.Location = new System.Drawing.Point(120, 12);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(224, 98);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Com Port Status";
            // 
            // lbComPortStatus
            // 
            this.lbComPortStatus.AutoSize = true;
            this.lbComPortStatus.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbComPortStatus.ForeColor = System.Drawing.Color.Red;
            this.lbComPortStatus.Location = new System.Drawing.Point(71, 38);
            this.lbComPortStatus.Name = "lbComPortStatus";
            this.lbComPortStatus.Size = new System.Drawing.Size(71, 37);
            this.lbComPortStatus.TabIndex = 6;
            this.lbComPortStatus.Text = "OFF";
            this.lbComPortStatus.Click += new System.EventHandler(this.lbComPortStatus_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(17, 72);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(84, 29);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(17, 26);
            this.btOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(84, 29);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 118);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(338, 29);
            this.progressBar1.TabIndex = 0;
            // 
            // btUnlock
            // 
            this.btUnlock.Location = new System.Drawing.Point(32, 467);
            this.btUnlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUnlock.Name = "btUnlock";
            this.btUnlock.Size = new System.Drawing.Size(141, 55);
            this.btUnlock.TabIndex = 2;
            this.btUnlock.Text = "Forward";
            this.btUnlock.UseVisualStyleBackColor = true;
            this.btUnlock.Click += new System.EventHandler(this.btSendData_Click);
            // 
            // btLock
            // 
            this.btLock.Location = new System.Drawing.Point(188, 467);
            this.btLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(141, 55);
            this.btLock.TabIndex = 4;
            this.btLock.Text = "Backward";
            this.btLock.UseVisualStyleBackColor = true;
            this.btLock.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLock);
            this.Controls.Add(this.btUnlock);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParityBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbDataBirts;
        private System.Windows.Forms.ComboBox cbBaundRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btUnlock;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btLock;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbComPortStatus;
    }
}

