using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;
using CardiologyClinic.View.PatientView.InfoDoctor;
using CardiologyClinic.View.PatientView.InfoRoom;
using CardiologyClinic.View.PatientView.InfoNurse;
using CardiologyClinic.Bean;

namespace CardiologyClinic.View.PatientView
{
    public partial class PatientForm : Form
    {
        private PatientController patientController;

        public PatientForm()
        {
            InitializeComponent();
        }

        public PatientForm(PatientController patientController)
            : this()
        {
            this.patientController = patientController;
        }

        public void ShowPatientName(string name)
        {
            this.Text = name;
        }

        private void infoDoctorMenuItem_Click(object sender, EventArgs e)
        {
            new InfoDoctorForm(patientController.GetDoctor()).ShowDialog();
        }

        private void infoRoomMenuItem_Click(object sender, EventArgs e)
        {
            new InfoRoomForm(patientController.GetRoom()).ShowDialog();
        }

        private void infoNurseMenuItem_Click(object sender, EventArgs e)
        {
            new InfoNurseForm(patientController.GetNurse()).ShowDialog();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            patientController.ShowAllPurpose();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            patientController.ShowAllPurpose();
        }

        private void todayButton_Click(object sender, EventArgs e)
        {
            patientController.ShowNewPurpose();
        }

        private void oldButton_Click(object sender, EventArgs e)
        {
            patientController.ShowOldPurpose();
        }

        public void ShowPurpose(ICollection<Purpose> purposes)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("purpose", "Название процедуры");
            this.contentGridView.Columns.Add("description", "Описание процедуры");
            this.contentGridView.Columns.Add("date", "Дата");
            this.contentGridView.Columns.Add("isComplete", "Выполнение");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].MinimumWidth = 180;
            this.contentGridView.Columns[1].Width = 180;

            this.contentGridView.Columns[2].MinimumWidth = 100;
            this.contentGridView.Columns[2].Width = 200;

            this.contentGridView.Columns[3].MinimumWidth = 40;
            this.contentGridView.Columns[3].Width = 80;

            this.contentGridView.Columns[4].MinimumWidth = 60;
            this.contentGridView.Columns[4].Width = 100;

            this.contentGridView.Columns[5].Width = 0;
            this.contentGridView.Columns[5].Visible = false; 

            int i = 0;

            foreach (Purpose p in purposes)
            {
                this.contentGridView.Rows.Add(
                    ++i,
                    p.MedicalProcedure.Name,
                    p.MedicalProcedure.Description,
                    p.DateOfProcedure,
                    p.IsComplete ? "Выполнено" : "Не выполнено",
                    p.Id);
            }

            this.toolStripStatusLabel1.Text = "Всего процедур: " + purposes.Count.ToString();
            this.toolStripStatusLabel2.Text = "Дата поступления: " + patientController.GetDateIn().ToString();
            this.toolStripStatusLabel3.Text = "Дата выписки: " + patientController.GetDateOut().ToString();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
