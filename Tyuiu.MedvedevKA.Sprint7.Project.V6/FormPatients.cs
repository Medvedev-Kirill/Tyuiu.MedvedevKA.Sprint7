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
            using (StreamReader reader = new StreamReader(@"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint7\Tyuiu.MedvedevKA.Sprint7.Project.V6\bin\Debug\Patients.csv"))
            {
                // Читаем первую строку с заголовками столбцов
                string header = reader.ReadLine();

                // Разделяем заголовки столбцов по символу табуляции или запятой
                string[] columns = header.Split('\t', ',');

                // Добавляем столбцы в DataGridView
                foreach (string column in columns)
                {
                    dataGridViewOriginal_MKA.Columns.Add(column, column);
                }

                // Читаем остальные строки с данными
                while (!reader.EndOfStream)
                {
                    // Читаем строку
                    string line = reader.ReadLine();

                    // Разделяем строки по символу табуляции или запятой
                    string[] data = line.Split('\t', ',');

                    // Добавляем строку в DataGridView
                    dataGridViewOriginal_MKA.Rows.Add(data);
                }
            }

        }
       
    }
}
