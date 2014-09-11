namespace CardiologyClinic.View.MainDoctor.EditPatient
{
    partial class EditPatientForm
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
            this.content = new System.Windows.Forms.Panel();
            this.contentContainer = new System.Windows.Forms.SplitContainer();
            this.footer = new System.Windows.Forms.Panel();
            this.footerFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.dataInLabel = new System.Windows.Forms.Label();
            this.dataOutLabel = new System.Windows.Forms.Label();
            this.diseaseLabel = new System.Windows.Forms.Label();
            this.editName = new System.Windows.Forms.TextBox();
            this.editPass = new System.Windows.Forms.TextBox();
            this.editDoctor = new System.Windows.Forms.ComboBox();
            this.editDisease = new System.Windows.Forms.ComboBox();
            this.monthIn = new System.Windows.Forms.ComboBox();
            this.dayIn = new System.Windows.Forms.NumericUpDown();
            this.yearIn = new System.Windows.Forms.TextBox();
            this.hourIn = new System.Windows.Forms.NumericUpDown();
            this.minuteIt = new System.Windows.Forms.NumericUpDown();
            this.minuteOut = new System.Windows.Forms.NumericUpDown();
            this.hourOut = new System.Windows.Forms.NumericUpDown();
            this.yearOut = new System.Windows.Forms.TextBox();
            this.dayOut = new System.Windows.Forms.NumericUpDown();
            this.monthOut = new System.Windows.Forms.ComboBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.editNumber = new System.Windows.Forms.ComboBox();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentContainer)).BeginInit();
            this.contentContainer.Panel1.SuspendLayout();
            this.contentContainer.Panel2.SuspendLayout();
            this.contentContainer.SuspendLayout();
            this.footer.SuspendLayout();
            this.footerFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteIt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOut)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.contentContainer);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(513, 265);
            this.content.TabIndex = 3;
            // 
            // contentContainer
            // 
            this.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentContainer.Location = new System.Drawing.Point(0, 0);
            this.contentContainer.Name = "contentContainer";
            // 
            // contentContainer.Panel1
            // 
            this.contentContainer.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contentContainer.Panel1.Controls.Add(this.numberLabel);
            this.contentContainer.Panel1.Controls.Add(this.diseaseLabel);
            this.contentContainer.Panel1.Controls.Add(this.dataOutLabel);
            this.contentContainer.Panel1.Controls.Add(this.dataInLabel);
            this.contentContainer.Panel1.Controls.Add(this.doctorLabel);
            this.contentContainer.Panel1.Controls.Add(this.passLabel);
            this.contentContainer.Panel1.Controls.Add(this.nameLabel);
            // 
            // contentContainer.Panel2
            // 
            this.contentContainer.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contentContainer.Panel2.Controls.Add(this.editNumber);
            this.contentContainer.Panel2.Controls.Add(this.minuteOut);
            this.contentContainer.Panel2.Controls.Add(this.hourOut);
            this.contentContainer.Panel2.Controls.Add(this.yearOut);
            this.contentContainer.Panel2.Controls.Add(this.dayOut);
            this.contentContainer.Panel2.Controls.Add(this.monthOut);
            this.contentContainer.Panel2.Controls.Add(this.minuteIt);
            this.contentContainer.Panel2.Controls.Add(this.hourIn);
            this.contentContainer.Panel2.Controls.Add(this.yearIn);
            this.contentContainer.Panel2.Controls.Add(this.dayIn);
            this.contentContainer.Panel2.Controls.Add(this.monthIn);
            this.contentContainer.Panel2.Controls.Add(this.editDisease);
            this.contentContainer.Panel2.Controls.Add(this.editDoctor);
            this.contentContainer.Panel2.Controls.Add(this.editPass);
            this.contentContainer.Panel2.Controls.Add(this.editName);
            this.contentContainer.Size = new System.Drawing.Size(513, 265);
            this.contentContainer.SplitterDistance = 187;
            this.contentContainer.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.footerFlowLayout);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 265);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(513, 50);
            this.footer.TabIndex = 2;
            // 
            // footerFlowLayout
            // 
            this.footerFlowLayout.AutoSize = true;
            this.footerFlowLayout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.footerFlowLayout.Controls.Add(this.save);
            this.footerFlowLayout.Controls.Add(this.reset);
            this.footerFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.footerFlowLayout.Name = "footerFlowLayout";
            this.footerFlowLayout.Size = new System.Drawing.Size(513, 50);
            this.footerFlowLayout.TabIndex = 0;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(10, 10);
            this.save.Margin = new System.Windows.Forms.Padding(10);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 30);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(118, 10);
            this.reset.Margin = new System.Windows.Forms.Padding(10);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(88, 30);
            this.reset.TabIndex = 1;
            this.reset.Text = "Отменить";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ф.И.О. пациента:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(12, 54);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(105, 15);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Пароль для входа:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorLabel.Location = new System.Drawing.Point(12, 86);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(90, 15);
            this.doctorLabel.TabIndex = 2;
            this.doctorLabel.Text = "Лечащий врач:";
            // 
            // dataInLabel
            // 
            this.dataInLabel.AutoSize = true;
            this.dataInLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataInLabel.Location = new System.Drawing.Point(12, 122);
            this.dataInLabel.Name = "dataInLabel";
            this.dataInLabel.Size = new System.Drawing.Size(110, 15);
            this.dataInLabel.TabIndex = 3;
            this.dataInLabel.Text = "Дата поступления:";
            // 
            // dataOutLabel
            // 
            this.dataOutLabel.AutoSize = true;
            this.dataOutLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataOutLabel.Location = new System.Drawing.Point(12, 159);
            this.dataOutLabel.Name = "dataOutLabel";
            this.dataOutLabel.Size = new System.Drawing.Size(87, 15);
            this.dataOutLabel.TabIndex = 4;
            this.dataOutLabel.Text = "Дата выписки:";
            // 
            // diseaseLabel
            // 
            this.diseaseLabel.AutoSize = true;
            this.diseaseLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diseaseLabel.Location = new System.Drawing.Point(12, 192);
            this.diseaseLabel.Name = "diseaseLabel";
            this.diseaseLabel.Size = new System.Drawing.Size(141, 15);
            this.diseaseLabel.TabIndex = 5;
            this.diseaseLabel.Text = "Наименование болезни:";
            // 
            // editName
            // 
            this.editName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editName.Location = new System.Drawing.Point(14, 17);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(296, 22);
            this.editName.TabIndex = 0;
            // 
            // editPass
            // 
            this.editPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPass.Location = new System.Drawing.Point(14, 52);
            this.editPass.Name = "editPass";
            this.editPass.Size = new System.Drawing.Size(296, 22);
            this.editPass.TabIndex = 1;
            // 
            // editDoctor
            // 
            this.editDoctor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDoctor.FormattingEnabled = true;
            this.editDoctor.Location = new System.Drawing.Point(14, 84);
            this.editDoctor.Name = "editDoctor";
            this.editDoctor.Size = new System.Drawing.Size(296, 23);
            this.editDoctor.TabIndex = 2;
            this.editDoctor.Text = "Выберите лечащего врача";
            // 
            // editDisease
            // 
            this.editDisease.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDisease.FormattingEnabled = true;
            this.editDisease.Location = new System.Drawing.Point(14, 190);
            this.editDisease.Name = "editDisease";
            this.editDisease.Size = new System.Drawing.Size(296, 23);
            this.editDisease.TabIndex = 3;
            this.editDisease.Text = "Выберите болезнь пациента";
            // 
            // monthIn
            // 
            this.monthIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthIn.FormattingEnabled = true;
            this.monthIn.Items.AddRange(new object[] {
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
            this.monthIn.Location = new System.Drawing.Point(60, 120);
            this.monthIn.Name = "monthIn";
            this.monthIn.Size = new System.Drawing.Size(73, 23);
            this.monthIn.TabIndex = 5;
            this.monthIn.Text = "Январь";
            // 
            // dayIn
            // 
            this.dayIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayIn.Location = new System.Drawing.Point(14, 121);
            this.dayIn.Name = "dayIn";
            this.dayIn.Size = new System.Drawing.Size(40, 22);
            this.dayIn.TabIndex = 6;
            this.dayIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearIn
            // 
            this.yearIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearIn.Location = new System.Drawing.Point(139, 120);
            this.yearIn.Name = "yearIn";
            this.yearIn.Size = new System.Drawing.Size(42, 22);
            this.yearIn.TabIndex = 7;
            this.yearIn.Text = "2014";
            // 
            // hourIn
            // 
            this.hourIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourIn.Location = new System.Drawing.Point(213, 121);
            this.hourIn.Name = "hourIn";
            this.hourIn.Size = new System.Drawing.Size(46, 22);
            this.hourIn.TabIndex = 8;
            // 
            // minuteIt
            // 
            this.minuteIt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteIt.Location = new System.Drawing.Point(268, 121);
            this.minuteIt.Name = "minuteIt";
            this.minuteIt.Size = new System.Drawing.Size(42, 22);
            this.minuteIt.TabIndex = 9;
            // 
            // minuteOut
            // 
            this.minuteOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteOut.Location = new System.Drawing.Point(268, 157);
            this.minuteOut.Name = "minuteOut";
            this.minuteOut.Size = new System.Drawing.Size(42, 22);
            this.minuteOut.TabIndex = 15;
            // 
            // hourOut
            // 
            this.hourOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourOut.Location = new System.Drawing.Point(215, 156);
            this.hourOut.Name = "hourOut";
            this.hourOut.Size = new System.Drawing.Size(44, 22);
            this.hourOut.TabIndex = 14;
            // 
            // yearOut
            // 
            this.yearOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearOut.Location = new System.Drawing.Point(139, 156);
            this.yearOut.Name = "yearOut";
            this.yearOut.Size = new System.Drawing.Size(42, 22);
            this.yearOut.TabIndex = 13;
            this.yearOut.Text = "2014";
            // 
            // dayOut
            // 
            this.dayOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayOut.Location = new System.Drawing.Point(14, 157);
            this.dayOut.Name = "dayOut";
            this.dayOut.Size = new System.Drawing.Size(40, 22);
            this.dayOut.TabIndex = 12;
            this.dayOut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthOut
            // 
            this.monthOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthOut.FormattingEnabled = true;
            this.monthOut.Items.AddRange(new object[] {
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
            this.monthOut.Location = new System.Drawing.Point(60, 156);
            this.monthOut.Name = "monthOut";
            this.monthOut.Size = new System.Drawing.Size(73, 23);
            this.monthOut.TabIndex = 11;
            this.monthOut.Text = "Январь";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(12, 226);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(93, 16);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Номер палаты:";
            // 
            // editNumber
            // 
            this.editNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editNumber.FormattingEnabled = true;
            this.editNumber.Location = new System.Drawing.Point(14, 224);
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(296, 23);
            this.editNumber.TabIndex = 16;
            this.editNumber.Text = "Выберите палату";
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.content);
            this.Controls.Add(this.footer);
            this.Name = "EditPatientForm";
            this.Text = "EditPatientForm";
            this.content.ResumeLayout(false);
            this.contentContainer.Panel1.ResumeLayout(false);
            this.contentContainer.Panel1.PerformLayout();
            this.contentContainer.Panel2.ResumeLayout(false);
            this.contentContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentContainer)).EndInit();
            this.contentContainer.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.footerFlowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteIt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.SplitContainer contentContainer;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.FlowLayoutPanel footerFlowLayout;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label diseaseLabel;
        private System.Windows.Forms.Label dataOutLabel;
        private System.Windows.Forms.Label dataInLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown minuteOut;
        private System.Windows.Forms.NumericUpDown hourOut;
        private System.Windows.Forms.TextBox yearOut;
        private System.Windows.Forms.NumericUpDown dayOut;
        private System.Windows.Forms.ComboBox monthOut;
        private System.Windows.Forms.NumericUpDown minuteIt;
        private System.Windows.Forms.NumericUpDown hourIn;
        private System.Windows.Forms.TextBox yearIn;
        private System.Windows.Forms.NumericUpDown dayIn;
        private System.Windows.Forms.ComboBox monthIn;
        private System.Windows.Forms.ComboBox editDisease;
        private System.Windows.Forms.ComboBox editDoctor;
        private System.Windows.Forms.TextBox editPass;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ComboBox editNumber;
    }
}