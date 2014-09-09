﻿namespace CardiologyClinic.View.MainDoctor.EditNurse
{
    partial class EditNurseForm
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
            this.editName = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.editPass = new System.Windows.Forms.TextBox();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentContainer)).BeginInit();
            this.contentContainer.Panel1.SuspendLayout();
            this.contentContainer.Panel2.SuspendLayout();
            this.contentContainer.SuspendLayout();
            this.footer.SuspendLayout();
            this.footerFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Controls.Add(this.contentContainer);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(444, 168);
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
            this.contentContainer.Panel1.Controls.Add(this.passLabel);
            this.contentContainer.Panel1.Controls.Add(this.nameLable);
            this.contentContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.contentContainer_Panel1_Paint);
            // 
            // contentContainer.Panel2
            // 
            this.contentContainer.Panel2.Controls.Add(this.editPass);
            this.contentContainer.Panel2.Controls.Add(this.editName);
            this.contentContainer.Size = new System.Drawing.Size(444, 168);
            this.contentContainer.SplitterDistance = 137;
            this.contentContainer.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.footerFlowLayout);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 168);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(444, 50);
            this.footer.TabIndex = 2;
            // 
            // footerFlowLayout
            // 
            this.footerFlowLayout.AutoSize = true;
            this.footerFlowLayout.Controls.Add(this.save);
            this.footerFlowLayout.Controls.Add(this.reset);
            this.footerFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.footerFlowLayout.Name = "footerFlowLayout";
            this.footerFlowLayout.Size = new System.Drawing.Size(444, 50);
            this.footerFlowLayout.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(10, 10);
            this.save.Margin = new System.Windows.Forms.Padding(10);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(105, 10);
            this.reset.Margin = new System.Windows.Forms.Padding(10);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 1;
            this.reset.Text = "Отменить";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // editName
            // 
            this.editName.Location = new System.Drawing.Point(14, 22);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(277, 20);
            this.editName.TabIndex = 0;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(13, 25);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(92, 13);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "Имя медсестры:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(13, 55);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(101, 13);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Пароль для входа:";
            // 
            // editPass
            // 
            this.editPass.Location = new System.Drawing.Point(14, 55);
            this.editPass.Name = "editPass";
            this.editPass.Size = new System.Drawing.Size(136, 20);
            this.editPass.TabIndex = 1;
            // 
            // EditNurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 218);
            this.Controls.Add(this.content);
            this.Controls.Add(this.footer);
            this.Name = "EditNurseForm";
            this.Text = "EditNurseForm";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.SplitContainer contentContainer;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.FlowLayoutPanel footerFlowLayout;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox editPass;
        private System.Windows.Forms.TextBox editName;
    }
}