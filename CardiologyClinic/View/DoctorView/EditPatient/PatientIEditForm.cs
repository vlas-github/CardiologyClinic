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
            // to do отобразить все процедуры
        }
    }
}
