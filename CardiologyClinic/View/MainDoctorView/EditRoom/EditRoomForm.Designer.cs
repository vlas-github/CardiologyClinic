namespace CardiologyClinic.View.MainDoctor.EditRoom
{
    partial class EditRoomForm
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
            this.nurseLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.editNurse = new System.Windows.Forms.ComboBox();
            this.editSize = new System.Windows.Forms.TextBox();
            this.editNumber = new System.Windows.Forms.TextBox();
            this.footer = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentContainer)).BeginInit();
            this.contentContainer.Panel1.SuspendLayout();
            this.contentContainer.Panel2.SuspendLayout();
            this.contentContainer.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.contentContainer);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(484, 91);
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
            this.contentContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.contentContainer.Panel1.Controls.Add(this.nurseLabel);
            this.contentContainer.Panel1.Controls.Add(this.sizeLabel);
            this.contentContainer.Panel1.Controls.Add(this.numberLabel);
            // 
            // contentContainer.Panel2
            // 
            this.contentContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.contentContainer.Panel2.Controls.Add(this.editNurse);
            this.contentContainer.Panel2.Controls.Add(this.editSize);
            this.contentContainer.Panel2.Controls.Add(this.editNumber);
            this.contentContainer.Size = new System.Drawing.Size(484, 91);
            this.contentContainer.SplitterDistance = 177;
            this.contentContainer.TabIndex = 0;
            // 
            // nurseLabel
            // 
            this.nurseLabel.AutoSize = true;
            this.nurseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nurseLabel.Location = new System.Drawing.Point(95, 69);
            this.nurseLabel.Name = "nurseLabel";
            this.nurseLabel.Size = new System.Drawing.Size(85, 15);
            this.nurseLabel.TabIndex = 2;
            this.nurseLabel.Text = "Медсестра:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(65, 42);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(115, 15);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Размер палаты:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(71, 15);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(109, 15);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Номер палаты:";
            // 
            // editNurse
            // 
            this.editNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editNurse.FormattingEnabled = true;
            this.editNurse.Location = new System.Drawing.Point(3, 66);
            this.editNurse.Name = "editNurse";
            this.editNurse.Size = new System.Drawing.Size(277, 23);
            this.editNurse.TabIndex = 2;
            this.editNurse.Text = "Выберите ответственную медсестру";
            // 
            // editSize
            // 
            this.editSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSize.Location = new System.Drawing.Point(3, 39);
            this.editSize.Name = "editSize";
            this.editSize.Size = new System.Drawing.Size(277, 21);
            this.editSize.TabIndex = 1;
            // 
            // editNumber
            // 
            this.editNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editNumber.Location = new System.Drawing.Point(3, 12);
            this.editNumber.Name = "editNumber";
            this.editNumber.Size = new System.Drawing.Size(277, 21);
            this.editNumber.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.save);
            this.footer.Controls.Add(this.reset);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 91);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(484, 50);
            this.footer.TabIndex = 2;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(182, 10);
            this.save.Margin = new System.Windows.Forms.Padding(8);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 30);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(286, 10);
            this.reset.Margin = new System.Windows.Forms.Padding(8);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(88, 30);
            this.reset.TabIndex = 3;
            this.reset.Text = "Отменить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // EditRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 141);
            this.Controls.Add(this.content);
            this.Controls.Add(this.footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EditRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditRoomForm";
            this.Load += new System.EventHandler(this.EditRoomForm_Load);
            this.content.ResumeLayout(false);
            this.contentContainer.Panel1.ResumeLayout(false);
            this.contentContainer.Panel1.PerformLayout();
            this.contentContainer.Panel2.ResumeLayout(false);
            this.contentContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentContainer)).EndInit();
            this.contentContainer.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.SplitContainer contentContainer;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label nurseLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ComboBox editNurse;
        private System.Windows.Forms.TextBox editSize;
        private System.Windows.Forms.TextBox editNumber;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
    }
}