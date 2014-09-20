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

namespace CardiologyClinic.View.MainDoctor.EditMedicalProcedure
{
    public partial class EditMedicalProcedureForm : Form
    {
        private MainDoctorController mainDoctorController;
        private MedicalProcedure medicalProcedure;

        public EditMedicalProcedureForm()
        {
            InitializeComponent();
        }

        public EditMedicalProcedureForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.Text = "Добавление медецинской процедуры";
            this.medicalProcedure = new MedicalProcedure();
            this.mainDoctorController = mainDoctorController;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.medicalProcedure.Name = this.editName.Text;
            this.medicalProcedure.Description = this.editDescription.Text;
            mainDoctorController.SaveMedicalProcedureEvent(medicalProcedure);
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
