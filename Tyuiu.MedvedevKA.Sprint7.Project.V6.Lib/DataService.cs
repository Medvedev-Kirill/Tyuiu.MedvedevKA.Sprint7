using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.MedvedevKA.Sprint7.Project.V6.Lib
{
    public class Patients
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    public class PatientRepository
    {
        private const string PatientsFilePath = "Patients.csv";

        public List<Patients> GetAllPatients()
        {
            List<Patients> patients = new List<Patients>();

            using (StreamReader reader = new StreamReader(PatientsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    if (values.Length == 5)
                    {
                        Patients patient = new Patients();
                        patient.Id = int.Parse(values[0]);
                        patient.LastName = values[1];
                        patient.FirstName = values[2];
                        patient.MiddleName = values[3];
                        patient.DateOfBirth = DateTime.Parse(values[4]);

                        patients.Add(patient);
                    }
                }
            }

            return patients;
        }
    }
    public class Doctors
    {
        public string LFMName { get; set; }
        public string Specialization { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string LossOfEmployment { get; set; }
        public string Accounting { get; set; }
        public string Note { get; set; }
    }

    public class DoctorsRepository
    {
        private const string DoctorsFilePath = "Doctors.csv";
        public List<Doctors> GetAllDoctors()
        {
            List<Doctors> doctors = new List<Doctors>();
            using (StreamReader reader = new StreamReader(DoctorsFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(';');

                    if (values.Length == 7)
                    {
                        Doctors doctor = new Doctors();
                        doctor.LFMName = values[0];
                        doctor.Specialization = values[1];
                        doctor.Diagnosis = values[2];
                        doctor.Treatment = values[3];
                        doctor.LossOfEmployment = values[4];
                        doctor.Accounting = values[5];
                        doctor.Note = values[6];

                        doctors.Add(doctor);
                    }
                }
            }
            return doctors;
        }
    }

}
