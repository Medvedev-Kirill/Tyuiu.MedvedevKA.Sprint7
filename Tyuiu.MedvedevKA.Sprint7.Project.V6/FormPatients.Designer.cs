
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
            this.buttonOpenFile_MKA = new System.Windows.Forms.Button();
            this.buttonSaveFile_MKA = new System.Windows.Forms.Button();
            this.buttonDelete_MKA = new System.Windows.Forms.Button();
            this.buttonFunction_MKA = new System.Windows.Forms.Button();
            this.panelInPutFile_MKA = new System.Windows.Forms.Panel();
            this.panelOutPutFile = new System.Windows.Forms.Panel();
            this.groupBoxOriginal_MKA = new System.Windows.Forms.GroupBox();
            this.groupBoxFinal_MKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOriginal_MKA = new System.Windows.Forms.DataGridView();
            this.dataGridViewFinal_MKA = new System.Windows.Forms.DataGridView();
            this.openFileDialog_MKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MKA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_MKA = new System.Windows.Forms.SaveFileDialog();
            this.panelLeft_MKA.SuspendLayout();
            this.groupBoxTool_MKA.SuspendLayout();
            this.panelInPutFile_MKA.SuspendLayout();
            this.panelOutPutFile.SuspendLayout();
            this.groupBoxOriginal_MKA.SuspendLayout();
            this.groupBoxFinal_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal_MKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal_MKA)).BeginInit();
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
            this.groupBoxTool_MKA.Controls.Add(this.buttonFunction_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonDelete_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonSaveFile_MKA);
            this.groupBoxTool_MKA.Controls.Add(this.buttonOpenFile_MKA);
            this.groupBoxTool_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTool_MKA.Name = "groupBoxTool_MKA";
            this.groupBoxTool_MKA.Size = new System.Drawing.Size(140, 403);
            this.groupBoxTool_MKA.TabIndex = 0;
            this.groupBoxTool_MKA.TabStop = false;
            this.groupBoxTool_MKA.Text = "Инструменты";
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
            this.buttonSaveFile_MKA.Location = new System.Drawing.Point(3, 112);
            this.buttonSaveFile_MKA.Name = "buttonSaveFile_MKA";
            this.buttonSaveFile_MKA.Size = new System.Drawing.Size(134, 90);
            this.buttonSaveFile_MKA.TabIndex = 1;
            this.buttonSaveFile_MKA.Text = "Сохранить файл";
            this.buttonSaveFile_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonSaveFile_MKA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_MKA.UseVisualStyleBackColor = true;
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
            // panelInPutFile_MKA
            // 
            this.panelInPutFile_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInPutFile_MKA.Controls.Add(this.groupBoxOriginal_MKA);
            this.panelInPutFile_MKA.Location = new System.Drawing.Point(156, 116);
            this.panelInPutFile_MKA.Name = "panelInPutFile_MKA";
            this.panelInPutFile_MKA.Size = new System.Drawing.Size(456, 386);
            this.panelInPutFile_MKA.TabIndex = 1;
            // 
            // panelOutPutFile
            // 
            this.panelOutPutFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutPutFile.Controls.Add(this.groupBoxFinal_MKA);
            this.panelOutPutFile.Location = new System.Drawing.Point(624, 116);
            this.panelOutPutFile.Name = "panelOutPutFile";
            this.panelOutPutFile.Size = new System.Drawing.Size(433, 386);
            this.panelOutPutFile.TabIndex = 2;
            // 
            // groupBoxOriginal_MKA
            // 
            this.groupBoxOriginal_MKA.Controls.Add(this.dataGridViewOriginal_MKA);
            this.groupBoxOriginal_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxOriginal_MKA.Name = "groupBoxOriginal_MKA";
            this.groupBoxOriginal_MKA.Size = new System.Drawing.Size(449, 370);
            this.groupBoxOriginal_MKA.TabIndex = 0;
            this.groupBoxOriginal_MKA.TabStop = false;
            this.groupBoxOriginal_MKA.Text = "Исходные данные:";
            // 
            // groupBoxFinal_MKA
            // 
            this.groupBoxFinal_MKA.Controls.Add(this.dataGridViewFinal_MKA);
            this.groupBoxFinal_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFinal_MKA.Name = "groupBoxFinal_MKA";
            this.groupBoxFinal_MKA.Size = new System.Drawing.Size(420, 379);
            this.groupBoxFinal_MKA.TabIndex = 0;
            this.groupBoxFinal_MKA.TabStop = false;
            this.groupBoxFinal_MKA.Text = "Итоговые данные:";
            // 
            // dataGridViewOriginal_MKA
            // 
            this.dataGridViewOriginal_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOriginal_MKA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOriginal_MKA.Name = "dataGridViewOriginal_MKA";
            this.dataGridViewOriginal_MKA.Size = new System.Drawing.Size(442, 353);
            this.dataGridViewOriginal_MKA.TabIndex = 0;
            // 
            // dataGridViewFinal_MKA
            // 
            this.dataGridViewFinal_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinal_MKA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewFinal_MKA.Name = "dataGridViewFinal_MKA";
            this.dataGridViewFinal_MKA.Size = new System.Drawing.Size(407, 353);
            this.dataGridViewFinal_MKA.TabIndex = 0;
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
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 502);
            this.Controls.Add(this.panelOutPutFile);
            this.Controls.Add(this.panelInPutFile_MKA);
            this.Controls.Add(this.panelLeft_MKA);
            this.Name = "FormPatients";
            this.Text = "Пациенты";
            this.panelLeft_MKA.ResumeLayout(false);
            this.groupBoxTool_MKA.ResumeLayout(false);
            this.panelInPutFile_MKA.ResumeLayout(false);
            this.panelOutPutFile.ResumeLayout(false);
            this.groupBoxOriginal_MKA.ResumeLayout(false);
            this.groupBoxFinal_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal_MKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinal_MKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_MKA;
        private System.Windows.Forms.GroupBox groupBoxTool_MKA;
        private System.Windows.Forms.Button buttonFunction_MKA;
        private System.Windows.Forms.Button buttonDelete_MKA;
        private System.Windows.Forms.Button buttonSaveFile_MKA;
        private System.Windows.Forms.Button buttonOpenFile_MKA;
        private System.Windows.Forms.Panel panelInPutFile_MKA;
        private System.Windows.Forms.GroupBox groupBoxOriginal_MKA;
        private System.Windows.Forms.Panel panelOutPutFile;
        private System.Windows.Forms.GroupBox groupBoxFinal_MKA;
        private System.Windows.Forms.ToolTip toolTip_MKA;
        private System.Windows.Forms.DataGridView dataGridViewOriginal_MKA;
        private System.Windows.Forms.DataGridView dataGridViewFinal_MKA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_MKA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_MKA;
    }
}