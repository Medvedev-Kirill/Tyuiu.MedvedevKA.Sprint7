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
using System.Windows.Forms.DataVisualization.Charting;

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
            string searchValue = textBoxSearch_MKA.Text.ToLower();
            for (int i = 0; i < dataGridViewDoctors_MKA.RowCount; i++)
            {
                dataGridViewDoctors_MKA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewDoctors_MKA.ColumnCount; j++)
                {
                    var searchCell = dataGridViewDoctors_MKA.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (searchCell != null)
                    {
                        if (searchCell.Contains(searchValue))
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

        private void buttonFunction_MKA_Click(object sender, EventArgs e)
        {
            this.chartFunction_MKA.ChartAreas[0].AxisX.Title = "ФИО";
            this.chartFunction_MKA.ChartAreas[0].AxisY.Title = "Срок потери трудоспособности";
            if (dataGridViewDoctors_MKA.RowCount > 0)
            {
                chartFunction_MKA.Series.Clear();

                // Добавление серии для первого столбца (текст)
                Series series1 = chartFunction_MKA.Series.Add("ФИО");
                series1.ChartType = SeriesChartType.Column;

                // Добавление серии для пятого столбца (текст и числа)
                Series series5 = chartFunction_MKA.Series.Add("Срок потери трудоспособности");
                series5.ChartType = SeriesChartType.Column;

                for (int i = 0; i < dataGridViewDoctors_MKA.RowCount; i++)
                {
                    // Добавление точек в первую серию (первый столбец)
                    series1.Points.AddXY(i, dataGridViewDoctors_MKA.Rows[i].Cells[0].Value);

                    // Добавление точек в пятую серию (пятый столбец)
                    series5.Points.AddXY(i, dataGridViewDoctors_MKA.Rows[i].Cells[4].Value);
                }
            }
            else
            {
                MessageBox.Show("Таблица пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalculate_MKA_Click(object sender, EventArgs e)
        {
            // Инициализируем переменные для хранения максимального, минимального и среднего значения
            double maxValue = 0;
            double minValue = 0;
            double sumValue = 0;
            double averageValue = 0;

            // Перебираем все строки в пятом столбце dataGridView
            for (int i = 1; i < dataGridViewDoctors_MKA.RowCount; i++)
            {
                // Получаем значение из пятого столбца dataGridView для текущей строки
                double value = Convert.ToDouble(dataGridViewDoctors_MKA.Rows[i].Cells[4].Value);

                // Обновляем максимальное и минимальное значения
                if (value > maxValue)
                {
                    maxValue = value;
                }
                if (value < minValue || i == 1)
                {
                    minValue = value;
                }

                // Считаем сумму всех значений
                sumValue += value;
            }

            // Вычисляем среднее значение
            averageValue = sumValue / dataGridViewDoctors_MKA.RowCount;

            // Выводим найденные значения в TextBox
            textBoxMax_MKA.Text = maxValue.ToString();
            textBoxMin_MKA.Text = minValue.ToString();
            textBoxAverage_MKA.Text = averageValue.ToString();
        }
    }
}
