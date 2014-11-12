using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Bean;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.DoctorView.EditPatient.EditProcedure
{
    public partial class AddProcedureForm : Form
    {
        private Patient patient;
        private DoctorController controller;

        public AddProcedureForm()
        {
            InitializeComponent();
        }

        public AddProcedureForm(DoctorController controller, Patient patient)
            : this()
        {
            this.controller = controller;
            this.patient = patient;
        }

        private void AddProcedureForm_Load(object sender, EventArgs e)
        {
            IList<MedicalProcedure> list = controller.GetAllMedicalProcedure();

            foreach(MedicalProcedure mp in list)
            {
                procedureComboBox.Items.Add(mp.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purpose purpose = new Purpose();
            purpose.Patient = patient;
            purpose.MedicalProcedure = controller
                .GetMedicalProcedureByName(procedureComboBox.SelectedItem.ToString());
            purpose.IsComplete = false;
            int year = int.Parse(tbYear.Text);
            int month = cbMounth.SelectedIndex + 1;
            int day = (int)tbDay.Value;
            int hour = (int)tbHour.Value;
            int minute = (int)tbMinute.Value;
            purpose.DateOfProcedure = new DateTime(year, month, day, hour, minute, 0);

            patient.Purposes.Add(purpose);

            controller.SavePurpose(purpose);

            Close();
        }
    }
}
