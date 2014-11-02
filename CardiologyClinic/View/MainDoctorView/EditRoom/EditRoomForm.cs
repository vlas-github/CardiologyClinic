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

namespace CardiologyClinic.View.MainDoctor.EditRoom
{
    public partial class EditRoomForm : Form
    {
        private MainDoctorController mainDoctorController;
        private Room room;

        public EditRoomForm()
        {
            InitializeComponent();
        }

        public EditRoomForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.Text = "Добавление комнаты";            
            this.room = new Room();
            this.mainDoctorController = mainDoctorController;
            fillList(this.mainDoctorController);
        }

        public EditRoomForm(MainDoctorController mainDoctorController, Room editRoom)
            : this()
        {
            this.Text = "Изменение комнаты";
            this.mainDoctorController = mainDoctorController;
            fillList(this.mainDoctorController);
            this.editNumber.Text = editRoom.Number.ToString();
            this.editSize.Text = editRoom.Size.ToString();
            this.editNurse.SelectedIndex = this.editNurse.FindString(editRoom.Nurse.Name.ToString());
            this.room = editRoom;

        }

        private void save_Click(object sender, EventArgs e)
        {
            this.room.Number = int.Parse(this.editNumber.Text);
            this.room.Size = int.Parse(this.editSize.Text);

            Nurse nurse = new Nurse();
            nurse.Name = this.editNurse.Text;

            this.room.Nurse = nurse;

            this.mainDoctorController.SaveRoomEvent(room);
            this.mainDoctorController.ShowRoomEvent();

            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void fillList(MainDoctorController mainDoctorController)
        {
            IList<Nurse> nurses = this.mainDoctorController.GetAllNurses();
            foreach (Nurse nurse in nurses)
            {
                editNurse.Items.Add(nurse.Name);
            }
        }

        private void EditRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
