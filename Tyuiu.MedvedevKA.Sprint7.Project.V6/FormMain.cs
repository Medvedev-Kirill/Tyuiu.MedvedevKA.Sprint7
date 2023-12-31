﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAboutProgram_MKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonPatients_MKA_Click(object sender, EventArgs e)
        {
            FormPatients formPatients = new FormPatients();
            formPatients.ShowDialog();
        }

        private void buttonDoctors_MKA_Click(object sender, EventArgs e)
        {
            FormDoctors formDoctors = new FormDoctors();
            formDoctors.ShowDialog();
        }

        private void buttonInfo_MKA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }
    }
}
