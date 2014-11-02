using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Bean;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.DoctorView.EditPatient.EditProcedure
{
    public partial class AddProcedureForm : Form
    {
        private Patient patient;
        private DoctorController controller;

        public AddProcedureForm()
        {
            InitializeComponent();
        }

        public AddProcedureForm(DoctorController controller, Patient patient)
            : this()
        {
            this.controller = controller;
            this.patient = patient;
        }

        private void AddProcedureForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
