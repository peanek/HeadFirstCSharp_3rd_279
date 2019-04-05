namespace page279_VI_queens_V1._1
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
            this.comboBox1_jobSelect = new System.Windows.Forms.ComboBox();
            this.numericUpDown1_shiftNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox1_beeAssigment = new System.Windows.Forms.GroupBox();
            this.button1_assignBee = new System.Windows.Forms.Button();
            this.button1_workShift = new System.Windows.Forms.Button();
            this.textBox1_reportBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_shiftNumber)).BeginInit();
            this.groupBox1_beeAssigment.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1_jobSelect
            // 
            this.comboBox1_jobSelect.FormattingEnabled = true;
            this.comboBox1_jobSelect.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.comboBox1_jobSelect.Location = new System.Drawing.Point(6, 19);
            this.comboBox1_jobSelect.Name = "comboBox1_jobSelect";
            this.comboBox1_jobSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_jobSelect.TabIndex = 0;
            // 
            // numericUpDown1_shiftNumber
            // 
            this.numericUpDown1_shiftNumber.Location = new System.Drawing.Point(133, 20);
            this.numericUpDown1_shiftNumber.Name = "numericUpDown1_shiftNumber";
            this.numericUpDown1_shiftNumber.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1_shiftNumber.TabIndex = 1;
            // 
            // groupBox1_beeAssigment
            // 
            this.groupBox1_beeAssigment.Controls.Add(this.button1_assignBee);
            this.groupBox1_beeAssigment.Controls.Add(this.comboBox1_jobSelect);
            this.groupBox1_beeAssigment.Controls.Add(this.numericUpDown1_shiftNumber);
            this.groupBox1_beeAssigment.Location = new System.Drawing.Point(13, 13);
            this.groupBox1_beeAssigment.Name = "groupBox1_beeAssigment";
            this.groupBox1_beeAssigment.Size = new System.Drawing.Size(208, 82);
            this.groupBox1_beeAssigment.TabIndex = 2;
            this.groupBox1_beeAssigment.TabStop = false;
            this.groupBox1_beeAssigment.Text = "Bee Assigment";
            // 
            // button1_assignBee
            // 
            this.button1_assignBee.Location = new System.Drawing.Point(7, 47);
            this.button1_assignBee.Name = "button1_assignBee";
            this.button1_assignBee.Size = new System.Drawing.Size(183, 23);
            this.button1_assignBee.TabIndex = 2;
            this.button1_assignBee.Text = "Assign bee to job";
            this.button1_assignBee.UseVisualStyleBackColor = true;
            this.button1_assignBee.Click += new System.EventHandler(this.button1_assignBee_Click);
            // 
            // button1_workShift
            // 
            this.button1_workShift.Location = new System.Drawing.Point(228, 13);
            this.button1_workShift.Name = "button1_workShift";
            this.button1_workShift.Size = new System.Drawing.Size(88, 81);
            this.button1_workShift.TabIndex = 3;
            this.button1_workShift.Text = "Work Shift";
            this.button1_workShift.UseVisualStyleBackColor = true;
            this.button1_workShift.Click += new System.EventHandler(this.button1_workShift_Click);
            // 
            // textBox1_reportBox
            // 
            this.textBox1_reportBox.Location = new System.Drawing.Point(13, 102);
            this.textBox1_reportBox.Multiline = true;
            this.textBox1_reportBox.Name = "textBox1_reportBox";
            this.textBox1_reportBox.Size = new System.Drawing.Size(303, 162);
            this.textBox1_reportBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 277);
            this.Controls.Add(this.textBox1_reportBox);
            this.Controls.Add(this.button1_workShift);
            this.Controls.Add(this.groupBox1_beeAssigment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_shiftNumber)).EndInit();
            this.groupBox1_beeAssigment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_jobSelect;
        private System.Windows.Forms.NumericUpDown numericUpDown1_shiftNumber;
        private System.Windows.Forms.GroupBox groupBox1_beeAssigment;
        private System.Windows.Forms.Button button1_assignBee;
        private System.Windows.Forms.Button button1_workShift;
        private System.Windows.Forms.TextBox textBox1_reportBox;
    }
}

