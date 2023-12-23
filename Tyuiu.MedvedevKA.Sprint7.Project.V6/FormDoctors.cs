using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MedvedevKA.Sprint7.Project.V6.Lib;
using System.IO;

namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    public partial class FormDoctors : Form
    {
        public FormDoctors()
        {
            InitializeComponent();
        }
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonOpenFile_MKA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_MKA.ShowDialog();
                openFile = openFileDialog_MKA.FileName;

                matrix = ds.GetMatrix(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewDoctors_MKA.RowCount = rows;
                dataGridViewDoctors_MKA.ColumnCount = columns;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewDoctors_MKA.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewDoctors_MKA.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewDoctors_MKA.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Проблема с открытием файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_MKA_Click(object sender, EventArgs e)
        {
            saveFileDialog_MKA.FileName = "OutPutFileDoctors.csv";
            saveFileDialog_MKA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MKA.ShowDialog();

            string path = saveFileDialog_MKA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewDoctors_MKA.RowCount;
            int columns = dataGridViewDoctors_MKA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewDoctors_MKA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewDoctors_MKA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDelete_MKA_Click(object sender, EventArgs e)
        {
            dataGridViewDoctors_MKA.Rows.Clear();
        }

        private void buttonFiltre_MKA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewDoctors_MKA.RowCount - 1; i++)
            {
                string filterValue = textBoxParametr_MKA.Text.ToLower();
                dataGridViewDoctors_MKA.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewDoctors_MKA.ColumnCount; j++)
                {
                    var cellValue = dataGridViewDoctors_MKA.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (cellValue != null && cellValue == filterValue)
                    {
                        dataGridViewDoctors_MKA.Rows[i].Visible = true;
                        break;
                    }
                }
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewDoctors_MKA.Rows[matrix.GetLength(0) - 1].Cells[c].Value = "";
                }
            }
        }

        private void buttonSearch_MKA_Click(object sender, EventArgs e)
        {
            string serchValue = textBoxSearch_MKA.Text.ToLower();
            for (int i = 0; i < dataGridViewDoctors_MKA.RowCount; i++)
            {
                dataGridViewDoctors_MKA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewDoctors_MKA.ColumnCount; j++)
                {
                    var serchEl = dataGridViewDoctors_MKA.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (serchEl != null)
                    {
                        if (serchEl.ToString().Contains(textBoxSearch_MKA.Text))
                        {
                            dataGridViewDoctors_MKA.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        string path = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint7\Tyuiu.MedvedevKA.Sprint7.Project.V6\bin\Debug\Doctors.csv";
        private void столбецСрокПотериТрудоспособностиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.AscendingSort(mx, 4);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewDoctors_MKA.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецСрокПотериТрудоспособностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.DescendingSort(mx, 4);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewDoctors_MKA.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            } 
        }

        private void buttonMax_MKA_Click(object sender, EventArgs e)
        {
            int Column = 1;
            int maxValue = int.MaxValue;
            if (comboBoxMax_MKA.SelectedItem.ToString() == "Срок потери трудоспособности")
            {
                foreach (DataGridViewRow row in dataGridViewDoctors_MKA.Rows)
                {
                    if (row.Cells[Column].Value != null)
                    {
                        if (int.TryParse(row.Cells[Column].Value.ToString(), out int cellValue))
                        {
                            maxValue = Math.Max(maxValue, cellValue);
                        }
                    }
                }
            }
            textBoxMax_MKA.Text = maxValue.ToString();
        }

        private void buttonAverage_MKA_Click(object sender, EventArgs e)
        {
            int Column = 1;
            int sum = 0;
            int count = 0;
            if (comboBoxAverage_MKA.SelectedItem?.ToString() == "Срок потери трудоспособности")
            {
                foreach (DataGridViewRow row in dataGridViewDoctors_MKA.Rows)
                {
                    if (row.Cells[Column].Value != null)
                    {
                        if (int.TryParse(row.Cells[Column].Value.ToString(), out int cellValue))
                        {
                            sum += cellValue;
                            count++;
                        }
                    }
                }
            }
            if (count > 0)
            {
                double sr = Math.Round((double)sum / count, 3);
                textBoxAverage_MKA.Text = sr.ToString();
            }
        }

        private void buttonMin_MKA_Click(object sender, EventArgs e)
        {
            int Column = 1;
            int minValue = int.MinValue;
            if (comboBoxMax_MKA.SelectedItem.ToString() == "Срок потери трудоспособности")
            {
                foreach (DataGridViewRow row in dataGridViewDoctors_MKA.Rows)
                {
                    if (row.Cells[Column].Value != null)
                    {
                        if (int.TryParse(row.Cells[Column].Value.ToString(), out int cellValue))
                        {
                            minValue = Math.Max(minValue, cellValue);
                        }
                    }
                }
            }
            textBoxMin_MKA.Text = minValue.ToString();
        }

        private void buttonFunction_MKA_Click(object sender, EventArgs e)
        {
            FormSheduleDoctors formSheduleDoctors = new FormSheduleDoctors();
            formSheduleDoctors.ShowDialog();
        }
    }
}
