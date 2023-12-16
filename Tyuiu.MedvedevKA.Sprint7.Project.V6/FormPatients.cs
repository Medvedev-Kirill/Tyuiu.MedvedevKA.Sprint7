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

            // Проверяем, существует ли файл
            if (File.Exists(filePath))
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(filePath);

                // Устанавливаем количество строк и столбцов в DataGridView
                dataGridViewOriginal_MKA.RowCount = lines.Length;
                dataGridViewOriginal_MKA.ColumnCount = 5;

                // Заполняем DataGridView данными из файла
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');

                    for (int j = 0; j < values.Length; j++)
                    {
                        dataGridViewOriginal_MKA[j, i].Value = values[j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден!");
            }
        }

    }
}
