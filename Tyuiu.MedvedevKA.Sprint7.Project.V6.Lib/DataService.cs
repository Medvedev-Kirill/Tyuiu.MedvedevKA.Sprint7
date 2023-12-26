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
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            string[] num = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            int columns = num[0].Split(';').Length;
            int rows = num.Length;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < num.Length; i++)
            {
                string numIndex = num[i];
                string[] numArray = numIndex.Split(';');
                for (int j = 0; j < numArray.Length; j++) matrix[i, j] = numArray[j];
            }
            return matrix;
        }

        public string[,] AscendingSort(string[,] matrix, int NumberColumn)
        {
            int[] vozr = new int[matrix.GetLength(0) - 1];
            vozr[vozr.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < vozr.Length - 1; i++)
            {
                vozr[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(vozr, (x, y) => x.CompareTo(y));

            string[,] sortedmx = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < sortedmx.GetLength(1); i++)
            {
                sortedmx[0, i] = matrix[0, i];
            }

            for (int i = 0; i < sortedmx.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (vozr[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < sortedmx.GetLength(1); c++)
                        {
                            sortedmx[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return sortedmx;
        }
        public string[,] DescendingSort(string[,] matrix, int NumberColumn)
        {
            int[] arr = new int[matrix.GetLength(0) - 1];
            arr[arr.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(arr, (x, y) => y.CompareTo(x));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (arr[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }
    }
}
