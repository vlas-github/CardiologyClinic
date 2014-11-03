namespace CardiologyClinic.View.MainDoctor.EditMedicalProcedure
{
    partial class EditMedicalProcedureForm
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.editDescription = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
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
            this.content.Size = new System.Drawing.Size(484, 132);
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
            this.contentContainer.Panel1.Controls.Add(this.descriptionLabel);
            this.contentContainer.Panel1.Controls.Add(this.nameLabel);
            // 
            // contentContainer.Panel2
            // 
            this.contentContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.contentContainer.Panel2.Controls.Add(this.editDescription);
            this.contentContainer.Panel2.Controls.Add(this.editName);
            this.contentContainer.Size = new System.Drawing.Size(484, 132);
            this.contentContainer.SplitterDistance = 158;
            this.contentContainer.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(7, 50);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(152, 15);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Описание процедуры:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(7, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название процедуры:";
            // 
            // editDescription
            // 
            this.editDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editDescription.Location = new System.Drawing.Point(3, 47);
            this.editDescription.Multiline = true;
            this.editDescription.Name = "editDescription";
            this.editDescription.Size = new System.Drawing.Size(303, 83);
            this.editDescription.TabIndex = 1;
            // 
            // editName
            // 
            this.editName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editName.Location = new System.Drawing.Point(3, 20);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(303, 21);
            this.editName.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.save);
            this.footer.Controls.Add(this.reset);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 132);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(484, 50);
            this.footer.TabIndex = 2;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(165, 10);
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
            this.reset.Location = new System.Drawing.Point(269, 10);
            this.reset.Margin = new System.Windows.Forms.Padding(8);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(88, 30);
            this.reset.TabIndex = 3;
            this.reset.Text = "Отменить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // EditMedicalProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 182);
            this.Controls.Add(this.content);
            this.Controls.Add(this.footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EditMedicalProcedureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditMedicalProcedureForm";
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
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox editDescription;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
    }
}