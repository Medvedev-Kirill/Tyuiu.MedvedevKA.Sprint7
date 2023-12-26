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
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    public partial class FormPatients : Form
    {
        public FormPatients()
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
                dataGridViewPactients_MKA.RowCount = rows;
                dataGridViewPactients_MKA.ColumnCount = columns;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewPactients_MKA.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewPactients_MKA.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewPactients_MKA.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Проблема с открфтием файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_MKA_Click(object sender, EventArgs e)
        {
            dataGridViewPactients_MKA.Rows.Clear();
        }

        private void buttonSaveFile_MKA_Click(object sender, EventArgs e)
        {
            saveFileDialog_MKA.FileName = "OutPutFilePatients.csv";
            saveFileDialog_MKA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_MKA.ShowDialog();

            string path = saveFileDialog_MKA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewPactients_MKA.RowCount;
            int columns = dataGridViewPactients_MKA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewPactients_MKA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewPactients_MKA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonFiltre_MKA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewPactients_MKA.RowCount - 1; i++)
            {
                string filterValue = textBoxParametr_MKA.Text.ToLower();
                dataGridViewPactients_MKA.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewPactients_MKA.ColumnCount; j++)
                {
                    var cellValue = dataGridViewPactients_MKA.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (cellValue != null && cellValue == filterValue)
                    {
                        dataGridViewPactients_MKA.Rows[i].Visible = true;
                        break;
                    }
                }
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewPactients_MKA.Rows[matrix.GetLength(0) - 1].Cells[c].Value = "";
                }
            }
        }

        private void buttonSearch_MKA_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_MKA.Text.ToLower();
            for (int i = 0; i < dataGridViewPactients_MKA.RowCount; i++)
            {
                dataGridViewPactients_MKA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewPactients_MKA.ColumnCount; j++)
                {
                    var searchCell = dataGridViewPactients_MKA.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (searchCell != null)
                    {
                        if (searchCell.Contains(searchValue))
                        {
                            dataGridViewPactients_MKA.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
        string path = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint7\Tyuiu.MedvedevKA.Sprint7.Project.V6\bin\Debug\Patients.csv";
        private void столбецНомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.AscendingSort(mx, 4);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewPactients_MKA.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецНомерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.GetMatrix(path);
            string[,] mxsort = ds.DescendingSort(mx, 4);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewPactients_MKA.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void buttonMax_MKA_Click(object sender, EventArgs e)
        {
            int Column = 1;
            int maxValue = int.MaxValue;
            if (comboBoxMax_MKA.SelectedItem.ToString() == "Номер")
            {
                foreach (DataGridViewRow row in dataGridViewPactients_MKA.Rows)
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
            if (comboBoxAverage_MKA.SelectedItem?.ToString() == "Номер")
            {
                foreach (DataGridViewRow row in dataGridViewPactients_MKA.Rows)
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
            if (comboBoxMax_MKA.SelectedItem.ToString() == "Номер")
            {
                foreach (DataGridViewRow row in dataGridViewPactients_MKA.Rows)
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
            if (dataGridViewPactients_MKA.RowCount > 0)
            {
                chartFunction_MKA.Series.Clear();

                // Добавление серии для второго столбца (текст)
                Series series2 = chartFunction_MKA.Series.Add("Фамилия");
                series2.ChartType = SeriesChartType.Line;

                // Добавление серии для пятого столбца (текст и числа)
                Series series5 = chartFunction_MKA.Series.Add("Срок потери трудоспособности");
                series5.ChartType = SeriesChartType.Line;

                for (int i = 0; i < dataGridViewPactients_MKA.RowCount; i++)
                {
                    // Добавление точек в первую серию (первый столбец)
                    series2.Points.AddXY(i, dataGridViewPactients_MKA.Rows[i].Cells[1].Value);

                    // Добавление точек в пятую серию (пятый столбец)
                    series5.Points.AddXY(i, dataGridViewPactients_MKA.Rows[i].Cells[4].Value);
                }
            }
            else
            {
                MessageBox.Show("Таблица пуста!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


