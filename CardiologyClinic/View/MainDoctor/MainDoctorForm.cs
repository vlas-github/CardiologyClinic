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

namespace CardiologyClinic.View.MainDoctor
{
    public partial class MainDoctorForm : Form
    {
        private Controller.MainDoctorController mainDoctorController;

        public MainDoctorForm()
        {
            InitializeComponent();
        }

        public MainDoctorForm(MainDoctorController mainDoctorController) : this()
        {
            this.mainDoctorController = mainDoctorController;
        }

        public void ShowMainDoctorName(String name)
        {
            this.Text = "Глав-врач: " + name;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicalProcMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Список лечебных процедур:";
            mainDoctorController.ShowMedicalProcedureEvent();
        }

        private void diseaseMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Список болезней:";
            mainDoctorController.ShowDiseaseEvent();
        }

        private void doctorMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Список докторов:";
            mainDoctorController.ShowDoctorEvent();
        }

        private void nurseMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Список медсестер:";
            mainDoctorController.ShowNurseEvent();
        }

        private void patientMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Список пациентов:";
            mainDoctorController.ShowPatientEvent();
        }

        private void roomMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "Список больничных палат:";
            mainDoctorController.ShowRoomEvent();
        }

        public void ShowMedicalProcedure(List<MedicalProcedure> medicalProcedure)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Название процедуры");
            this.contentGridView.Columns.Add("description", "Описание процедуры");

            for (int i = 0; i < medicalProcedure.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    medicalProcedure[i].Name,
                    medicalProcedure[i].Description);
            }
        }

        internal void ShowDisease(List<Disease> disease)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Название болезни");
            this.contentGridView.Columns.Add("description", "Описание болезни");

            for (int i = 0; i < disease.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    disease[i].Name,
                    disease[i].Description);
            }
        }

        internal void ShowDoctor(List<Doctor> doctor)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("patients", "Количество пациентов");

            for (int i = 0; i < doctor.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    doctor[i].Name,
                    doctor[i].Patients.Count);
            }
        }

        internal void ShowNurse(List<Nurse> nurse)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("rooms", "Количество комнат");

            for (int i = 0; i < nurse.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    nurse[i].Name,
                    nurse[i].Rooms.Count);
            }
        }

        internal void ShowPatient(List<Patient> patient)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("dateIn", "Дата поступления");
            this.contentGridView.Columns.Add("dateOut", "Дата выписки");
            this.contentGridView.Columns.Add("dateDisease", "Диагноз");
            this.contentGridView.Columns.Add("dateDoctor", "Лечащий врач");
            this.contentGridView.Columns.Add("dateRoom", "Комната");

            for (int i = 0; i < patient.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    patient[i].Name,
                    patient[i].DateIn,
                    patient[i].DateOut,
                    patient[i].Disease.Name,
                    patient[i].Doctor.Name,
                    patient[i].Room.Number);
            }
        }

        internal void ShowRoom(List<Room> room)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("number", "Номер");
            this.contentGridView.Columns.Add("nurse", "Медсестра");
            this.contentGridView.Columns.Add("size", "Количество мест");
            this.contentGridView.Columns.Add("free_size", "Количество свободных мест");

            for (int i = 0; i < room.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    room[i].Number,
                    room[i].Nurse.Name,
                    room[i].Size,
                    room[i].Size - room[i].Patients.Count);
            }
        }
    }
}
