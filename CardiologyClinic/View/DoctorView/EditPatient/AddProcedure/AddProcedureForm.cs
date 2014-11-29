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
using CardiologyClinic.Help.Validator;

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
            cbMounth.SelectedIndex = 0;
        }

        private void AddProcedureForm_Load(object sender, EventArgs e)
        {
            IList<MedicalProcedure> list = controller.GetAllMedicalProcedure();

            foreach(MedicalProcedure mp in list)
            {
                procedureComboBox.Items.Add(mp.Name);
            }

            this.tbHour.Value = DateTime.Now.Hour;
            this.tbMinute.Value = DateTime.Now.Minute;
            this.tbDay.Value = DateTime.Now.Day;
            this.cbMounth.SelectedIndex = DateTime.Today.Month - 1;
            this.tbYear.Value = DateTime.Today.Year;
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

            PurposeValidator pv = new PurposeValidator();
            
            if (!pv.DatePurposeValidate(purpose))
            {
                MessageBox.Show("Назначить данную проедуру в данное время невозможно, пожалуйста выбирете другое время",
                                "Время процедуры",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            patient.Purposes.Add(purpose);

            controller.SavePurpose(purpose);
            controller.ShowAllPatientEvent();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMounth_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMounth.SelectedIndex)
            {
                case 0:
                    tbDay.Maximum = 31;
                    break;
                case 1:                    
                    if (tbYear.Value == 2016 || tbYear.Value == 2020 || tbYear.Value == 2024 || tbYear.Value == 2028 || tbYear.Value == 2032)
                        tbDay.Maximum = 29;
                    else
                        tbDay.Maximum = 28;
                    break;
                case 2:
                    tbDay.Maximum = 31;
                    break;
                case 3:
                    tbDay.Maximum = 30;
                    break;
                case 4:
                    tbDay.Maximum = 31;
                    break;
                case 5:
                    tbDay.Maximum = 30;
                    break;
                case 6:
                    tbDay.Maximum = 31;
                    break;
                case 7:
                    tbDay.Maximum = 31;
                    break;
                case 8:
                    tbDay.Maximum = 30;
                    break;
                case 9:
                    tbDay.Maximum = 31;
                    break;
                case 10:
                    tbDay.Maximum = 30;
                    break;
                case 11:
                    tbDay.Maximum = 31;
                    break;  
            }
        }
    }
}
