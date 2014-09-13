using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.View.MainDoctor;

namespace CardiologyClinic.Controller
{
    public class MainDoctorController
    {
        private Bean.User user;
        private MainDoctorForm mainDoctorForm;

        public MainDoctorController(Bean.User user)
        {
            this.user = user;
        }
        public void Start()
        {
            mainDoctorForm = new MainDoctorForm(this);
            mainDoctorForm.Show();
        }
    }
}
