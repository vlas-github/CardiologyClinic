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

namespace CardiologyClinic.View.MainDoctor.EditPatient
{
    public partial class EditPatientForm : Form
    {
        private MainDoctorController mainDoctorController;
        private Patient patient;

        public EditPatientForm()
        {
            InitializeComponent();
        }

        public EditPatientForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.Text = "Добавление пациента";
            this.patient = new Patient();
            this.mainDoctorController = mainDoctorController;
            fillLists(this.mainDoctorController);
        }

        public EditPatientForm(MainDoctorController mainDoctorController, Patient editPatient)
            : this()
        {
            this.Text = "Изменение пациента";    
            this.mainDoctorController = mainDoctorController;
            fillLists(this.mainDoctorController);
            this.editName.Text = editPatient.Name.ToString();
            this.editPass.Text = editPatient.Password.ToString();
            this.editDoctor.SelectedIndex = this.editDoctor.FindString(editPatient.Doctor.Name.ToString());
            this.dayIn.Value = editPatient.DateIn.Day;
            this.monthIn.SelectedIndex = editPatient.DateIn.Month - 1;
            this.yearIn.Text = editPatient.DateIn.Year.ToString();
            this.dayOut.Value = editPatient.DateOut.Day;
            this.monthOut.SelectedIndex = editPatient.DateOut.Month - 1;
            this.yearOut.Text = editPatient.DateOut.Year.ToString();
            this.editDisease.SelectedIndex = this.editDisease.FindString(editPatient.Disease.Name.ToString());
            this.editNumber.SelectedIndex = this.editNumber.FindString(editPatient.Room.Number.ToString());  
            this.patient = editPatient;
        }

        private void save_Click(object sender, EventArgs e)
        {            
            patient.Name = editName.Text;
            patient.Password = editPass.Text;
            patient.DateIn = new DateTime(int.Parse(yearIn.Text), 
                monthIn.SelectedIndex + 1, (int)dayIn.Value);
            patient.DateOut = new DateTime(int.Parse(yearOut.Text), 
                monthOut.SelectedIndex + 1, (int)dayOut.Value);
            
            Doctor doctor = new Doctor();
            doctor.Name = editDoctor.Text;
            patient.Doctor = doctor;

            Disease disease = new Disease();
            disease.Name = editDisease.Text;
            patient.Disease = disease;

            Room room = new Room();
            room.Number = int.Parse(editNumber.Text);
            room = mainDoctorController.GetRoomByNumber(room);
            if (room.Size > room.Patients.Count)
            {
                patient.Room = room;
            }
            else
            {
                MessageBox.Show("В данной комнате нет свободных мест",
                                "Заселение пациентов",
                                MessageBoxButtons.OK);
                return;
            }

            mainDoctorController.SavePatientEvent(patient);
            mainDoctorController.ShowPatientEvent();
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void fillLists(MainDoctorController mainDoctorController)
        {
            IList<Doctor> doctors = this.mainDoctorController.GetAllDoctors();
            foreach (Doctor doctor in doctors)
            {
                editDoctor.Items.Add(doctor.Name);
            }

            IList<Disease> diseases = this.mainDoctorController.GetAllDiseases();
            foreach (Disease disease in diseases)
            {
                editDisease.Items.Add(disease.Name);
            }

            IList<Room> numbers = this.mainDoctorController.GetAllRooms();
            foreach (Room room in numbers)
            {
                editNumber.Items.Add(room.Number);
            } 
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void monthIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (monthIn.SelectedIndex)
            {
                case 0:
                    dayIn.Maximum = 31;
                    break;
                case 1:
                    if (yearIn.Text == "2016" || yearIn.Text == "2020" || yearIn.Text == "2024" || yearIn.Text == "2028" || yearIn.Text == "2032")
                        dayIn.Maximum = 29;
                    else
                        dayIn.Maximum = 28;
                    break;
                case 2:
                    dayIn.Maximum = 31;
                    break;
                case 3:
                    dayIn.Maximum = 30;
                    break;
                case 4:
                    dayIn.Maximum = 31;
                    break;
                case 5:
                    dayIn.Maximum = 30;
                    break;
                case 6:
                    dayIn.Maximum = 31;
                    break;
                case 7:
                    dayIn.Maximum = 31;
                    break;
                case 8:
                    dayIn.Maximum = 30;
                    break;
                case 9:
                    dayIn.Maximum = 31;
                    break;
                case 10:
                    dayIn.Maximum = 30;
                    break;
                case 11:
                    dayIn.Maximum = 31;
                    break;
            }
        }

        private void monthOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (monthIn.SelectedIndex)
            {
                case 0:
                    dayOut.Maximum = 31;
                    break;
                case 1:
                    if (yearOut.Text == "2016" || yearOut.Text == "2020" || yearOut.Text == "2024" || yearOut.Text == "2028" || yearOut.Text == "2032")
                        dayOut.Maximum = 29;
                    else
                        dayOut.Maximum = 28;
                    break;
                case 2:
                    dayOut.Maximum = 31;
                    break;
                case 3:
                    dayOut.Maximum = 30;
                    break;
                case 4:
                    dayOut.Maximum = 31;
                    break;
                case 5:
                    dayOut.Maximum = 30;
                    break;
                case 6:
                    dayOut.Maximum = 31;
                    break;
                case 7:
                    dayOut.Maximum = 31;
                    break;
                case 8:
                    dayOut.Maximum = 30;
                    break;
                case 9:
                    dayOut.Maximum = 31;
                    break;
                case 10:
                    dayOut.Maximum = 30;
                    break;
                case 11:
                    dayOut.Maximum = 31;
                    break;
            }
        }
    }
}
