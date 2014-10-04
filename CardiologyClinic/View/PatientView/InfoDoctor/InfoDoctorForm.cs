using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Bean;

namespace CardiologyClinic.View.PatientView.InfoDoctor
{
    public partial class InfoDoctorForm : Form
    {
        private Doctor doctor;

        public InfoDoctorForm()
        {
            InitializeComponent();
        }

        public InfoDoctorForm(Doctor doctor) :
            this()
        {
            this.doctor = doctor;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoDoctorForm_Load(object sender, EventArgs e)
        {
            nameDoctorLabel.Text = this.doctor.Name;
        }
    }
}
