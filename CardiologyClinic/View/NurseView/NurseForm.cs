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

namespace CardiologyClinic.View.NurseView
{
    public partial class NurseForm : Form
    {
        private NurseController nurseController;

        public NurseForm()
        {
            InitializeComponent();
        }

        public NurseForm(NurseController nurseController)
            : this()
        {
            this.nurseController = nurseController;
        }

        public void ShowNurseName(string name)
        {
            this.Text = name;
        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            this.nurseController.ShowAllPurposesEvent();
            this.nurseController.PutMenuAllRooms();
            this.nurseController.PutMenuAllPatients();
        }

        private void purposeMenuItem_Click(object sender, EventArgs e)
        {
            this.nurseController.ShowAllPurposesEvent();
        }

        private void allRoomsMenuItem_Click(object sender, EventArgs e)
        {
            this.nurseController.ShowAllRoomsEvent();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void roomNumberMenuItem_Click(object sender, EventArgs e)
        {
            Room room = null;
            this.nurseController.ShowPurposesByRoom(room);
        }

        private void patientMenuItem_Click(object sender, EventArgs e)
        {
            Patient patient = null;
            this.nurseController.ShowPurposesByPatient(patient);
        }

        public void ShowMenuRooms(ICollection<Room> iCollection)
        {
            foreach (Room room in iCollection)
            {
                ToolStripItem tmp = new ToolStripMenuItem();
                tmp.Text = room.Number.ToString();
                tmp.Click += new EventHandler(room_Click);
                roomMenuItem.DropDownItems.Add(tmp);
            }
        }

        public void ShowMenuPatients(ICollection<Patient> result)
        {
            foreach (Patient patient in result)
            {
                ToolStripItem tmp = new ToolStripMenuItem();
                tmp.Text = patient.Name.ToString();
                tmp.Click += new EventHandler(patient_Click);
                patientsMenuItem.DropDownItems.Add(tmp);
            }
        }

        public void ShowRooms(ICollection<Room> iCollection)
        {
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

            int i = 0;

            foreach (Room room in iCollection)
            {
                this.contentGridView.Rows.Add(
                    ++i,
                    room.Number,
                    room.Nurse.Name,
                    room.Size,
                    room.Size - room.Patients.Count,
                    room.Id);
            }
        }

        public void ShowPurposes(List<Purpose> result)
        {
            this.contentGridView.Columns.Clear();
            this.contentGridView.Columns.Add("index", "#");
            this.contentGridView.Columns.Add("patient", "Пациент");
            this.contentGridView.Columns.Add("room", "Палата");
            this.contentGridView.Columns.Add("name", "Лечебная процедура");
            this.contentGridView.Columns.Add("time", "Время");
            this.contentGridView.Columns.Add("id", "id");

            int i = 0;

            foreach (Purpose purpose in result)
            {
                this.contentGridView.Rows.Add(
                    ++i,
                    purpose.Patient.Name,
                    purpose.Patient.Room.Number,
                    purpose.MedicalProcedure.Name,
                    purpose.DateOfProcedure,
                    purpose.Id);
            }
        }

        void room_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Number = int.Parse(((ToolStripItem)sender).Text);
            this.nurseController.GetRoomByNumber(room);
            this.nurseController.ShowPurposesByRoom(room);
        }

        void patient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Name = ((ToolStripItem)sender).Text;
            this.nurseController.GetPatientByName(patient);
            this.nurseController.ShowPurposesByPatient(patient);
        }

        private void roomMenuItem_DoubleClick(object sender, EventArgs e)
        {
            this.nurseController.ShowAllRoomsEvent();
        }

        private void patientsMenuItem_DoubleClick(object sender, EventArgs e)
        {
            this.nurseController.ShowAllPurposesEvent();
        }
    }
}
