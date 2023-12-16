using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MedvedevKA.Sprint7.Project.V6.Lib;

namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
            openFileDialog_MKA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_MKA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        
        private void buttonOpenFile_MKA_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint7\Tyuiu.MedvedevKA.Sprint7.Project.V6\bin\Debug\Patients.csv";

            // Создание таблицы данных
            DataTable dt = new DataTable();

            // Создание столбцов
            dt.Columns.Add("Номер", typeof(int));
            dt.Columns.Add("Фамилия", typeof(string));
            dt.Columns.Add("Имя", typeof(string));
            dt.Columns.Add("Отчество", typeof(string));
            dt.Columns.Add("Дата рождения пациента", typeof(DateTime));

            // Добавление строк
            dt.Rows.Add(1, "Крючкова", "София", "Матвеевна", new DateTime(2000, 2, 6));
            dt.Rows.Add(2, "Ефремов", "Сергей", "Иванович", new DateTime(1997, 8, 10));
            dt.Rows.Add(3, "Булатов", "Андрей", "Константинович", new DateTime(2001, 11, 16));
            dt.Rows.Add(4, "Иванов", "Лев", "Никитич", new DateTime(2002, 2, 26));
            dt.Rows.Add(5, "Смирнова", "Полина", "Ярославна", new DateTime(1996, 9, 15));
            dt.Rows.Add(6, "Белов", "Иван", "Иванович", new DateTime(2000, 1, 26));
            dt.Rows.Add(7, "Попов", "Степан", "Денисович", new DateTime(1998, 4, 1));
            dt.Rows.Add(8, "Грачев", "Александр", "Янович", new DateTime(1996, 1, 10));
            dt.Rows.Add(9, "Киселева", "Евгения", "Романовна", new DateTime(1999, 8, 17));
            dt.Rows.Add(10, "Кошелев", "Святослав", "Фёдорович", new DateTime(1998, 5, 7));

            // Установка таблицы данных в DataGridView
            dataGridViewOriginal_MKA.DataSource = dt;
        }

    }
}
