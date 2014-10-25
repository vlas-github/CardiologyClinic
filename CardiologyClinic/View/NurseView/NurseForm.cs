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
            
        }

        void room_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void patient_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void ShowPurposes(List<Purpose> result)
        {
            //throw new NotImplementedException();
        }
    }
}
