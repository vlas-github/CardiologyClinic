using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.MainDoctor.EditNurse
{
    public partial class EditNurseForm : Form
    {
        private MainDoctorController mainDoctorController;

        public EditNurseForm()
        {
            InitializeComponent();
        }

        public EditNurseForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.mainDoctorController = mainDoctorController;
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
