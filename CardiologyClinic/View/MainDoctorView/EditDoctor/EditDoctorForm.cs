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

namespace CardiologyClinic.View.MainDoctor.EditDoctor
{
    public partial class EditDoctorForm : Form
    {
        private MainDoctorController mainDoctorController;
        private Doctor doctor;

        public EditDoctorForm()
        {
            InitializeComponent();
        }

        public EditDoctorForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.Text = "Добавление доктора";
            this.doctor = new Doctor();
            this.mainDoctorController = mainDoctorController;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.doctor.Name = this.editName.Text;
            this.doctor.Password = this.editPass.Text;
            this.mainDoctorController.SaveDoctorEvent(doctor);
            this.mainDoctorController.ShowDoctorEvent();
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
