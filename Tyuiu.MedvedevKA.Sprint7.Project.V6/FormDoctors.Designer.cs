
namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    partial class FormDoctors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctors));
            this.panelLeft_MKA = new System.Windows.Forms.Panel();
            this.groupBoxTool_MKA = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile_MKA = new System.Windows.Forms.Button();
            this.buttonSaveFile_MKA = new System.Windows.Forms.Button();
            this.buttonDelete_MKA = new System.Windows.Forms.Button();
            this.buttonFunction_MKA = new System.Windows.Forms.Button();
            this.buttonFiltre_MKA = new System.Windows.Forms.Button();
            this.openFileDialog_MKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MKA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_MKA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MKA = new System.Windows.Forms.Panel();
            this.groupBoxFiltre_MKA = new System.Windows.Forms.GroupBox();
            this.panelData_MKA = new System.Windows.Forms.Panel();
            this.groupBoxData_MKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewDoctors_MKA = new System.Windows.Forms.DataGridView();
            this.labelColumn_MKA = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelParametr_MKA = new System.Windows.Forms.Label();
            this.textBoxParametr_MKA = new System.Windows.Forms.TextBox();
            this.panelLeft_MKA.SuspendLayout();
            this.groupBoxTool_MKA.SuspendLayout();
            this.panelTop_MKA.SuspendLayout();
            this.groupBoxFiltre_MKA.SuspendLayout();
            this.panelData_MKA.SuspendLayout();
            this.groupBoxData_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_MKA
            // 
            this.panelLeft_MKA.Controls.Add(this.groupBoxTool_MKA);
            this.panelLeft_MKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MKA.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_MKA.Name = "panelLeft_MKA";
            this.panelLeft_MKA.Size = new System.Drawing.Size(150, 506);
            this.panelLeft_MKA.TabIndex = 0;
            // 
            // groupBoxTool_MKA
            // 
            this.groupBoxTool_MKA.Controls.Add(this.buttonFiltre_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonFunction_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonDelete_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonSaveFile_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonOpenFile_MKA);
            this.groupBoxTool_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTool_MKA.Name = "groupBoxTool_MKA";
            this.groupBoxTool_MKA.Size = new System.Drawing.Size(140, 495);
            this.groupBoxTool_MKA.TabIndex = 0;
            this.groupBoxTool_MKA.TabStop = false;
            this.groupBoxTool_MKA.Text = "Инструменты:";
            // 
            // buttonOpenFile_MKA
            // 
            this.buttonOpenFile_MKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOpenFile_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MKA.Image")));
            this.buttonOpenFile_MKA.Location = new System.Drawing.Point(3, 16);
            this.buttonOpenFile_MKA.Name = "buttonOpenFile_MKA";
            this.buttonOpenFile_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonOpenFile_MKA.TabIndex = 0;
            this.buttonOpenFile_MKA.Text = "Открыть Файл";
            this.buttonOpenFile_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonOpenFile_MKA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_MKA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MKA.Click += new System.EventHandler(this.buttonOpenFile_MKA_Click);
            // 
            // buttonSaveFile_MKA
            // 
            this.buttonSaveFile_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_MKA.Image")));
            this.buttonSaveFile_MKA.Location = new System.Drawing.Point(3, 113);
            this.buttonSaveFile_MKA.Name = "buttonSaveFile_MKA";
            this.buttonSaveFile_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonSaveFile_MKA.TabIndex = 1;
            this.buttonSaveFile_MKA.Text = "Сохранить Файл";
            this.buttonSaveFile_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonSaveFile_MKA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_MKA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_MKA.Click += new System.EventHandler(this.buttonSaveFile_MKA_Click);
            // 
            // buttonDelete_MKA
            // 
            this.buttonDelete_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_MKA.Image")));
            this.buttonDelete_MKA.Location = new System.Drawing.Point(3, 210);
            this.buttonDelete_MKA.Name = "buttonDelete_MKA";
            this.buttonDelete_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonDelete_MKA.TabIndex = 2;
            this.buttonDelete_MKA.Text = "Удалить";
            this.buttonDelete_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonDelete_MKA, "Удаляет данные в таблице");
            this.buttonDelete_MKA.UseVisualStyleBackColor = true;
            this.buttonDelete_MKA.Click += new System.EventHandler(this.buttonDelete_MKA_Click);
            // 
            // buttonFunction_MKA
            // 
            this.buttonFunction_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFunction_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFunction_MKA.Image")));
            this.buttonFunction_MKA.Location = new System.Drawing.Point(3, 307);
            this.buttonFunction_MKA.Name = "buttonFunction_MKA";
            this.buttonFunction_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonFunction_MKA.TabIndex = 3;
            this.buttonFunction_MKA.Text = "График";
            this.buttonFunction_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonFunction_MKA, "Открывает график");
            this.buttonFunction_MKA.UseVisualStyleBackColor = true;
            // 
            // buttonFiltre_MKA
            // 
            this.buttonFiltre_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiltre_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltre_MKA.Image")));
            this.buttonFiltre_MKA.Location = new System.Drawing.Point(3, 404);
            this.buttonFiltre_MKA.Name = "buttonFiltre_MKA";
            this.buttonFiltre_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonFiltre_MKA.TabIndex = 4;
            this.buttonFiltre_MKA.Text = "Отфильтровать";
            this.buttonFiltre_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonFiltre_MKA, "Делает фильтрацию");
            this.buttonFiltre_MKA.UseVisualStyleBackColor = true;
            this.buttonFiltre_MKA.Click += new System.EventHandler(this.buttonFiltre_MKA_Click);
            // 
            // openFileDialog_MKA
            // 
            this.openFileDialog_MKA.FileName = "openFileDialog1";
            // 
            // toolTip_MKA
            // 
            this.toolTip_MKA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MKA.ToolTipTitle = "Подсказка";
            // 
            // panelTop_MKA
            // 
            this.panelTop_MKA.Controls.Add(this.groupBoxFiltre_MKA);
            this.panelTop_MKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MKA.Location = new System.Drawing.Point(150, 0);
            this.panelTop_MKA.Name = "panelTop_MKA";
            this.panelTop_MKA.Size = new System.Drawing.Size(914, 87);
            this.panelTop_MKA.TabIndex = 1;
            // 
            // groupBoxFiltre_MKA
            // 
            this.groupBoxFiltre_MKA.Controls.Add(this.textBoxParametr_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.labelParametr_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.comboBox1);
            this.groupBoxFiltre_MKA.Controls.Add(this.labelColumn_MKA);
            this.groupBoxFiltre_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFiltre_MKA.Name = "groupBoxFiltre_MKA";
            this.groupBoxFiltre_MKA.Size = new System.Drawing.Size(506, 80);
            this.groupBoxFiltre_MKA.TabIndex = 0;
            this.groupBoxFiltre_MKA.TabStop = false;
            this.groupBoxFiltre_MKA.Text = "Фильтрация:";
            // 
            // panelData_MKA
            // 
            this.panelData_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelData_MKA.Controls.Add(this.groupBoxData_MKA);
            this.panelData_MKA.Location = new System.Drawing.Point(150, 91);
            this.panelData_MKA.Name = "panelData_MKA";
            this.panelData_MKA.Size = new System.Drawing.Size(910, 415);
            this.panelData_MKA.TabIndex = 2;
            // 
            // groupBoxData_MKA
            // 
            this.groupBoxData_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxData_MKA.Controls.Add(this.dataGridViewDoctors_MKA);
            this.groupBoxData_MKA.Location = new System.Drawing.Point(7, 4);
            this.groupBoxData_MKA.Name = "groupBoxData_MKA";
            this.groupBoxData_MKA.Size = new System.Drawing.Size(903, 408);
            this.groupBoxData_MKA.TabIndex = 0;
            this.groupBoxData_MKA.TabStop = false;
            this.groupBoxData_MKA.Text = "Данные:";
            // 
            // dataGridViewDoctors_MKA
            // 
            this.dataGridViewDoctors_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewDoctors_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors_MKA.ColumnHeadersVisible = false;
            this.dataGridViewDoctors_MKA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewDoctors_MKA.Name = "dataGridViewDoctors_MKA";
            this.dataGridViewDoctors_MKA.RowHeadersVisible = false;
            this.dataGridViewDoctors_MKA.Size = new System.Drawing.Size(890, 382);
            this.dataGridViewDoctors_MKA.TabIndex = 0;
            // 
            // labelColumn_MKA
            // 
            this.labelColumn_MKA.AutoSize = true;
            this.labelColumn_MKA.Location = new System.Drawing.Point(7, 16);
            this.labelColumn_MKA.Name = "labelColumn_MKA";
            this.labelColumn_MKA.Size = new System.Drawing.Size(52, 13);
            this.labelColumn_MKA.TabIndex = 0;
            this.labelColumn_MKA.Text = "Столбец:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ФИО",
            "Должность и специализация лечащего врача",
            "Диагноз, поставленный данным врачом данному пациенту",
            "Необходимо ли амбулатарное лечение",
            "Срок потери  трудоспособности",
            "Стоит ли на диспансерном учёте",
            "Прмечание"});
            this.comboBox1.Location = new System.Drawing.Point(10, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // labelParametr_MKA
            // 
            this.labelParametr_MKA.AutoSize = true;
            this.labelParametr_MKA.Location = new System.Drawing.Point(337, 18);
            this.labelParametr_MKA.Name = "labelParametr_MKA";
            this.labelParametr_MKA.Size = new System.Drawing.Size(61, 13);
            this.labelParametr_MKA.TabIndex = 2;
            this.labelParametr_MKA.Text = "Параметр:";
            // 
            // textBoxParametr_MKA
            // 
            this.textBoxParametr_MKA.Location = new System.Drawing.Point(340, 34);
            this.textBoxParametr_MKA.Name = "textBoxParametr_MKA";
            this.textBoxParametr_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxParametr_MKA.TabIndex = 3;
            // 
            // FormDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 506);
            this.Controls.Add(this.panelData_MKA);
            this.Controls.Add(this.panelTop_MKA);
            this.Controls.Add(this.panelLeft_MKA);
            this.Name = "FormDoctors";
            this.Text = "Доктора";
            this.panelLeft_MKA.ResumeLayout(false);
            this.groupBoxTool_MKA.ResumeLayout(false);
            this.panelTop_MKA.ResumeLayout(false);
            this.groupBoxFiltre_MKA.ResumeLayout(false);
            this.groupBoxFiltre_MKA.PerformLayout();
            this.panelData_MKA.ResumeLayout(false);
            this.groupBoxData_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors_MKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_MKA;
        private System.Windows.Forms.GroupBox groupBoxTool_MKA;
        private System.Windows.Forms.Button buttonOpenFile_MKA;
        private System.Windows.Forms.Button buttonDelete_MKA;
        private System.Windows.Forms.Button buttonSaveFile_MKA;
        private System.Windows.Forms.Button buttonFunction_MKA;
        private System.Windows.Forms.Button buttonFiltre_MKA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MKA;
        private System.Windows.Forms.ToolTip toolTip_MKA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MKA;
        private System.Windows.Forms.Panel panelTop_MKA;
        private System.Windows.Forms.GroupBox groupBoxFiltre_MKA;
        private System.Windows.Forms.Panel panelData_MKA;
        private System.Windows.Forms.GroupBox groupBoxData_MKA;
        private System.Windows.Forms.DataGridView dataGridViewDoctors_MKA;
        private System.Windows.Forms.Label labelColumn_MKA;
        private System.Windows.Forms.Label labelParametr_MKA;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxParametr_MKA;
    }
}