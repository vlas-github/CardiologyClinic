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

        public MainDoctorForm(MainDoctorController mainDoctorController)
        {
            // TODO: Complete member initialization
            this.mainDoctorController = mainDoctorController;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
