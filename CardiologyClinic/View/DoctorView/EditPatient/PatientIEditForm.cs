using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;
using CardiologyClinic.Help;
using CardiologyClinic.Bean;

namespace CardiologyClinic.View.DoctorView.InfoEditPatient
{
    public partial class PatientIEditForm : Form
    {
        Patient patient;

        DoctorController controller;

        public PatientIEditForm()
        {
            InitializeComponent();
        }

        public PatientIEditForm(DoctorController controller, Patient patient) 
            : this()
        {
            this.controller = controller;
            this.patient = patient;
        }

        private void PatientIEditForm_Load(object sender, EventArgs e)
        {
            patient.Purposes = controller.GetPurposesByPatient(patient);
            this.ShowPurposes(patient.Purposes);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.AddProcedureEvent(patient);
        }

        private void ShowPurposes(ICollection<Purpose> purposes)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.ReadOnly = true;
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Название");
            this.contentGridView.Columns.Add("date", "Дата");
            this.contentGridView.Columns.Add("complete", "Выполнение");
            this.contentGridView.Columns.Add("id", "id");

            int i = 0;

            foreach (Purpose purpose in purposes)
            {
                this.contentGridView.Rows.Add(
                    i++,
                    purpose.MedicalProcedure.Name,
                    purpose.DateOfProcedure,
                    purpose.IsComplete ? "Выполнена" : "Не выполнена",
                    purpose.Id);
            }
        }
    }
}
