namespace CardiologyClinic.View.MainDoctorView
{
    partial class MainDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDoctorForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainDoctorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalProcMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diseaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.doctorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.roomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.removeButton = new System.Windows.Forms.ToolStripButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.recordCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.contentGridView = new System.Windows.Forms.DataGridView();
            this.mainMenu.SuspendLayout();
            this.tools.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainDoctorMenuItem,
            this.exitMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainDoctorMenuItem
            // 
            this.mainDoctorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicalProcMenuItem,
            this.diseaseMenuItem,
            this.toolStripMenuItem1,
            this.doctorMenuItem,
            this.nurseMenuItem,
            this.patientMenuItem,
            this.toolStripMenuItem2,
            this.roomMenuItem});
            this.mainDoctorMenuItem.Name = "mainDoctorMenuItem";
            this.mainDoctorMenuItem.Size = new System.Drawing.Size(75, 20);
            this.mainDoctorMenuItem.Text = "Глав-врач";
            // 
            // medicalProcMenuItem
            // 
            this.medicalProcMenuItem.Name = "medicalProcMenuItem";
            this.medicalProcMenuItem.Size = new System.Drawing.Size(228, 22);
            this.medicalProcMenuItem.Text = "Список лечебных процедур";
            this.medicalProcMenuItem.Click += new System.EventHandler(this.medicalProcMenuItem_Click);
            // 
            // diseaseMenuItem
            // 
            this.diseaseMenuItem.Name = "diseaseMenuItem";
            this.diseaseMenuItem.Size = new System.Drawing.Size(228, 22);
            this.diseaseMenuItem.Text = "Список болезней";
            this.diseaseMenuItem.Click += new System.EventHandler(this.diseaseMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // doctorMenuItem
            // 
            this.doctorMenuItem.Name = "doctorMenuItem";
            this.doctorMenuItem.Size = new System.Drawing.Size(228, 22);
            this.doctorMenuItem.Text = "Список врачей";
            this.doctorMenuItem.Click += new System.EventHandler(this.doctorMenuItem_Click);
            // 
            // nurseMenuItem
            // 
            this.nurseMenuItem.Name = "nurseMenuItem";
            this.nurseMenuItem.Size = new System.Drawing.Size(228, 22);
            this.nurseMenuItem.Text = "Список медсестер";
            this.nurseMenuItem.Click += new System.EventHandler(this.nurseMenuItem_Click);
            // 
            // patientMenuItem
            // 
            this.patientMenuItem.Name = "patientMenuItem";
            this.patientMenuItem.Size = new System.Drawing.Size(228, 22);
            this.patientMenuItem.Text = "Список пациентов";
            this.patientMenuItem.Click += new System.EventHandler(this.patientMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
            // 
            // roomMenuItem
            // 
            this.roomMenuItem.Name = "roomMenuItem";
            this.roomMenuItem.Size = new System.Drawing.Size(228, 22);
            this.roomMenuItem.Text = "Список больничных палат";
            this.roomMenuItem.Click += new System.EventHandler(this.roomMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.editButton,
            this.removeButton});
            this.tools.Location = new System.Drawing.Point(0, 24);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(784, 25);
            this.tools.TabIndex = 1;
            this.tools.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 22);
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(65, 22);
            this.editButton.Text = "Изменить";
            // 
            // removeButton
            // 
            this.removeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(55, 22);
            this.removeButton.Text = "Удалить";
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 49);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(784, 35);
            this.headerPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.titleLabel.Size = new System.Drawing.Size(236, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Список лечебных процедур";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordCountStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // recordCountStatusLabel
            // 
            this.recordCountStatusLabel.Name = "recordCountStatusLabel";
            this.recordCountStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.contentGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 84);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(784, 298);
            this.contentPanel.TabIndex = 4;
            // 
            // contentGridView
            // 
            this.contentGridView.AllowUserToAddRows = false;
            this.contentGridView.AllowUserToResizeRows = false;
            this.contentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contentGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentGridView.Location = new System.Drawing.Point(0, 0);
            this.contentGridView.MultiSelect = false;
            this.contentGridView.Name = "contentGridView";
            this.contentGridView.ReadOnly = true;
            this.contentGridView.RowHeadersVisible = false;
            this.contentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contentGridView.Size = new System.Drawing.Size(784, 298);
            this.contentGridView.TabIndex = 0;
            this.contentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contentGridView_CellContentClick);
            this.contentGridView.SelectionChanged += new System.EventHandler(this.contentGridView_SelectionChanged);
            // 
            // MainDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 404);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainDoctorForm";
            this.Text = "Глав-врач - Фамилия Имя Отчество";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainDoctorForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainDoctorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalProcMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diseaseMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doctorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem roomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripButton removeButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel recordCountStatusLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView contentGridView;
    }
}