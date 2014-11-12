using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;
using CardiologyClinic.Bean;

namespace CardiologyClinic.View.DoctorView
{
    public partial class DoctorForm : Form
    {
        private DoctorController doctorController;

        public DoctorForm()
        {
            InitializeComponent();
        }

        public DoctorForm(DoctorController doctorController)
            : this()
        {
            this.doctorController = doctorController;
        }

        public void ShowDoctorName(string name)
        {
            this.Text = name;
        }

        public void ShowAllPatients(IList<Patient> patients)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.ReadOnly = true;
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("purposes", "Колличество назначений");
            this.contentGridView.Columns.Add("dateRoom", "Палата");
            this.contentGridView.Columns.Add("dateDisease", "Диагноз");
            this.contentGridView.Columns.Add("dateIn", "Дата поступления");
            this.contentGridView.Columns.Add("dateOut", "Дата выписки");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[1].MinimumWidth = 180;
            this.contentGridView.Columns[1].Width = 180;

            this.contentGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[2].MinimumWidth = 80;
            this.contentGridView.Columns[2].Width = 80;

            this.contentGridView.Columns[3].MinimumWidth = 50;
            this.contentGridView.Columns[3].Width = 50;

            this.contentGridView.Columns[4].MinimumWidth = 60;
            this.contentGridView.Columns[4].Width = 100;

            this.contentGridView.Columns[5].MinimumWidth = 50;
            this.contentGridView.Columns[5].Width = 70;

            this.contentGridView.Columns[6].MinimumWidth = 50;
            this.contentGridView.Columns[6].Width = 70;

            this.contentGridView.Columns[7].Width = 0;
            this.contentGridView.Columns[7].Visible = false;

            for (int i = 0; i < patients.Count; i++)
            {
                patients[i].Purposes = doctorController.GetPurposesByPatient(patients[i]);

                this.contentGridView.Rows.Add(
                    i + 1,
                    patients[i].Name,
                    patients[i].Purposes.Count,
                    patients[i].Room.Number,
                    patients[i].Disease.Name,
                    patients[i].DateIn.ToShortDateString(),
                    patients[i].DateOut.ToShortDateString(),
                    patients[i].Id);
            }
            this.allPatientsLabel.Text = "Количество пациентов - " + patients.Count.ToString();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            doctorController.ShowAllPatientEvent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Patient patient = doctorController.GetPatientById(contentGridView.CurrentRow.Cells[7].Value.ToString());
            doctorController.EditPatientEvent(patient);        
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
