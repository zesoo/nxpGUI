namespace PortSet
{
    partial class PortSettings
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
            this.listBoxPorts = new System.Windows.Forms.ListBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPorts
            // 
            this.listBoxPorts.FormattingEnabled = true;
            this.listBoxPorts.ItemHeight = 18;
            this.listBoxPorts.Location = new System.Drawing.Point(16, 41);
            this.listBoxPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPorts.Name = "listBoxPorts";
            this.listBoxPorts.Size = new System.Drawing.Size(452, 112);
            this.listBoxPorts.TabIndex = 0;
            this.listBoxPorts.SelectedIndexChanged += new System.EventHandler(this.listBoxPorts_SelectedIndexChanged);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(119, 177);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(180, 26);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Bits";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(119, 213);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(180, 26);
            this.comboBoxDataBits.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parity";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(119, 250);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(180, 26);
            this.comboBoxParity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Flow Control";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(119, 288);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(180, 26);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.FormattingEnabled = true;
            this.comboBoxFlowControl.Location = new System.Drawing.Point(119, 325);
            this.comboBoxFlowControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(180, 26);
            this.comboBoxFlowControl.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Double click on port you want to use:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(358, 325);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 32);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(358, 285);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 32);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PortSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 381);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFlowControl);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.listBoxPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PortSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.PortSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxFlowControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}