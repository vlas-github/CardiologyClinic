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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDateReception = new System.Windows.Forms.Label();
            this.dayReception = new System.Windows.Forms.NumericUpDown();
            this.monthReception = new System.Windows.Forms.ComboBox();
            this.yearReception = new System.Windows.Forms.NumericUpDown();
            this.addReception = new System.Windows.Forms.Button();
            this.cancelReception = new System.Windows.Forms.Button();
            this.labelTimeReception = new System.Windows.Forms.Label();
            this.hourReception = new System.Windows.Forms.NumericUpDown();
            this.minuteReception = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayReception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearReception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourReception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteReception)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.procedureComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 47);
            this.panel1.TabIndex = 0;
            // 
            // procedureComboBox
            // 
            this.procedureComboBox.FormattingEnabled = true;
            this.procedureComboBox.Location = new System.Drawing.Point(12, 12);
            this.procedureComboBox.Name = "procedureComboBox";
            this.procedureComboBox.Size = new System.Drawing.Size(296, 21);
            this.procedureComboBox.TabIndex = 0;
            this.procedureComboBox.Text = "Выберите процедуру";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.minuteReception);
            this.panel2.Controls.Add(this.hourReception);
            this.panel2.Controls.Add(this.labelTimeReception);
            this.panel2.Controls.Add(this.yearReception);
            this.panel2.Controls.Add(this.dayReception);
            this.panel2.Controls.Add(this.monthReception);
            this.panel2.Controls.Add(this.labelDateReception);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 114);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelReception);
            this.panel3.Controls.Add(this.addReception);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 40);
            this.panel3.TabIndex = 2;
            // 
            // labelDateReception
            // 
            this.labelDateReception.AutoSize = true;
            this.labelDateReception.Location = new System.Drawing.Point(22, 14);
            this.labelDateReception.Name = "labelDateReception";
            this.labelDateReception.Size = new System.Drawing.Size(77, 13);
            this.labelDateReception.TabIndex = 0;
            this.labelDateReception.Text = "Дата приема:";
            this.labelDateReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayReception
            // 
            this.dayReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayReception.Location = new System.Drawing.Point(105, 10);
            this.dayReception.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayReception.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayReception.Name = "dayReception";
            this.dayReception.Size = new System.Drawing.Size(40, 21);
            this.dayReception.TabIndex = 9;
            this.dayReception.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthReception
            // 
            this.monthReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthReception.FormattingEnabled = true;
            this.monthReception.Items.AddRange(new object[] {
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
            this.monthReception.Location = new System.Drawing.Point(151, 9);
            this.monthReception.Name = "monthReception";
            this.monthReception.Size = new System.Drawing.Size(98, 23);
            this.monthReception.TabIndex = 8;
            this.monthReception.Text = "Январь";
            // 
            // yearReception
            // 
            this.yearReception.Location = new System.Drawing.Point(255, 12);
            this.yearReception.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearReception.Minimum = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.yearReception.Name = "yearReception";
            this.yearReception.Size = new System.Drawing.Size(53, 20);
            this.yearReception.TabIndex = 10;
            this.yearReception.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // addReception
            // 
            this.addReception.Dock = System.Windows.Forms.DockStyle.Left;
            this.addReception.Location = new System.Drawing.Point(0, 0);
            this.addReception.Name = "addReception";
            this.addReception.Size = new System.Drawing.Size(163, 40);
            this.addReception.TabIndex = 0;
            this.addReception.Text = "Добавить";
            this.addReception.UseVisualStyleBackColor = true;
            // 
            // cancelReception
            // 
            this.cancelReception.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelReception.Location = new System.Drawing.Point(161, 0);
            this.cancelReception.Name = "cancelReception";
            this.cancelReception.Size = new System.Drawing.Size(163, 40);
            this.cancelReception.TabIndex = 1;
            this.cancelReception.Text = "Отмена";
            this.cancelReception.UseVisualStyleBackColor = true;
            // 
            // labelTimeReception
            // 
            this.labelTimeReception.AutoSize = true;
            this.labelTimeReception.Location = new System.Drawing.Point(15, 43);
            this.labelTimeReception.Name = "labelTimeReception";
            this.labelTimeReception.Size = new System.Drawing.Size(84, 13);
            this.labelTimeReception.TabIndex = 11;
            this.labelTimeReception.Text = "Время приема:";
            this.labelTimeReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourReception
            // 
            this.hourReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourReception.Location = new System.Drawing.Point(105, 39);
            this.hourReception.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourReception.Name = "hourReception";
            this.hourReception.Size = new System.Drawing.Size(40, 21);
            this.hourReception.TabIndex = 12;
            this.hourReception.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // minuteReception
            // 
            this.minuteReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteReception.Location = new System.Drawing.Point(151, 39);
            this.minuteReception.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteReception.Name = "minuteReception";
            this.minuteReception.Size = new System.Drawing.Size(42, 21);
            this.minuteReception.TabIndex = 13;
            this.minuteReception.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // AddProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 161);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddProcedureForm";
            this.Text = "AddProcedureForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayReception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearReception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourReception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteReception)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox procedureComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDateReception;
        private System.Windows.Forms.NumericUpDown dayReception;
        private System.Windows.Forms.ComboBox monthReception;
        private System.Windows.Forms.NumericUpDown minuteReception;
        private System.Windows.Forms.NumericUpDown hourReception;
        private System.Windows.Forms.Label labelTimeReception;
        private System.Windows.Forms.NumericUpDown yearReception;
        private System.Windows.Forms.Button cancelReception;
        private System.Windows.Forms.Button addReception;
    }
}