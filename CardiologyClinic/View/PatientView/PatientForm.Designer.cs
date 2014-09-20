namespace CardiologyClinic.View.PatientView
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoDoctorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoRoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoNurseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.todayButton = new System.Windows.Forms.ToolStripButton();
            this.allButton = new System.Windows.Forms.ToolStripButton();
            this.oldButton = new System.Windows.Forms.ToolStripButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientMenuItem
            // 
            this.patientMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoDoctorMenuItem,
            this.infoRoomMenuItem,
            this.infoNurseMenuItem});
            this.patientMenuItem.Name = "patientMenuItem";
            this.patientMenuItem.Size = new System.Drawing.Size(66, 20);
            this.patientMenuItem.Text = "Пациент";
            // 
            // infoDoctorMenuItem
            // 
            this.infoDoctorMenuItem.Name = "infoDoctorMenuItem";
            this.infoDoctorMenuItem.Size = new System.Drawing.Size(248, 22);
            this.infoDoctorMenuItem.Text = "Информация о лечащем враче";
            this.infoDoctorMenuItem.Click += new System.EventHandler(this.узнатьОЛечащемВрачеToolStripMenuItem_Click);
            // 
            // infoRoomMenuItem
            // 
            this.infoRoomMenuItem.Name = "infoRoomMenuItem";
            this.infoRoomMenuItem.Size = new System.Drawing.Size(248, 22);
            this.infoRoomMenuItem.Text = "Информация о палате";
            // 
            // infoNurseMenuItem
            // 
            this.infoNurseMenuItem.Name = "infoNurseMenuItem";
            this.infoNurseMenuItem.Size = new System.Drawing.Size(248, 22);
            this.infoNurseMenuItem.Text = "Информация о медсестре";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitMenuItem.Text = "Выход";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todayButton,
            this.allButton,
            this.oldButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // todayButton
            // 
            this.todayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.todayButton.Image = ((System.Drawing.Image)(resources.GetObject("todayButton.Image")));
            this.todayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.todayButton.Name = "todayButton";
            this.todayButton.Size = new System.Drawing.Size(56, 22);
            this.todayButton.Text = "Сегодня";
            // 
            // allButton
            // 
            this.allButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allButton.Image = ((System.Drawing.Image)(resources.GetObject("allButton.Image")));
            this.allButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(71, 22);
            this.allButton.Text = "Все записи";
            // 
            // oldButton
            // 
            this.oldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.oldButton.Image = ((System.Drawing.Image)(resources.GetObject("oldButton.Image")));
            this.oldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oldButton.Name = "oldButton";
            this.oldButton.Size = new System.Drawing.Size(81, 22);
            this.oldButton.Text = "Прошедшие";
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 49);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(607, 35);
            this.headerPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список лечебных процедур";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 286);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoDoctorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoRoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoNurseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton todayButton;
        private System.Windows.Forms.ToolStripButton allButton;
        private System.Windows.Forms.ToolStripButton oldButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
    }
}