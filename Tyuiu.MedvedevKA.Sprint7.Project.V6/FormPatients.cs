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
            string[] lines = File.ReadAllLines(filePath);

            // Устанавливаем количество строк и столбцов в DataGridView
            dataGridViewOriginal_MKA.RowCount = 11; // Включая заголовки
            dataGridViewOriginal_MKA.ColumnCount = 5;

            // Устанавливаем названия столбцов
            dataGridViewOriginal_MKA.Columns[0].Name = "Номер";
            dataGridViewOriginal_MKA.Columns[1].Name = "Фамилия";
            dataGridViewOriginal_MKA.Columns[2].Name = "Имя";
            dataGridViewOriginal_MKA.Columns[3].Name = "Отчество";
            dataGridViewOriginal_MKA.Columns[4].Name = "Дата рождения пациента";

            // Заполняем ячейки DataGridView данными из файла
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                for (int j = 0; j < data.Length; j++)
                {
                    dataGridViewOriginal_MKA.Rows[i].Cells[j].Value = data[j];
                }
            }
        }
    }
}

