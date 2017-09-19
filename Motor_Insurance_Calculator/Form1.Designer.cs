namespace Motor_Insurance_Calculator
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
            this.policyStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.driversOnPolicy = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmDriverNumb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPremiumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.driverDob = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxJob = new System.Windows.Forms.ComboBox();
            this.addDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driversOnPolicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // policyStartDate
            // 
            this.policyStartDate.Location = new System.Drawing.Point(15, 25);
            this.policyStartDate.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.policyStartDate.Name = "policyStartDate";
            this.policyStartDate.Size = new System.Drawing.Size(200, 20);
            this.policyStartDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Policy Start Date:";
            // 
            // driversOnPolicy
            // 
            this.driversOnPolicy.Location = new System.Drawing.Point(292, 25);
            this.driversOnPolicy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.driversOnPolicy.Name = "driversOnPolicy";
            this.driversOnPolicy.Size = new System.Drawing.Size(120, 20);
            this.driversOnPolicy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Drivers:";
            // 
            // confirmDriverNumb
            // 
            this.confirmDriverNumb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmDriverNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDriverNumb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmDriverNumb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmDriverNumb.Location = new System.Drawing.Point(292, 51);
            this.confirmDriverNumb.Name = "confirmDriverNumb";
            this.confirmDriverNumb.Size = new System.Drawing.Size(120, 23);
            this.confirmDriverNumb.TabIndex = 4;
            this.confirmDriverNumb.Text = "Confirm";
            this.confirmDriverNumb.UseVisualStyleBackColor = true;
            this.confirmDriverNumb.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 222);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Premium:";
            // 
            // totalPremiumBox
            // 
            this.totalPremiumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPremiumBox.Location = new System.Drawing.Point(573, 358);
            this.totalPremiumBox.Name = "totalPremiumBox";
            this.totalPremiumBox.ReadOnly = true;
            this.totalPremiumBox.Size = new System.Drawing.Size(100, 22);
            this.totalPremiumBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "AGE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "OCCUPATION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "DATE OF BIRTH:";
            // 
            // driverDob
            // 
            this.driverDob.Location = new System.Drawing.Point(18, 232);
            this.driverDob.Name = "driverDob";
            this.driverDob.Size = new System.Drawing.Size(180, 20);
            this.driverDob.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 125);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(18, 284);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 15;
            // 
            // comboBoxJob
            // 
            this.comboBoxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJob.FormattingEnabled = true;
            this.comboBoxJob.Items.AddRange(new object[] {
            "Chauffeur",
            "Accountant"});
            this.comboBoxJob.Location = new System.Drawing.Point(18, 178);
            this.comboBoxJob.Name = "comboBoxJob";
            this.comboBoxJob.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJob.TabIndex = 16;
            this.comboBoxJob.SelectedIndex = 0;
            // 
            // addDriver
            // 
            this.addDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDriver.Location = new System.Drawing.Point(18, 358);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(102, 23);
            this.addDriver.TabIndex = 17;
            this.addDriver.Text = "Add Driver";
            this.addDriver.UseVisualStyleBackColor = true;
            this.addDriver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 452);
            this.Controls.Add(this.addDriver);
            this.Controls.Add(this.comboBoxJob);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.driverDob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPremiumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.confirmDriverNumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.driversOnPolicy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.policyStartDate);
            this.Name = "Form1";
            this.Text = "Motor Insurance ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversOnPolicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker policyStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown driversOnPolicy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmDriverNumb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalPremiumBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker driverDob;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxJob;
        private System.Windows.Forms.Button addDriver;
    }
}

