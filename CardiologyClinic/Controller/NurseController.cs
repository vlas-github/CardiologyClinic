using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.View.NurseView;
using CardiologyClinic.Service;
using CardiologyClinic.Help;

namespace CardiologyClinic.Controller
{
    public class NurseController
    {
        private User user;
        private NurseForm nurseForm;
        private NurseService nurseService =
            (NurseService)BeanFactory.GetFactory().GetBean("nurseService");

        public NurseController(User user)
        {
            this.user = user;
        }


        public void Start()
        {
            nurseForm = new NurseForm(this);
            nurseForm.ShowNurseName(user.Name);
            nurseForm.Show();
        }
    }
}
