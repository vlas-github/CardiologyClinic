namespace CardiologyClinic.View.NurseView
{
    partial class NurseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nurseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purposeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.allRoomsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.allPurposeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.todayLeastPurposeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contentGridView = new System.Windows.Forms.DataGridView();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nurseMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nurseMenuItem
            // 
            this.nurseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purposeMenuItem,
            this.toolStripSeparator1,
            this.allRoomsMenuItem,
            this.roomMenuItem,
            this.toolStripSeparator2,
            this.patientsMenuItem});
            this.nurseMenuItem.Name = "nurseMenuItem";
            this.nurseMenuItem.Size = new System.Drawing.Size(78, 20);
            this.nurseMenuItem.Text = "Медсестра";
            // 
            // purposeMenuItem
            // 
            this.purposeMenuItem.Name = "purposeMenuItem";
            this.purposeMenuItem.Size = new System.Drawing.Size(188, 22);
            this.purposeMenuItem.Text = "Все процедуры";
            this.purposeMenuItem.Click += new System.EventHandler(this.purposeMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // allRoomsMenuItem
            // 
            this.allRoomsMenuItem.Name = "allRoomsMenuItem";
            this.allRoomsMenuItem.Size = new System.Drawing.Size(188, 22);
            this.allRoomsMenuItem.Text = "Показать все палаты";
            this.allRoomsMenuItem.Click += new System.EventHandler(this.allRoomsMenuItem_Click);
            // 
            // roomMenuItem
            // 
            this.roomMenuItem.DoubleClickEnabled = true;
            this.roomMenuItem.Name = "roomMenuItem";
            this.roomMenuItem.Size = new System.Drawing.Size(188, 22);
            this.roomMenuItem.Text = "Номер палаты";
            this.roomMenuItem.DoubleClick += new System.EventHandler(this.roomMenuItem_DoubleClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // patientsMenuItem
            // 
            this.patientsMenuItem.DoubleClickEnabled = true;
            this.patientsMenuItem.Name = "patientsMenuItem";
            this.patientsMenuItem.Size = new System.Drawing.Size(188, 22);
            this.patientsMenuItem.Text = "Пациенты";
            this.patientsMenuItem.DoubleClick += new System.EventHandler(this.patientsMenuItem_DoubleClick);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allPurposeLabel,
            this.todayLeastPurposeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // allPurposeLabel
            // 
            this.allPurposeLabel.Name = "allPurposeLabel";
            this.allPurposeLabel.Size = new System.Drawing.Size(112, 17);
            this.allPurposeLabel.Text = "Всего назначений: ";
            // 
            // todayLeastPurposeLabel
            // 
            this.todayLeastPurposeLabel.Name = "todayLeastPurposeLabel";
            this.todayLeastPurposeLabel.Size = new System.Drawing.Size(111, 17);
            this.todayLeastPurposeLabel.Text = "Сегодня осталось: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Выполнить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contentGridView
            // 
            this.contentGridView.AllowUserToAddRows = false;
            this.contentGridView.AllowUserToResizeRows = false;
            this.contentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contentGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentGridView.Location = new System.Drawing.Point(0, 84);
            this.contentGridView.MultiSelect = false;
            this.contentGridView.Name = "contentGridView";
            this.contentGridView.ReadOnly = true;
            this.contentGridView.RowHeadersVisible = false;
            this.contentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contentGridView.Size = new System.Drawing.Size(484, 176);
            this.contentGridView.TabIndex = 9;
            this.contentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contentGridView_CellContentClick);
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 49);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(484, 35);
            this.headerPanel.TabIndex = 8;
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
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.contentGridView);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "NurseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NurseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NurseForm_FormClosing);
            this.Load += new System.EventHandler(this.NurseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nurseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purposeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem allRoomsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem patientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel allPurposeLabel;
        private System.Windows.Forms.ToolStripStatusLabel todayLeastPurposeLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView contentGridView;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
    }
}