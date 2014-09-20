using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.View.LoginView;
using CardiologyClinic.Service;
using CardiologyClinic.Help;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Controller
{
    public class LoginController
    {
        private LoginForm loginForm;
        private LoginService loginService =
            (LoginService)BeanFactory.GetFactory().GetBean("loginService");

        public LoginController()
        {
            loginForm = new LoginForm();
            loginForm.LoginController = this;
            
        }

        public void Start()
        {
            Application.Run(this.loginForm);
        }

        public void TryLogin()
        {
            User user;
            String pass = loginForm.GetPassText().Trim();

            user = loginService.GetPatientByPass(pass);
            if (user != null)
            {
                startPatientController(user);
                return;
            }

            user = loginService.GetDoctorByPass(pass);
            if (user != null)
            {
                startDoctorController(user);
                return;
            }

            user = loginService.GetNurseByPass(pass);
            if (user != null)
            {
                startNurseController(user);
                return;
            }

            user = loginService.GetMainDoctorByPass(pass);
            if (user != null)
            {
                startMainDoctorController(user);
                return;
            }

            loginForm.ShowErrorMessage();
        }

        private void startMainDoctorController(User user)
        {
            new MainDoctorController(user).Start();
            loginForm.Hide();
        }

        private void startNurseController(User user)
        {
            throw new NotImplementedException();
        }

        private void startDoctorController(User user)
        {
            throw new NotImplementedException();
        }

        private void startPatientController(User user)
        {
            throw new NotImplementedException();
        }
    }
}
