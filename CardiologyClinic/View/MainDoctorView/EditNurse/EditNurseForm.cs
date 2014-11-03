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

namespace CardiologyClinic.View.MainDoctor.EditNurse
{
    public partial class EditNurseForm : Form
    {
        private MainDoctorController mainDoctorController;
        private Nurse nurse;

        public EditNurseForm()
        {
            InitializeComponent();
        }

        public EditNurseForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.Text = "Добавление медсестры";
            this.nurse = new Nurse();
            this.mainDoctorController = mainDoctorController;
        }

        public EditNurseForm(MainDoctorController mainDoctorController, Nurse editNurse)
            : this()
        {
            this.Text = "Изменение медсестры";
            this.mainDoctorController = mainDoctorController;
            this.editName.Text = editNurse.Name.ToString();
            this.editPass.Text = editNurse.Password.ToString();
            this.nurse = editNurse;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.nurse.Name = this.editName.Text;
            this.nurse.Password = this.editPass.Text;
            this.mainDoctorController.SaveNurseEvent(nurse);
            this.mainDoctorController.ShowNurseEvent();
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
