
namespace S7_NET
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIP = new System.Windows.Forms.Label();
            this.lblRack = new System.Windows.Forms.Label();
            this.lblSlot = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtSetPoint = new System.Windows.Forms.TextBox();
            this.txtPresentValue = new System.Windows.Forms.TextBox();
            this.lblSetpoint = new System.Windows.Forms.Label();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWriteDA = new System.Windows.Forms.Button();
            this.lblDAW = new System.Windows.Forms.Label();
            this.txtDAW = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReadDA = new System.Windows.Forms.Button();
            this.lblDAR = new System.Windows.Forms.Label();
            this.txtDAR = new System.Windows.Forms.TextBox();
            this.btnSendString = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterString = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIP.Location = new System.Drawing.Point(29, 89);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(114, 25);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP Address:";
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRack.Location = new System.Drawing.Point(29, 132);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(62, 25);
            this.lblRack.TabIndex = 1;
            this.lblRack.Text = "Rack:";
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSlot.Location = new System.Drawing.Point(29, 182);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(52, 25);
            this.lblSlot.TabIndex = 2;
            this.lblSlot.Text = "Slot:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(196, 86);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(212, 28);
            this.txtIP.TabIndex = 3;
            // 
            // txtRack
            // 
            this.txtRack.Location = new System.Drawing.Point(196, 129);
            this.txtRack.Multiline = true;
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(212, 28);
            this.txtRack.TabIndex = 4;
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(196, 179);
            this.txtSlot.Multiline = true;
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(212, 28);
            this.txtSlot.TabIndex = 5;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPU.Location = new System.Drawing.Point(31, 36);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(60, 25);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "CPU:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Location = new System.Drawing.Point(36, 242);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(152, 39);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnect.Location = new System.Drawing.Point(196, 242);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(160, 39);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtSetPoint
            // 
            this.txtSetPoint.Location = new System.Drawing.Point(218, 120);
            this.txtSetPoint.Multiline = true;
            this.txtSetPoint.Name = "txtSetPoint";
            this.txtSetPoint.Size = new System.Drawing.Size(192, 28);
            this.txtSetPoint.TabIndex = 13;
            // 
            // txtPresentValue
            // 
            this.txtPresentValue.Location = new System.Drawing.Point(218, 74);
            this.txtPresentValue.Multiline = true;
            this.txtPresentValue.Name = "txtPresentValue";
            this.txtPresentValue.Size = new System.Drawing.Size(192, 28);
            this.txtPresentValue.TabIndex = 12;
            // 
            // lblSetpoint
            // 
            this.lblSetpoint.AutoSize = true;
            this.lblSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSetpoint.Location = new System.Drawing.Point(49, 120);
            this.lblSetpoint.Name = "lblSetpoint";
            this.lblSetpoint.Size = new System.Drawing.Size(92, 25);
            this.lblSetpoint.TabIndex = 11;
            this.lblSetpoint.Text = "SetPoint:";
            // 
            // lblPresentValue
            // 
            this.lblPresentValue.AutoSize = true;
            this.lblPresentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPresentValue.Location = new System.Drawing.Point(49, 74);
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.Size = new System.Drawing.Size(141, 25);
            this.lblPresentValue.TabIndex = 10;
            this.lblPresentValue.Text = "Present Value:";
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWrite.Location = new System.Drawing.Point(218, 185);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(152, 36);
            this.btnWrite.TabIndex = 15;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRead.Location = new System.Drawing.Point(54, 185);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(145, 36);
            this.btnRead.TabIndex = 14;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(49, 252);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(218, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 28);
            this.txtAddress.TabIndex = 19;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(49, 29);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 25);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCPU);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.lblRack);
            this.groupBox1.Controls.Add(this.lblSlot);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtRack);
            this.groupBox1.Controls.Add(this.txtSlot);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(34, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 299);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONNECTION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.lblPresentValue);
            this.groupBox2.Controls.Add(this.lblSetpoint);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.txtPresentValue);
            this.groupBox2.Controls.Add(this.txtSetPoint);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Controls.Add(this.btnWrite);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(32, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 300);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "READ/WRITE MEMORY";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStatus.Location = new System.Drawing.Point(237, 252);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(27, 25);
            this.txtStatus.TabIndex = 20;
            this.txtStatus.Text = "...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWriteDA);
            this.groupBox3.Controls.Add(this.lblDAW);
            this.groupBox3.Controls.Add(this.txtDAW);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(555, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 162);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WRITE an Data Array into DataBlock";
            // 
            // btnWriteDA
            // 
            this.btnWriteDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteDA.Location = new System.Drawing.Point(28, 98);
            this.btnWriteDA.Name = "btnWriteDA";
            this.btnWriteDA.Size = new System.Drawing.Size(152, 36);
            this.btnWriteDA.TabIndex = 16;
            this.btnWriteDA.Text = "WRITE";
            this.btnWriteDA.UseVisualStyleBackColor = true;
            this.btnWriteDA.Click += new System.EventHandler(this.btnWriteDA_Click);
            // 
            // lblDAW
            // 
            this.lblDAW.AutoSize = true;
            this.lblDAW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDAW.Location = new System.Drawing.Point(32, 46);
            this.lblDAW.Name = "lblDAW";
            this.lblDAW.Size = new System.Drawing.Size(111, 25);
            this.lblDAW.TabIndex = 6;
            this.lblDAW.Text = "Data Array:";
            // 
            // txtDAW
            // 
            this.txtDAW.Location = new System.Drawing.Point(194, 46);
            this.txtDAW.Multiline = true;
            this.txtDAW.Name = "txtDAW";
            this.txtDAW.Size = new System.Drawing.Size(437, 38);
            this.txtDAW.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReadDA);
            this.groupBox4.Controls.Add(this.lblDAR);
            this.groupBox4.Controls.Add(this.txtDAR);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(555, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 243);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "READ an Array Data from DataBlock";
            // 
            // btnReadDA
            // 
            this.btnReadDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadDA.Location = new System.Drawing.Point(18, 113);
            this.btnReadDA.Name = "btnReadDA";
            this.btnReadDA.Size = new System.Drawing.Size(162, 99);
            this.btnReadDA.TabIndex = 19;
            this.btnReadDA.Text = "READ";
            this.btnReadDA.UseVisualStyleBackColor = true;
            this.btnReadDA.Click += new System.EventHandler(this.btnReadDA_Click);
            // 
            // lblDAR
            // 
            this.lblDAR.AutoSize = true;
            this.lblDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDAR.Location = new System.Drawing.Point(23, 53);
            this.lblDAR.Name = "lblDAR";
            this.lblDAR.Size = new System.Drawing.Size(111, 25);
            this.lblDAR.TabIndex = 17;
            this.lblDAR.Text = "Data Array:";
            // 
            // txtDAR
            // 
            this.txtDAR.Location = new System.Drawing.Point(194, 53);
            this.txtDAR.Multiline = true;
            this.txtDAR.Name = "txtDAR";
            this.txtDAR.Size = new System.Drawing.Size(437, 162);
            this.txtDAR.TabIndex = 18;
            // 
            // btnSendString
            // 
            this.btnSendString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendString.Location = new System.Drawing.Point(571, 591);
            this.btnSendString.Name = "btnSendString";
            this.btnSendString.Size = new System.Drawing.Size(268, 36);
            this.btnSendString.TabIndex = 26;
            this.btnSendString.Text = "SEND STRING TO S7-1200 ";
            this.btnSendString.UseVisualStyleBackColor = true;
            this.btnSendString.Click += new System.EventHandler(this.btnSendString_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(567, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Enter String:";
            // 
            // txtEnterString
            // 
            this.txtEnterString.Location = new System.Drawing.Point(737, 539);
            this.txtEnterString.Multiline = true;
            this.txtEnterString.Name = "txtEnterString";
            this.txtEnterString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnterString.Size = new System.Drawing.Size(437, 38);
            this.txtEnterString.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 683);
            this.Controls.Add(this.btnSendString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnterString);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtSetPoint;
        private System.Windows.Forms.TextBox txtPresentValue;
        private System.Windows.Forms.Label lblSetpoint;
        private System.Windows.Forms.Label lblPresentValue;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWriteDA;
        private System.Windows.Forms.Label lblDAW;
        private System.Windows.Forms.TextBox txtDAW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReadDA;
        private System.Windows.Forms.Label lblDAR;
        private System.Windows.Forms.TextBox txtDAR;
        private System.Windows.Forms.Button btnSendString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterString;
        private System.Windows.Forms.Label txtStatus;
    }
}

