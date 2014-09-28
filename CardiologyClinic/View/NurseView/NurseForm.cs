using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Controller;

namespace CardiologyClinic.View.NurseView
{
    public partial class NurseForm : Form
    {
        private NurseController nurseController;

        public NurseForm()
        {
            InitializeComponent();
        }

        public NurseForm(NurseController nurseController)
            : this()
        {
            this.nurseController = nurseController;
        }

        public void ShowNurseName(string name)
        {
            this.Text = name;
        }
    }
}
