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
            patient.Room = room;

            mainDoctorController.SavePatientEvent(patient);
            mainDoctorController.ShowPatientEvent();
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
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
    }
}
