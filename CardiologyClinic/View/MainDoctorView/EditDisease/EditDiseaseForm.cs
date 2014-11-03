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

namespace CardiologyClinic.View.MainDoctor.EditDisease
{
    public partial class EditDiseaseForm : Form
    {

        private MainDoctorController mainDoctorController;
        private Disease disease;

        public EditDiseaseForm()
        {
            InitializeComponent();
        }

        public EditDiseaseForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.Text = "Добавление болезни";
            this.disease = new Disease();
            this.mainDoctorController = mainDoctorController;
        }

        public EditDiseaseForm(MainDoctorController mainDoctorController, Disease editDisease)
            : this()
        {
            this.Text = "Изменение болезни";
            this.mainDoctorController = mainDoctorController;
            this.editName.Text = editDisease.Name.ToString();
            this.editDescription.Text = editDisease.Description.ToString();
            this.disease = editDisease;
        }

        private void save_Click(object sender, EventArgs e)
        {
            disease.Name = this.editName.Text;
            disease.Description = this.editDescription.Text;
            this.mainDoctorController.SaveDiseaseEvent(disease);
            this.mainDoctorController.ShowDiseaseEvent();
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
