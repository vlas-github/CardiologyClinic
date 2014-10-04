using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Bean;

namespace CardiologyClinic.View.PatientView.InfoNurse
{
    public partial class InfoNurseForm : Form
    {
        private Nurse nurse;
        
        public InfoNurseForm()
        {
            InitializeComponent();
        }

        public InfoNurseForm(Nurse nurse) :
            this()
        {
            this.nurse = nurse;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoNurseForm_Load(object sender, EventArgs e)
        {
            this.nameNurseLabel.Text = this.nurse.Name;
        }
    }
}
