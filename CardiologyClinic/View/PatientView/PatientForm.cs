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
            this.contentGridView.Columns.Add("isComplete", "Выполнено");

            int i = 0;

            foreach (Purpose p in purposes)
            {
                this.contentGridView.Rows.Add(
                    ++i,
                    p.MedicalProcedure.Name,
                    p.MedicalProcedure.Description,
                    p.DateOfProcedure,
                    p.IsComplete);
            }
            this.toolStripStatusLabel1.Text = "Всего процедур: " + purposes.Count.ToString();
            this.toolStripStatusLabel2.Text = "Дата поступления: " + patientController.GetDateIn().ToString();
            this.toolStripStatusLabel3.Text = "Дата выписки: " + patientController.GetDateOut().ToString();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
