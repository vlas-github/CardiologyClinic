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
using CardiologyClinic.View.MainDoctor.EditDisease;
using CardiologyClinic.View.MainDoctor.EditMedicalProcedure;
using CardiologyClinic.View.MainDoctor.EditDoctor;
using CardiologyClinic.View.MainDoctor.EditNurse;
using CardiologyClinic.View.MainDoctor.EditPatient;
using CardiologyClinic.View.MainDoctor.EditRoom;

namespace CardiologyClinic.View.MainDoctorView
{
    public partial class MainDoctorForm : Form
    {
        private MainDoctorController mainDoctorController;

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
            Form form;
            switch (titleLabel.Text)
            {
                case "Список лечебных процедур:":
                    form = new EditMedicalProcedureForm(this.mainDoctorController);
                    form.ShowDialog();
                    break;
                case "Список болезней:":
                    form = new EditDiseaseForm(this.mainDoctorController);
                    form.ShowDialog();
                    break;
                case "Список докторов:":
                    form = new EditDoctorForm(this.mainDoctorController);
                    form.ShowDialog();
                    break;
                case "Список медсестер:":
                    form = new EditNurseForm(this.mainDoctorController);
                    form.ShowDialog();
                    break;
                case "Список пациентов:":
                    form = new EditPatientForm(this.mainDoctorController);
                    form.ShowDialog();
                    break;
                case "Список больничных палат:":
                    form = new EditRoomForm(this.mainDoctorController);
                    form.ShowDialog();
                    break;
            }
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

        public void ShowDisease(List<Disease> disease)
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

        public void ShowDoctor(List<Doctor> doctor)
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

        public void ShowNurse(List<Nurse> nurse)
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

        public void ShowPatient(List<Patient> patient)
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

        public void ShowRoom(List<Room> room)
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

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void contentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
