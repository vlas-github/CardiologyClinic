using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.MainDoctor.EditRoom
{
    public partial class EditRoomForm : Form
    {
        private MainDoctorController mainDoctorController;

        public EditRoomForm()
        {
            InitializeComponent();
        }

        public EditRoomForm(MainDoctorController mainDoctorController)
            : this()
        {
            this.mainDoctorController = mainDoctorController;
        }

        private void contentContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
