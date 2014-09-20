using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Bean;
using CardiologyClinic.Dao;
using CardiologyClinic.Help;

namespace CardiologyClinic.Service
{
    class MainDoctorServiceImpl : MainDoctorService
    {
        private DiseaseDao diseaseDao =
            (DiseaseDao)BeanFactory.GetFactory().GetBean("diseaseDao");
        private DoctorDao doctorDao =
            (DoctorDao)BeanFactory.GetFactory().GetBean("doctorDao");
        private MedicalProcedureDao medicalProcedureDao =
            (MedicalProcedureDao)BeanFactory.GetFactory().GetBean("medicalProcedureDao");

        public List<MedicalProcedure> GetAllMedicalProcedures()
        {
            List<MedicalProcedure> result = new List<MedicalProcedure>();
            MedicalProcedure a = new MedicalProcedure();
            a.Id = "782de209-4924-45d7-9d31-c93dde20546b";
            a.Name = "Уколы в жопу";
            a.Description = "Очень больно!!! ";

            MedicalProcedure b = new MedicalProcedure();
            b.Id = "82c2e08b-9b21-43d4-8e94-df21a46df52a";
            b.Name = "Уколы в жопу 2";
            b.Description = "Еще больнее!!! ";

            MedicalProcedure c = new MedicalProcedure();
            c.Id = "becaca48-b7a3-4d76-9fde-e6c5ad12e2a8";
            c.Name = "Уколы в жопу 3";
            c.Description = "Ваще беда!!! ";

            result.Add(a);
            result.Add(b);
            result.Add(c);

            return result;
        }

        public List<Disease> GetAllDiseases()
        {
            List<Disease> result = new List<Disease>();
            Disease a = new Disease();
            a.Id = "68d70e27-4db4-415a-99f4-b4ce57c26a95";
            a.Name = "Волчанка";
            a.Description = "Очень больно!!! ";

            Disease b = new Disease();
            b.Id = "e0e64dd7-a3e8-4295-a974-753888a4a203";
            b.Name = "Волчанка 2";
            b.Description = "Еще больнее!!! ";

            Disease c = new Disease();
            c.Id = "6d730638-1b6f-4018-847e-73312e5fd9ed";
            c.Name = "Волчанка 3";
            c.Description = "Ваще беда!!! ";

            result.Add(a);
            result.Add(b);
            result.Add(c);

            return result;
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> result = new List<Doctor>();
            Doctor a = new Doctor();
            a.Id = "266789f3-f36e-4a96-b577-7016249b1196";
            a.Name = "Василий Васильевич Пупкин";
            a.Patients = new List<Patient>();
            a.Patients.Add(new Patient());
            a.Patients.Add(new Patient());
            a.Patients.Add(new Patient());

            Doctor b = new Doctor();
            b.Id = "e7b01943-54ad-4a36-97f6-aa29128131bb";
            b.Name = "Петр Высильевич Пупкин";
            b.Patients = new List<Patient>();
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());

            Doctor c = new Doctor();
            c.Id = "faa73c03-3312-47d9-b724-905273b13cdf";
            c.Name = "Федр Васильевич Пупкин";
            c.Patients = new List<Patient>();
            c.Patients.Add(new Patient());
            c.Patients.Add(new Patient());

            result.Add(a);
            result.Add(b);
            result.Add(c);

            return result;
        }

        public List<Nurse> GetAllNurses()
        {
            List<Nurse> result = new List<Nurse>();
            Nurse a = new Nurse();
            a.Id = "266789f3-f36e-4a96-b577-7016249b1196";
            a.Name = "Василий Васильевич Пупкин";
            a.Rooms = new List<Room>();
            a.Rooms.Add(new Room());
            a.Rooms.Add(new Room());
            a.Rooms.Add(new Room());

            Nurse b = new Nurse();
            b.Id = "e7b01943-54ad-4a36-97f6-aa29128131bb";
            b.Name = "Петр Высильевич Пупкин";
            b.Rooms = new List<Room>();
            b.Rooms.Add(new Room());
            b.Rooms.Add(new Room());
            b.Rooms.Add(new Room());
            b.Rooms.Add(new Room());
            b.Rooms.Add(new Room());
            b.Rooms.Add(new Room());

            Nurse c = new Nurse();
            c.Id = "faa73c03-3312-47d9-b724-905273b13cdf";
            c.Name = "Федр Васильевич Пупкин";
            c.Rooms = new List<Room>();
            c.Rooms.Add(new Room());
            c.Rooms.Add(new Room());

            result.Add(a);
            result.Add(b);
            result.Add(c);

            return result;
        }

        public List<Patient> GetAllPatients()
        {
            Nurse d = new Nurse();
            d.Id = "266789f3-f36e-4a96-b577-7016249b1196";
            d.Name = "Василий Васильевич Пупкин";
            d.Rooms = new List<Room>();
            
            Room a = new Room();
            a.Id = "68d70e27-4db4-415a-99f4-b4ce57c26a95";
            a.Number = 10;
            a.Nurse = d;
            a.Patients = new List<Patient>();
            a.Size = 5;

            Doctor b = new Doctor();
            b.Id = "e7b01943-54ad-4a36-97f6-aa29128131bb";
            b.Name = "Петр Высильевич Пупкин";
            b.Patients = new List<Patient>();
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());
            b.Patients.Add(new Patient());

            Disease c = new Disease();
            c.Id = "68d70e27-4db4-415a-99f4-b4ce57c26a95";
            c.Name = "Волчанка";
            c.Description = "Очень больно!!! ";

            List<Patient> result = new List<Patient>();
            Patient e = new Patient();
            e.Id = "68d70e27-4db4-415a-99f4-b4ce57c26a95";
            e.DateIn = new DateTime();
            e.DateOut = new DateTime();
            e.Disease = c;
            e.Doctor = b;
            e.Name = "Bob";
            e.Purposes = new List<Purpose>();
            e.Room = a;

            result.Add(e);

            return result;
        }

        public List<Room> GetAllRooms()
        {
            Nurse d = new Nurse();
            d.Id = "266789f3-f36e-4a96-b577-7016249b1196";
            d.Name = "Василий Васильевич Пупкин";
            d.Rooms = new List<Room>();

            List<Room> result = new List<Room>();
            Room a = new Room();
            a.Id = "68d70e27-4db4-415a-99f4-b4ce57c26a95";
            a.Number = 10;
            a.Nurse = d;
            a.Patients = new List<Patient>();
            a.Size = 5;

            result.Add(a);

            return result;
        }

        public void SaveDisease(Disease disease)
        {
            diseaseDao.Save(disease);
        }

        public void SaveDoctor(Doctor doctor)
        {
            doctorDao.Save(doctor);
        }

        private void SaveMedicalProcedure(MedicalProcedure medicalProcedure)
        {
            medicalProcedureDao.Save(medicalProcedure);
        }
    }
}
