using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

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
    }
}
