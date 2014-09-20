namespace CardiologyClinic.View.PatientView.InfoRoom
{
    partial class InfoRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberRoomLabel = new System.Windows.Forms.Label();
            this.sizeRoomLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о палате";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberRoomLabel
            // 
            this.numberRoomLabel.AutoSize = true;
            this.numberRoomLabel.Location = new System.Drawing.Point(21, 37);
            this.numberRoomLabel.Name = "numberRoomLabel";
            this.numberRoomLabel.Size = new System.Drawing.Size(84, 13);
            this.numberRoomLabel.TabIndex = 1;
            this.numberRoomLabel.Text = "Номер палаты:";
            // 
            // sizeRoomLabel
            // 
            this.sizeRoomLabel.AutoSize = true;
            this.sizeRoomLabel.Location = new System.Drawing.Point(21, 60);
            this.sizeRoomLabel.Name = "sizeRoomLabel";
            this.sizeRoomLabel.Size = new System.Drawing.Size(89, 13);
            this.sizeRoomLabel.TabIndex = 2;
            this.sizeRoomLabel.Text = "Размер палаты:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(112, 37);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(13, 13);
            this.numberLabel.TabIndex = 4;
            this.numberLabel.Text = "1";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(112, 60);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(13, 13);
            this.roomLabel.TabIndex = 5;
            this.roomLabel.Text = "1";
            // 
            // InfoRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 116);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sizeRoomLabel);
            this.Controls.Add(this.numberRoomLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfoRoomForm";
            this.Text = "InfoRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberRoomLabel;
        private System.Windows.Forms.Label sizeRoomLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label roomLabel;
    }
}