namespace CardiologyClinic.View.DoctorView.EditPatient.EditProcedure
{
    partial class AddProcedureForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.procedureComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbYear = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMounth = new System.Windows.Forms.ComboBox();
            this.tbDay = new System.Windows.Forms.NumericUpDown();
            this.tbMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHour = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHour)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.procedureComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 47);
            this.panel1.TabIndex = 0;
            // 
            // procedureComboBox
            // 
            this.procedureComboBox.FormattingEnabled = true;
            this.procedureComboBox.Location = new System.Drawing.Point(12, 12);
            this.procedureComboBox.Name = "procedureComboBox";
            this.procedureComboBox.Size = new System.Drawing.Size(308, 21);
            this.procedureComboBox.TabIndex = 0;
            this.procedureComboBox.Text = "Выберите процедуру";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbYear);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbMounth);
            this.panel2.Controls.Add(this.tbDay);
            this.panel2.Controls.Add(this.tbMinute);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbHour);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 116);
            this.panel2.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(265, 36);
            this.tbYear.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.tbYear.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(52, 20);
            this.tbYear.TabIndex = 8;
            this.tbYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время:";
            // 
            // cbMounth
            // 
            this.cbMounth.FormattingEnabled = true;
            this.cbMounth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cbMounth.Location = new System.Drawing.Point(155, 34);
            this.cbMounth.Name = "cbMounth";
            this.cbMounth.Size = new System.Drawing.Size(104, 21);
            this.cbMounth.TabIndex = 4;
            this.cbMounth.SelectedIndexChanged += new System.EventHandler(this.cbMounth_SelectedIndexChanged);
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(105, 36);
            this.tbDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tbDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(41, 20);
            this.tbDay.TabIndex = 3;
            this.tbDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbMinute
            // 
            this.tbMinute.Location = new System.Drawing.Point(169, 8);
            this.tbMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.Size = new System.Drawing.Size(39, 20);
            this.tbMinute.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(104, 9);
            this.tbHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(42, 20);
            this.tbHour.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 38);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            this.label4.Visible = false;
            // 
            // AddProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(332, 163);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddProcedureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProcedureForm";
            //this.Load += new System.EventHandler(this.AddProcedureForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHour)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox procedureComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMounth;
        private System.Windows.Forms.NumericUpDown tbDay;
        private System.Windows.Forms.NumericUpDown tbMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbHour;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tbYear;
        private System.Windows.Forms.Label label4;
    }
}