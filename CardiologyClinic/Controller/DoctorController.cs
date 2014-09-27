using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.View.DoctorView;
using CardiologyClinic.Service;
using CardiologyClinic.Help;

namespace CardiologyClinic.Controller
{
    public class DoctorController
    {
        private User user;
        private DoctorForm doctorForm;
        private DoctorService doctorService =
            (DoctorService)BeanFactory.GetFactory().GetBean("doctorService");

        public DoctorController(User user)
        {
            this.user = user;
        }

        public void Start()
        {
            doctorForm = new DoctorForm(this);
            doctorForm.ShowDoctorName(user.Name);
            doctorForm.Show();
        }
    }
}
