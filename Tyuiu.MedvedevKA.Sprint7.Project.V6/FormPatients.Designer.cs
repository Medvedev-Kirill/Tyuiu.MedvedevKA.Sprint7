
namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    partial class FormPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatients));
            this.panelLeft_MKA = new System.Windows.Forms.Panel();
            this.groupBoxTool_MKA = new System.Windows.Forms.GroupBox();
            this.buttonFunction_MKA = new System.Windows.Forms.Button();
            this.buttonDelete_MKA = new System.Windows.Forms.Button();
            this.buttonSaveFile_MKA = new System.Windows.Forms.Button();
            this.buttonOpenFile_MKA = new System.Windows.Forms.Button();
            this.panelData_MKA = new System.Windows.Forms.Panel();
            this.groupBoxOriginal_MKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewPactients_MKA = new System.Windows.Forms.DataGridView();
            this.openFileDialog_MKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MKA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_MKA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MKA = new System.Windows.Forms.Panel();
            this.groupBoxFiltre_MKA = new System.Windows.Forms.GroupBox();
            this.labelColumn_MKA = new System.Windows.Forms.Label();
            this.labelParametr_MKA = new System.Windows.Forms.Label();
            this.comboBoxInfo_MKA = new System.Windows.Forms.ComboBox();
            this.buttonFiltre_MKA = new System.Windows.Forms.Button();
            this.textBoxParametr_MKA = new System.Windows.Forms.TextBox();
            this.panelLeft_MKA.SuspendLayout();
            this.groupBoxTool_MKA.SuspendLayout();
            this.panelData_MKA.SuspendLayout();
            this.groupBoxOriginal_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPactients_MKA)).BeginInit();
            this.panelTop_MKA.SuspendLayout();
            this.groupBoxFiltre_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_MKA
            // 
            this.panelLeft_MKA.Controls.Add(this.groupBoxTool_MKA);
            this.panelLeft_MKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MKA.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_MKA.Name = "panelLeft_MKA";
            this.panelLeft_MKA.Size = new System.Drawing.Size(150, 502);
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
            this.groupBoxTool_MKA.Size = new System.Drawing.Size(140, 492);
            this.groupBoxTool_MKA.TabIndex = 0;
            this.groupBoxTool_MKA.TabStop = false;
            this.groupBoxTool_MKA.Text = "Инструменты:";
            // 
            // buttonFunction_MKA
            // 
            this.buttonFunction_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFunction_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFunction_MKA.Image")));
            this.buttonFunction_MKA.Location = new System.Drawing.Point(3, 304);
            this.buttonFunction_MKA.Name = "buttonFunction_MKA";
            this.buttonFunction_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonFunction_MKA.TabIndex = 3;
            this.buttonFunction_MKA.Text = "График";
            this.buttonFunction_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonFunction_MKA, "Открывает график");
            this.buttonFunction_MKA.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_MKA
            // 
            this.buttonDelete_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_MKA.Image")));
            this.buttonDelete_MKA.Location = new System.Drawing.Point(3, 208);
            this.buttonDelete_MKA.Name = "buttonDelete_MKA";
            this.buttonDelete_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonDelete_MKA.TabIndex = 2;
            this.buttonDelete_MKA.Text = "Удалить";
            this.buttonDelete_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonDelete_MKA, "Удаляет данные в таблице");
            this.buttonDelete_MKA.UseVisualStyleBackColor = true;
            this.buttonDelete_MKA.Click += new System.EventHandler(this.buttonDelete_MKA_Click);
            // 
            // buttonSaveFile_MKA
            // 
            this.buttonSaveFile_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_MKA.Image")));
            this.buttonSaveFile_MKA.Location = new System.Drawing.Point(3, 112);
            this.buttonSaveFile_MKA.Name = "buttonSaveFile_MKA";
            this.buttonSaveFile_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonSaveFile_MKA.TabIndex = 1;
            this.buttonSaveFile_MKA.Text = "Сохранить Файл";
            this.buttonSaveFile_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonSaveFile_MKA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_MKA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_MKA.Click += new System.EventHandler(this.buttonSaveFile_MKA_Click);
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
            // panelData_MKA
            // 
            this.panelData_MKA.Controls.Add(this.groupBoxOriginal_MKA);
            this.panelData_MKA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData_MKA.Location = new System.Drawing.Point(150, 90);
            this.panelData_MKA.Name = "panelData_MKA";
            this.panelData_MKA.Size = new System.Drawing.Size(910, 412);
            this.panelData_MKA.TabIndex = 1;
            // 
            // groupBoxOriginal_MKA
            // 
            this.groupBoxOriginal_MKA.Controls.Add(this.dataGridViewPactients_MKA);
            this.groupBoxOriginal_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxOriginal_MKA.Name = "groupBoxOriginal_MKA";
            this.groupBoxOriginal_MKA.Size = new System.Drawing.Size(903, 401);
            this.groupBoxOriginal_MKA.TabIndex = 0;
            this.groupBoxOriginal_MKA.TabStop = false;
            this.groupBoxOriginal_MKA.Text = "Данные:";
            // 
            // dataGridViewPactients_MKA
            // 
            this.dataGridViewPactients_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPactients_MKA.ColumnHeadersVisible = false;
            this.dataGridViewPactients_MKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPactients_MKA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPactients_MKA.Name = "dataGridViewPactients_MKA";
            this.dataGridViewPactients_MKA.RowHeadersVisible = false;
            this.dataGridViewPactients_MKA.Size = new System.Drawing.Size(897, 382);
            this.dataGridViewPactients_MKA.TabIndex = 0;
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
            this.panelTop_MKA.Size = new System.Drawing.Size(910, 87);
            this.panelTop_MKA.TabIndex = 2;
            // 
            // groupBoxFiltre_MKA
            // 
            this.groupBoxFiltre_MKA.Controls.Add(this.textBoxParametr_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.comboBoxInfo_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.labelParametr_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.labelColumn_MKA);
            this.groupBoxFiltre_MKA.Location = new System.Drawing.Point(7, 4);
            this.groupBoxFiltre_MKA.Name = "groupBoxFiltre_MKA";
            this.groupBoxFiltre_MKA.Size = new System.Drawing.Size(259, 80);
            this.groupBoxFiltre_MKA.TabIndex = 0;
            this.groupBoxFiltre_MKA.TabStop = false;
            this.groupBoxFiltre_MKA.Text = "Фильтрация:";
            // 
            // labelColumn_MKA
            // 
            this.labelColumn_MKA.AutoSize = true;
            this.labelColumn_MKA.Location = new System.Drawing.Point(6, 16);
            this.labelColumn_MKA.Name = "labelColumn_MKA";
            this.labelColumn_MKA.Size = new System.Drawing.Size(52, 13);
            this.labelColumn_MKA.TabIndex = 4;
            this.labelColumn_MKA.Text = "Столбец:";
            // 
            // labelParametr_MKA
            // 
            this.labelParametr_MKA.AutoSize = true;
            this.labelParametr_MKA.Location = new System.Drawing.Point(145, 16);
            this.labelParametr_MKA.Name = "labelParametr_MKA";
            this.labelParametr_MKA.Size = new System.Drawing.Size(61, 13);
            this.labelParametr_MKA.TabIndex = 5;
            this.labelParametr_MKA.Text = "Параметр:";
            // 
            // comboBoxInfo_MKA
            // 
            this.comboBoxInfo_MKA.FormattingEnabled = true;
            this.comboBoxInfo_MKA.Items.AddRange(new object[] {
            "Номер",
            "Фамилия",
            "Имя",
            "Отчесвтво",
            "Дата рождения"});
            this.comboBoxInfo_MKA.Location = new System.Drawing.Point(9, 33);
            this.comboBoxInfo_MKA.Name = "comboBoxInfo_MKA";
            this.comboBoxInfo_MKA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInfo_MKA.TabIndex = 6;
            // 
            // buttonFiltre_MKA
            // 
            this.buttonFiltre_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiltre_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltre_MKA.Image")));
            this.buttonFiltre_MKA.Location = new System.Drawing.Point(3, 401);
            this.buttonFiltre_MKA.Name = "buttonFiltre_MKA";
            this.buttonFiltre_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonFiltre_MKA.TabIndex = 4;
            this.buttonFiltre_MKA.Text = "Отфильтровать";
            this.buttonFiltre_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonFiltre_MKA, "Делает фильтрацию");
            this.buttonFiltre_MKA.UseVisualStyleBackColor = true;
            this.buttonFiltre_MKA.Click += new System.EventHandler(this.buttonFiltre_MKA_Click);
            // 
            // textBoxParametr_MKA
            // 
            this.textBoxParametr_MKA.Location = new System.Drawing.Point(148, 33);
            this.textBoxParametr_MKA.Name = "textBoxParametr_MKA";
            this.textBoxParametr_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxParametr_MKA.TabIndex = 7;
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 502);
            this.Controls.Add(this.panelTop_MKA);
            this.Controls.Add(this.panelData_MKA);
            this.Controls.Add(this.panelLeft_MKA);
            this.Name = "FormPatients";
            this.Text = "Пациенты";
            this.panelLeft_MKA.ResumeLayout(false);
            this.groupBoxTool_MKA.ResumeLayout(false);
            this.panelData_MKA.ResumeLayout(false);
            this.groupBoxOriginal_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPactients_MKA)).EndInit();
            this.panelTop_MKA.ResumeLayout(false);
            this.groupBoxFiltre_MKA.ResumeLayout(false);
            this.groupBoxFiltre_MKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_MKA;
        private System.Windows.Forms.GroupBox groupBoxTool_MKA;
        private System.Windows.Forms.Button buttonFunction_MKA;
        private System.Windows.Forms.Button buttonDelete_MKA;
        private System.Windows.Forms.Button buttonSaveFile_MKA;
        private System.Windows.Forms.Button buttonOpenFile_MKA;
        private System.Windows.Forms.Panel panelData_MKA;
        private System.Windows.Forms.GroupBox groupBoxOriginal_MKA;
        private System.Windows.Forms.ToolTip toolTip_MKA;
        private System.Windows.Forms.DataGridView dataGridViewPactients_MKA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MKA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MKA;
        private System.Windows.Forms.Panel panelTop_MKA;
        private System.Windows.Forms.GroupBox groupBoxFiltre_MKA;
        private System.Windows.Forms.Button buttonFiltre_MKA;
        private System.Windows.Forms.ComboBox comboBoxInfo_MKA;
        private System.Windows.Forms.Label labelParametr_MKA;
        private System.Windows.Forms.Label labelColumn_MKA;
        private System.Windows.Forms.TextBox textBoxParametr_MKA;
    }
}