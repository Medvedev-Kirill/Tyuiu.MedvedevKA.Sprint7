
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
            this.buttonFiltre_MKA = new System.Windows.Forms.Button();
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
            this.textBoxParametr_MKA = new System.Windows.Forms.TextBox();
            this.labelParametr_MKA = new System.Windows.Forms.Label();
            this.groupBoxElement_MKA = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxSearch_MKA = new System.Windows.Forms.TextBox();
            this.buttonSearch_MKA = new System.Windows.Forms.Button();
            this.comboBoxMax_MKA = new System.Windows.Forms.ComboBox();
            this.buttonMax_MKA = new System.Windows.Forms.Button();
            this.textBoxMax_MKA = new System.Windows.Forms.TextBox();
            this.labelMax_MKA = new System.Windows.Forms.Label();
            this.labelAverage_MKA = new System.Windows.Forms.Label();
            this.comboBoxAverage_MKA = new System.Windows.Forms.ComboBox();
            this.buttonAverage_MKA = new System.Windows.Forms.Button();
            this.textBoxAverage_MKA = new System.Windows.Forms.TextBox();
            this.labelMin_MKA = new System.Windows.Forms.Label();
            this.comboBoxMin_MKA = new System.Windows.Forms.ComboBox();
            this.buttonMin_MKA = new System.Windows.Forms.Button();
            this.textBoxMin_MKA = new System.Windows.Forms.TextBox();
            this.menuStrip_MKA = new System.Windows.Forms.MenuStrip();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.столбецНомерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft_MKA.SuspendLayout();
            this.groupBoxTool_MKA.SuspendLayout();
            this.panelData_MKA.SuspendLayout();
            this.groupBoxOriginal_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPactients_MKA)).BeginInit();
            this.panelTop_MKA.SuspendLayout();
            this.groupBoxFiltre_MKA.SuspendLayout();
            this.groupBoxElement_MKA.SuspendLayout();
            this.groupBoxSearch_MKA.SuspendLayout();
            this.menuStrip_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_MKA
            // 
            this.panelLeft_MKA.Controls.Add(this.groupBoxTool_MKA);
            this.panelLeft_MKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MKA.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_MKA.Name = "panelLeft_MKA";
            this.panelLeft_MKA.Size = new System.Drawing.Size(150, 546);
            this.panelLeft_MKA.TabIndex = 0;
            // 
            // groupBoxTool_MKA
            // 
            this.groupBoxTool_MKA.Controls.Add(this.buttonFunction_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonDelete_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonSaveFile_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonOpenFile_MKA);
            this.groupBoxTool_MKA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTool_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTool_MKA.Name = "groupBoxTool_MKA";
            this.groupBoxTool_MKA.Size = new System.Drawing.Size(140, 536);
            this.groupBoxTool_MKA.TabIndex = 0;
            this.groupBoxTool_MKA.TabStop = false;
            this.groupBoxTool_MKA.Text = "Инструменты:";
            // 
            // buttonFiltre_MKA
            // 
            this.buttonFiltre_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFiltre_MKA.Location = new System.Drawing.Point(128, 60);
            this.buttonFiltre_MKA.Name = "buttonFiltre_MKA";
            this.buttonFiltre_MKA.Size = new System.Drawing.Size(125, 40);
            this.buttonFiltre_MKA.TabIndex = 4;
            this.buttonFiltre_MKA.Text = "Отфильтровать";
            this.toolTip_MKA.SetToolTip(this.buttonFiltre_MKA, "Делает фильтрацию");
            this.buttonFiltre_MKA.UseVisualStyleBackColor = true;
            this.buttonFiltre_MKA.Click += new System.EventHandler(this.buttonFiltre_MKA_Click);
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
            this.buttonFunction_MKA.Click += new System.EventHandler(this.buttonFunction_MKA_Click);
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
            this.buttonOpenFile_MKA.Location = new System.Drawing.Point(3, 18);
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
            this.panelData_MKA.Controls.Add(this.menuStrip_MKA);
            this.panelData_MKA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData_MKA.Location = new System.Drawing.Point(150, 120);
            this.panelData_MKA.Name = "panelData_MKA";
            this.panelData_MKA.Size = new System.Drawing.Size(1037, 426);
            this.panelData_MKA.TabIndex = 1;
            // 
            // groupBoxOriginal_MKA
            // 
            this.groupBoxOriginal_MKA.Controls.Add(this.dataGridViewPactients_MKA);
            this.groupBoxOriginal_MKA.Location = new System.Drawing.Point(4, 22);
            this.groupBoxOriginal_MKA.Name = "groupBoxOriginal_MKA";
            this.groupBoxOriginal_MKA.Size = new System.Drawing.Size(1028, 405);
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
            this.dataGridViewPactients_MKA.Size = new System.Drawing.Size(1022, 386);
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
            this.panelTop_MKA.Controls.Add(this.groupBoxSearch_MKA);
            this.panelTop_MKA.Controls.Add(this.groupBoxElement_MKA);
            this.panelTop_MKA.Controls.Add(this.groupBoxFiltre_MKA);
            this.panelTop_MKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MKA.Location = new System.Drawing.Point(150, 0);
            this.panelTop_MKA.Name = "panelTop_MKA";
            this.panelTop_MKA.Size = new System.Drawing.Size(1037, 117);
            this.panelTop_MKA.TabIndex = 2;
            // 
            // groupBoxFiltre_MKA
            // 
            this.groupBoxFiltre_MKA.Controls.Add(this.buttonFiltre_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.textBoxParametr_MKA);
            this.groupBoxFiltre_MKA.Controls.Add(this.labelParametr_MKA);
            this.groupBoxFiltre_MKA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFiltre_MKA.Location = new System.Drawing.Point(7, 4);
            this.groupBoxFiltre_MKA.Name = "groupBoxFiltre_MKA";
            this.groupBoxFiltre_MKA.Size = new System.Drawing.Size(259, 108);
            this.groupBoxFiltre_MKA.TabIndex = 0;
            this.groupBoxFiltre_MKA.TabStop = false;
            this.groupBoxFiltre_MKA.Text = "Фильтрация:";
            // 
            // textBoxParametr_MKA
            // 
            this.textBoxParametr_MKA.Location = new System.Drawing.Point(9, 32);
            this.textBoxParametr_MKA.Name = "textBoxParametr_MKA";
            this.textBoxParametr_MKA.Size = new System.Drawing.Size(244, 22);
            this.textBoxParametr_MKA.TabIndex = 7;
            // 
            // labelParametr_MKA
            // 
            this.labelParametr_MKA.AutoSize = true;
            this.labelParametr_MKA.Location = new System.Drawing.Point(6, 16);
            this.labelParametr_MKA.Name = "labelParametr_MKA";
            this.labelParametr_MKA.Size = new System.Drawing.Size(65, 15);
            this.labelParametr_MKA.TabIndex = 5;
            this.labelParametr_MKA.Text = "Параметр:";
            // 
            // groupBoxElement_MKA
            // 
            this.groupBoxElement_MKA.Controls.Add(this.textBoxMin_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.buttonMin_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.comboBoxMin_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.labelMin_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.textBoxAverage_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.buttonAverage_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.comboBoxAverage_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.labelAverage_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.labelMax_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.textBoxMax_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.buttonMax_MKA);
            this.groupBoxElement_MKA.Controls.Add(this.comboBoxMax_MKA);
            this.groupBoxElement_MKA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxElement_MKA.Location = new System.Drawing.Point(273, 4);
            this.groupBoxElement_MKA.Name = "groupBoxElement_MKA";
            this.groupBoxElement_MKA.Size = new System.Drawing.Size(552, 108);
            this.groupBoxElement_MKA.TabIndex = 1;
            this.groupBoxElement_MKA.TabStop = false;
            this.groupBoxElement_MKA.Text = "Элементы статистики:";
            // 
            // groupBoxSearch_MKA
            // 
            this.groupBoxSearch_MKA.Controls.Add(this.buttonSearch_MKA);
            this.groupBoxSearch_MKA.Controls.Add(this.textBoxSearch_MKA);
            this.groupBoxSearch_MKA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch_MKA.Location = new System.Drawing.Point(832, 4);
            this.groupBoxSearch_MKA.Name = "groupBoxSearch_MKA";
            this.groupBoxSearch_MKA.Size = new System.Drawing.Size(200, 108);
            this.groupBoxSearch_MKA.TabIndex = 2;
            this.groupBoxSearch_MKA.TabStop = false;
            this.groupBoxSearch_MKA.Text = "Поиск:";
            // 
            // textBoxSearch_MKA
            // 
            this.textBoxSearch_MKA.Location = new System.Drawing.Point(7, 32);
            this.textBoxSearch_MKA.Name = "textBoxSearch_MKA";
            this.textBoxSearch_MKA.Size = new System.Drawing.Size(186, 22);
            this.textBoxSearch_MKA.TabIndex = 0;
            // 
            // buttonSearch_MKA
            // 
            this.buttonSearch_MKA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch_MKA.Location = new System.Drawing.Point(68, 58);
            this.buttonSearch_MKA.Name = "buttonSearch_MKA";
            this.buttonSearch_MKA.Size = new System.Drawing.Size(125, 40);
            this.buttonSearch_MKA.TabIndex = 5;
            this.buttonSearch_MKA.Text = "Поиск";
            this.toolTip_MKA.SetToolTip(this.buttonSearch_MKA, "Делает поиск");
            this.buttonSearch_MKA.UseVisualStyleBackColor = true;
            this.buttonSearch_MKA.Click += new System.EventHandler(this.buttonSearch_MKA_Click);
            // 
            // comboBoxMax_MKA
            // 
            this.comboBoxMax_MKA.FormattingEnabled = true;
            this.comboBoxMax_MKA.Items.AddRange(new object[] {
            "Номер"});
            this.comboBoxMax_MKA.Location = new System.Drawing.Point(9, 31);
            this.comboBoxMax_MKA.Name = "comboBoxMax_MKA";
            this.comboBoxMax_MKA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMax_MKA.TabIndex = 2;
            // 
            // buttonMax_MKA
            // 
            this.buttonMax_MKA.Location = new System.Drawing.Point(9, 58);
            this.buttonMax_MKA.Name = "buttonMax_MKA";
            this.buttonMax_MKA.Size = new System.Drawing.Size(95, 23);
            this.buttonMax_MKA.TabIndex = 7;
            this.buttonMax_MKA.Text = "Выполнить";
            this.toolTip_MKA.SetToolTip(this.buttonMax_MKA, "Находит максимальное значение");
            this.buttonMax_MKA.UseVisualStyleBackColor = true;
            this.buttonMax_MKA.Click += new System.EventHandler(this.buttonMax_MKA_Click);
            // 
            // textBoxMax_MKA
            // 
            this.textBoxMax_MKA.Location = new System.Drawing.Point(9, 84);
            this.textBoxMax_MKA.Name = "textBoxMax_MKA";
            this.textBoxMax_MKA.Size = new System.Drawing.Size(121, 22);
            this.textBoxMax_MKA.TabIndex = 10;
            // 
            // labelMax_MKA
            // 
            this.labelMax_MKA.AutoSize = true;
            this.labelMax_MKA.Location = new System.Drawing.Point(6, 16);
            this.labelMax_MKA.Name = "labelMax_MKA";
            this.labelMax_MKA.Size = new System.Drawing.Size(147, 15);
            this.labelMax_MKA.TabIndex = 11;
            this.labelMax_MKA.Text = "Максимальное значение:";
            // 
            // labelAverage_MKA
            // 
            this.labelAverage_MKA.AutoSize = true;
            this.labelAverage_MKA.Location = new System.Drawing.Point(200, 16);
            this.labelAverage_MKA.Name = "labelAverage_MKA";
            this.labelAverage_MKA.Size = new System.Drawing.Size(109, 15);
            this.labelAverage_MKA.TabIndex = 12;
            this.labelAverage_MKA.Text = "Среднее значение:";
            // 
            // comboBoxAverage_MKA
            // 
            this.comboBoxAverage_MKA.FormattingEnabled = true;
            this.comboBoxAverage_MKA.Items.AddRange(new object[] {
            "Номер"});
            this.comboBoxAverage_MKA.Location = new System.Drawing.Point(203, 31);
            this.comboBoxAverage_MKA.Name = "comboBoxAverage_MKA";
            this.comboBoxAverage_MKA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAverage_MKA.TabIndex = 13;
            // 
            // buttonAverage_MKA
            // 
            this.buttonAverage_MKA.Location = new System.Drawing.Point(203, 58);
            this.buttonAverage_MKA.Name = "buttonAverage_MKA";
            this.buttonAverage_MKA.Size = new System.Drawing.Size(90, 23);
            this.buttonAverage_MKA.TabIndex = 14;
            this.buttonAverage_MKA.Text = "Выполнить";
            this.toolTip_MKA.SetToolTip(this.buttonAverage_MKA, "Находит среднее значение");
            this.buttonAverage_MKA.UseVisualStyleBackColor = true;
            this.buttonAverage_MKA.Click += new System.EventHandler(this.buttonAverage_MKA_Click);
            // 
            // textBoxAverage_MKA
            // 
            this.textBoxAverage_MKA.Location = new System.Drawing.Point(203, 84);
            this.textBoxAverage_MKA.Name = "textBoxAverage_MKA";
            this.textBoxAverage_MKA.Size = new System.Drawing.Size(121, 22);
            this.textBoxAverage_MKA.TabIndex = 15;
            // 
            // labelMin_MKA
            // 
            this.labelMin_MKA.AutoSize = true;
            this.labelMin_MKA.Location = new System.Drawing.Point(370, 18);
            this.labelMin_MKA.Name = "labelMin_MKA";
            this.labelMin_MKA.Size = new System.Drawing.Size(143, 15);
            this.labelMin_MKA.TabIndex = 16;
            this.labelMin_MKA.Text = "Минимальное значение:";
            // 
            // comboBoxMin_MKA
            // 
            this.comboBoxMin_MKA.FormattingEnabled = true;
            this.comboBoxMin_MKA.Items.AddRange(new object[] {
            "Номер"});
            this.comboBoxMin_MKA.Location = new System.Drawing.Point(373, 32);
            this.comboBoxMin_MKA.Name = "comboBoxMin_MKA";
            this.comboBoxMin_MKA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMin_MKA.TabIndex = 17;
            // 
            // buttonMin_MKA
            // 
            this.buttonMin_MKA.Location = new System.Drawing.Point(373, 58);
            this.buttonMin_MKA.Name = "buttonMin_MKA";
            this.buttonMin_MKA.Size = new System.Drawing.Size(90, 23);
            this.buttonMin_MKA.TabIndex = 18;
            this.buttonMin_MKA.Text = "Выполнить";
            this.toolTip_MKA.SetToolTip(this.buttonMin_MKA, "Находит минимальное значение");
            this.buttonMin_MKA.UseVisualStyleBackColor = true;
            this.buttonMin_MKA.Click += new System.EventHandler(this.buttonMin_MKA_Click);
            // 
            // textBoxMin_MKA
            // 
            this.textBoxMin_MKA.Location = new System.Drawing.Point(373, 85);
            this.textBoxMin_MKA.Name = "textBoxMin_MKA";
            this.textBoxMin_MKA.Size = new System.Drawing.Size(121, 22);
            this.textBoxMin_MKA.TabIndex = 19;
            // 
            // menuStrip_MKA
            // 
            this.menuStrip_MKA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.menuStrip_MKA.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MKA.Name = "menuStrip_MKA";
            this.menuStrip_MKA.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip_MKA.TabIndex = 1;
            this.menuStrip_MKA.Text = "menuStrip1";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецНомерToolStripMenuItem});
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.столбецНомерToolStripMenuItem1});
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            // 
            // столбецНомерToolStripMenuItem
            // 
            this.столбецНомерToolStripMenuItem.Name = "столбецНомерToolStripMenuItem";
            this.столбецНомерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.столбецНомерToolStripMenuItem.Text = "Столбец \"Номер\"";
            this.столбецНомерToolStripMenuItem.Click += new System.EventHandler(this.столбецНомерToolStripMenuItem_Click);
            // 
            // столбецНомерToolStripMenuItem1
            // 
            this.столбецНомерToolStripMenuItem1.Name = "столбецНомерToolStripMenuItem1";
            this.столбецНомерToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.столбецНомерToolStripMenuItem1.Text = "Столбец \"Номер\"";
            this.столбецНомерToolStripMenuItem1.Click += new System.EventHandler(this.столбецНомерToolStripMenuItem1_Click);
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 546);
            this.Controls.Add(this.panelTop_MKA);
            this.Controls.Add(this.panelData_MKA);
            this.Controls.Add(this.panelLeft_MKA);
            this.MainMenuStrip = this.menuStrip_MKA;
            this.Name = "FormPatients";
            this.Text = "Пациенты";
            this.panelLeft_MKA.ResumeLayout(false);
            this.groupBoxTool_MKA.ResumeLayout(false);
            this.panelData_MKA.ResumeLayout(false);
            this.panelData_MKA.PerformLayout();
            this.groupBoxOriginal_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPactients_MKA)).EndInit();
            this.panelTop_MKA.ResumeLayout(false);
            this.groupBoxFiltre_MKA.ResumeLayout(false);
            this.groupBoxFiltre_MKA.PerformLayout();
            this.groupBoxElement_MKA.ResumeLayout(false);
            this.groupBoxElement_MKA.PerformLayout();
            this.groupBoxSearch_MKA.ResumeLayout(false);
            this.groupBoxSearch_MKA.PerformLayout();
            this.menuStrip_MKA.ResumeLayout(false);
            this.menuStrip_MKA.PerformLayout();
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
        private System.Windows.Forms.Label labelParametr_MKA;
        private System.Windows.Forms.TextBox textBoxParametr_MKA;
        private System.Windows.Forms.GroupBox groupBoxElement_MKA;
        private System.Windows.Forms.GroupBox groupBoxSearch_MKA;
        private System.Windows.Forms.Button buttonSearch_MKA;
        private System.Windows.Forms.TextBox textBoxSearch_MKA;
        private System.Windows.Forms.ComboBox comboBoxMax_MKA;
        private System.Windows.Forms.Button buttonMax_MKA;
        private System.Windows.Forms.TextBox textBoxMax_MKA;
        private System.Windows.Forms.Label labelMax_MKA;
        private System.Windows.Forms.Label labelAverage_MKA;
        private System.Windows.Forms.ComboBox comboBoxAverage_MKA;
        private System.Windows.Forms.Button buttonAverage_MKA;
        private System.Windows.Forms.TextBox textBoxAverage_MKA;
        private System.Windows.Forms.Label labelMin_MKA;
        private System.Windows.Forms.ComboBox comboBoxMin_MKA;
        private System.Windows.Forms.Button buttonMin_MKA;
        private System.Windows.Forms.TextBox textBoxMin_MKA;
        private System.Windows.Forms.MenuStrip menuStrip_MKA;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem столбецНомерToolStripMenuItem1;
    }
}