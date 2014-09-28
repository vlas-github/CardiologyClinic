using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.PatientView
{
    public partial class PatientForm : Form
    {
        private Controller.PatientController patientController;

        public PatientForm()
        {
            InitializeComponent();
        }

        public PatientForm(PatientController patientController)
            : this()
        {
            this.patientController = patientController;
        }

        public void ShowPatientName(string name)
        {
            this.Text = name;
        }
    }
}
