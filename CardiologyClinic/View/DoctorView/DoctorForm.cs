using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.DoctorView
{
    public partial class DoctorForm : Form
    {
        private DoctorController doctorController;

        public DoctorForm()
        {
            InitializeComponent();
        }

        public DoctorForm(DoctorController doctorController)
            : this()
        {
            this.doctorController = doctorController;
        }

        public void ShowDoctorName(string name)
        {
            this.Text = name;
        }
    }
}
