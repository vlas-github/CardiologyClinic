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

        private void medicalProcMenuItem_Click(object sender, EventArgs e)
        {            
            mainDoctorController.ShowMedicalProcedureEvent();
        }

        private void diseaseMenuItem_Click(object sender, EventArgs e)
        {            
            mainDoctorController.ShowDiseaseEvent();
        }

        private void doctorMenuItem_Click(object sender, EventArgs e)
        {            
            mainDoctorController.ShowDoctorEvent();
        }

        private void nurseMenuItem_Click(object sender, EventArgs e)
        {            
            mainDoctorController.ShowNurseEvent();
        }

        private void patientMenuItem_Click(object sender, EventArgs e)
        {            
            mainDoctorController.ShowPatientEvent();
        }

        private void roomMenuItem_Click(object sender, EventArgs e)
        {            
            mainDoctorController.ShowRoomEvent();
        }

        public void ShowMedicalProcedure(IList<MedicalProcedure> medicalProcedure)
        {
            titleLabel.Text = "Список лечебных процедур:";
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Название процедуры");
            this.contentGridView.Columns.Add("description", "Описание процедуры");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].MinimumWidth = 180;
            this.contentGridView.Columns[1].Width = 180;

            this.contentGridView.Columns[2].MinimumWidth = 150;
            this.contentGridView.Columns[2].Width = 200;

            this.contentGridView.Columns[3].Width = 0;
            this.contentGridView.Columns[3].Visible = false; 

            for (int i = 0; i < medicalProcedure.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    medicalProcedure[i].Name,
                    medicalProcedure[i].Description,
                    medicalProcedure[i].Id);
            }
            this.recordCountStatusLabel.Text = "Количество записей - " + medicalProcedure.Count.ToString();
        }

        public void ShowDisease(IList<Disease> disease)
        {
            titleLabel.Text = "Список болезней:";
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Название болезни");
            this.contentGridView.Columns.Add("description", "Описание болезни");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].MinimumWidth = 180;
            this.contentGridView.Columns[1].Width = 180;

            this.contentGridView.Columns[2].MinimumWidth = 150;
            this.contentGridView.Columns[2].Width = 200;

            this.contentGridView.Columns[3].Width = 0;
            this.contentGridView.Columns[3].Visible = false; 

            for (int i = 0; i < disease.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    disease[i].Name,
                    disease[i].Description,
                    disease[i].Id);
            }
            this.recordCountStatusLabel.Text = "Количество записей - " + disease.Count.ToString();
        }

        public void ShowDoctor(IList<Doctor> doctor)
        {
            titleLabel.Text = "Список докторов:";
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("patients", "Количество пациентов");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].MinimumWidth = 180;
            this.contentGridView.Columns[1].Width = 180;

            this.contentGridView.Columns[2].MinimumWidth = 50;
            this.contentGridView.Columns[2].Width = 70;

            this.contentGridView.Columns[3].Width = 0;
            this.contentGridView.Columns[3].Visible = false; 

            for (int i = 0; i < doctor.Count; i++)
            {
                doctor[i].Patients = mainDoctorController.GetPatientByDoctor(doctor[i]);
                this.contentGridView.Rows.Add(
                    i + 1,
                    doctor[i].Name,
                    doctor[i].Patients == null ? 0 : doctor[i].Patients.Count,
                    doctor[i].Id);
            }
            this.recordCountStatusLabel.Text = "Количество записей - " + doctor.Count.ToString();
        }

        public void ShowNurse(IList<Nurse> nurse)
        {
            titleLabel.Text = "Список медсестер:";
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("rooms", "Количество комнат");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].MinimumWidth = 180;
            this.contentGridView.Columns[1].Width = 180;

            this.contentGridView.Columns[2].MinimumWidth = 50;
            this.contentGridView.Columns[2].Width = 70;

            this.contentGridView.Columns[3].Width = 0;
            this.contentGridView.Columns[3].Visible = false; 

            for (int i = 0; i < nurse.Count; i++)
            {
                nurse[i].Rooms = mainDoctorController.GetRoomsByNurse(nurse[i]);
                this.contentGridView.Rows.Add(
                    i + 1,
                    nurse[i].Name,
                    nurse[i].Rooms == null ? 0 : nurse[i].Rooms.Count,
                    nurse[i].Id);
            }
            this.recordCountStatusLabel.Text = "Количество записей - " + nurse.Count.ToString();
        }

        public void ShowPatient(IList<Patient> patient)
        {
            titleLabel.Text = "Список пациентов:";
            this.contentGridView.Columns.Clear();
            this.contentGridView.ReadOnly = true;
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("name", "Имя");
            this.contentGridView.Columns.Add("dateDoctor", "Лечащий врач");
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
            this.contentGridView.Columns[2].MinimumWidth = 180;
            this.contentGridView.Columns[2].Width = 180;

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

            for (int i = 0; i < patient.Count; i++)
            {
                this.contentGridView.Rows.Add(
                    i + 1,
                    patient[i].Name,
                    patient[i].Doctor.Name,
                    patient[i].Room.Number,
                    patient[i].Disease.Name,
                    patient[i].DateIn.ToShortDateString(),
                    patient[i].DateOut.ToShortDateString(),
                    patient[i].Id);                
            }
            this.recordCountStatusLabel.Text = "Количество записей - " + patient.Count.ToString();
        }

        public void ShowRoom(IList<Room> room)
        {
            titleLabel.Text = "Список больничных палат:";
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("number", "Номер палаты");
            this.contentGridView.Columns.Add("nurse", "Медсестра");
            this.contentGridView.Columns.Add("size", "Количество мест");
            this.contentGridView.Columns.Add("free_size", "Количество свободных мест");
            this.contentGridView.Columns.Add("id", "id");

            this.contentGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[0].MinimumWidth = 30;
            this.contentGridView.Columns[0].Width = 30;

            this.contentGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[1].MinimumWidth = 60;
            this.contentGridView.Columns[1].Width = 70;

            this.contentGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.contentGridView.Columns[2].MinimumWidth = 180;
            this.contentGridView.Columns[2].Width = 180;

            this.contentGridView.Columns[3].MinimumWidth = 60;
            this.contentGridView.Columns[3].Width = 100;

            this.contentGridView.Columns[4].MinimumWidth = 60;
            this.contentGridView.Columns[4].Width = 100;

            this.contentGridView.Columns[5].Width = 0;
            this.contentGridView.Columns[5].Visible = false; 

            for (int i = 0; i < room.Count; i++)
            {
                room[i].Nurse = mainDoctorController.GetNurseByRoom(room[i]);
                room[i].Patients = mainDoctorController.GetPatientsByRoom(room[i]);
                this.contentGridView.Rows.Add(
                    i + 1,
                    room[i].Number,
                    room[i].Nurse.Name,
                    room[i].Size,
                    room[i].Size - room[i].Patients.Count,
                    room[i].Id);
            }
            this.recordCountStatusLabel.Text = "Количество записей - " + room.Count.ToString();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void contentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contentGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void MainDoctorForm_Load(object sender, EventArgs e)
        {
            mainDoctorController.ShowPatientEvent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form form;

            switch (titleLabel.Text)
            {
                case "Список лечебных процедур:":
                    MedicalProcedure medicalProcedure = mainDoctorController.GetMedicalProcedureById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    form = new EditMedicalProcedureForm(this.mainDoctorController,medicalProcedure);
                    form.ShowDialog();
                    break;
                case "Список болезней:":
                    Disease disease = mainDoctorController.GetDiseaseById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    form = new EditDiseaseForm(this.mainDoctorController,disease);
                    form.ShowDialog();
                    break;
                case "Список докторов:":
                    Doctor doctor = mainDoctorController.GetDoctorById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    form = new EditDoctorForm(this.mainDoctorController, doctor);
                    form.ShowDialog();
                    break;
                case "Список медсестер:":
                    Nurse nurse = mainDoctorController.GetNurseById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    form = new EditNurseForm(this.mainDoctorController, nurse);
                    form.ShowDialog();
                    break;
                case "Список пациентов:":         
                    Patient patient = mainDoctorController.GetPatientById(contentGridView.CurrentRow.Cells[7].Value.ToString());
                    form = new EditPatientForm(this.mainDoctorController,patient);
                    form.ShowDialog();
                    break;
                case "Список больничных палат:":
                    Room room = mainDoctorController.GetRoomById(contentGridView.CurrentRow.Cells[5].Value.ToString());
                    form = new EditRoomForm(this.mainDoctorController, room);
                    form.ShowDialog();
                    break;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (titleLabel.Text)
            {
                case "Список лечебных процедур:":
                    MedicalProcedure medicalProcedure = mainDoctorController.GetMedicalProcedureById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    mainDoctorController.DeleteMedicalProcedure(medicalProcedure.Id.ToString());
                    mainDoctorController.ShowMedicalProcedureEvent();
                    break;
                case "Список болезней:":
                    Disease disease = mainDoctorController.GetDiseaseById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    mainDoctorController.DeleteDisease(disease.Id.ToString());
                    mainDoctorController.ShowDiseaseEvent();
                    break;
                case "Список докторов:":
                    Doctor doctor = mainDoctorController.GetDoctorById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    mainDoctorController.DeleteDoctor(doctor.Id.ToString());
                    mainDoctorController.ShowDoctorEvent();
                    break;
                case "Список медсестер:":
                    Nurse nurse = mainDoctorController.GetNurseById(contentGridView.CurrentRow.Cells[3].Value.ToString());
                    mainDoctorController.DeleteNurse(nurse.Id.ToString());
                    mainDoctorController.ShowNurseEvent();
                    break;
                case "Список пациентов:":
                    Patient patient = mainDoctorController.GetPatientById(contentGridView.CurrentRow.Cells[7].Value.ToString());
                    mainDoctorController.DeletePatient(patient.Id.ToString());
                    mainDoctorController.ShowPatientEvent();
                    break;
                case "Список больничных палат:":
                    Room room = mainDoctorController.GetRoomById(contentGridView.CurrentRow.Cells[5].Value.ToString());
                    mainDoctorController.DeleteRoom(room.Id.ToString());
                    mainDoctorController.ShowRoomEvent();
                    break;
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
