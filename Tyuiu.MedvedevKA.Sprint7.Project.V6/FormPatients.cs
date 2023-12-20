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
            string filterValue = textBoxParametr_MKA.Text.ToLower();

            for (int i = 0; i < dataGridViewPactients_MKA.Rows.Count - 1; i++)
            {
                bool rowShouldBeVisible = false;

                for (int j = 0; j < dataGridViewPactients_MKA.Columns.Count; j++)
                {
                    var cellValue = dataGridViewPactients_MKA.Rows[i].Cells[j].Value?.ToString().ToLower();

                    if (cellValue != null && cellValue.Contains(filterValue))
                    {
                        rowShouldBeVisible = true;
                        break;
                    }
                }
                dataGridViewPactients_MKA.Rows[i].Visible = rowShouldBeVisible;
            }
        }
    }
}


