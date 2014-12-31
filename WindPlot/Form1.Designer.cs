namespace WindPlot
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StationName = new System.Windows.Forms.TextBox();
            this.StationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBLongitude = new System.Windows.Forms.TextBox();
            this.TBLatitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBWinDir = new System.Windows.Forms.TextBox();
            this.TBWindSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBWindDateTime = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TBEnvHumid = new System.Windows.Forms.TextBox();
            this.TBEnvTemp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StationName);
            this.groupBox1.Controls.Add(this.StationID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station";
            // 
            // StationName
            // 
            this.StationName.Location = new System.Drawing.Point(67, 44);
            this.StationName.Name = "StationName";
            this.StationName.Size = new System.Drawing.Size(127, 20);
            this.StationName.TabIndex = 4;
            // 
            // StationID
            // 
            this.StationID.Location = new System.Drawing.Point(67, 19);
            this.StationID.Name = "StationID";
            this.StationID.Size = new System.Drawing.Size(127, 20);
            this.StationID.TabIndex = 4;
            this.StationID.TextChanged += new System.EventHandler(this.StationID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBLongitude);
            this.groupBox2.Controls.Add(this.TBLatitude);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPS";
            // 
            // TBLongitude
            // 
            this.TBLongitude.Location = new System.Drawing.Point(67, 44);
            this.TBLongitude.Name = "TBLongitude";
            this.TBLongitude.Size = new System.Drawing.Size(127, 20);
            this.TBLongitude.TabIndex = 4;
            // 
            // TBLatitude
            // 
            this.TBLatitude.Location = new System.Drawing.Point(67, 19);
            this.TBLatitude.Name = "TBLatitude";
            this.TBLatitude.Size = new System.Drawing.Size(127, 20);
            this.TBLatitude.TabIndex = 4;
            this.TBLatitude.TextChanged += new System.EventHandler(this.StationID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBWindDateTime);
            this.groupBox3.Controls.Add(this.TBWinDir);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TBWindSpeed);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wind";
            // 
            // TBWinDir
            // 
            this.TBWinDir.Location = new System.Drawing.Point(67, 44);
            this.TBWinDir.Name = "TBWinDir";
            this.TBWinDir.Size = new System.Drawing.Size(127, 20);
            this.TBWinDir.TabIndex = 4;
            // 
            // TBWindSpeed
            // 
            this.TBWindSpeed.Location = new System.Drawing.Point(67, 19);
            this.TBWindSpeed.Name = "TBWindSpeed";
            this.TBWindSpeed.Size = new System.Drawing.Size(127, 20);
            this.TBWindSpeed.TabIndex = 4;
            this.TBWindSpeed.TextChanged += new System.EventHandler(this.StationID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "DateTime";
            // 
            // TBWindDateTime
            // 
            this.TBWindDateTime.Location = new System.Drawing.Point(67, 70);
            this.TBWindDateTime.Name = "TBWindDateTime";
            this.TBWindDateTime.Size = new System.Drawing.Size(127, 20);
            this.TBWindDateTime.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TBEnvHumid);
            this.groupBox4.Controls.Add(this.TBEnvTemp);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(233, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 80);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Environmental";
            // 
            // TBEnvHumid
            // 
            this.TBEnvHumid.Location = new System.Drawing.Point(67, 44);
            this.TBEnvHumid.Name = "TBEnvHumid";
            this.TBEnvHumid.Size = new System.Drawing.Size(127, 20);
            this.TBEnvHumid.TabIndex = 4;
            // 
            // TBEnvTemp
            // 
            this.TBEnvTemp.Location = new System.Drawing.Point(67, 19);
            this.TBEnvTemp.Name = "TBEnvTemp";
            this.TBEnvTemp.Size = new System.Drawing.Size(127, 20);
            this.TBEnvTemp.TabIndex = 4;
            this.TBEnvTemp.TextChanged += new System.EventHandler(this.StationID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Humid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Temp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 364);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox StationName;
        public System.Windows.Forms.TextBox StationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox TBLongitude;
        public System.Windows.Forms.TextBox TBLatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox TBWindDateTime;
        public System.Windows.Forms.TextBox TBWinDir;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TBWindSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox TBEnvHumid;
        public System.Windows.Forms.TextBox TBEnvTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

