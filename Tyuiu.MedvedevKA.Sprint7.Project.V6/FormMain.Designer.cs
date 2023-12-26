
namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAboutProgram_MKA = new System.Windows.Forms.Button();
            this.buttonInfo_MKA = new System.Windows.Forms.Button();
            this.panelBot_MKA = new System.Windows.Forms.Panel();
            this.toolTip_MKA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonPatients_MKA = new System.Windows.Forms.Button();
            this.panelDoctors_MKA = new System.Windows.Forms.Panel();
            this.buttonDoctors_MKA = new System.Windows.Forms.Button();
            this.panelPatients_MKA = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelBot_MKA.SuspendLayout();
            this.panelDoctors_MKA.SuspendLayout();
            this.panelPatients_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAboutProgram_MKA
            // 
            this.buttonAboutProgram_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAboutProgram_MKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAboutProgram_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonAboutProgram_MKA.Image")));
            this.buttonAboutProgram_MKA.Location = new System.Drawing.Point(3, 2);
            this.buttonAboutProgram_MKA.Name = "buttonAboutProgram_MKA";
            this.buttonAboutProgram_MKA.Size = new System.Drawing.Size(60, 55);
            this.buttonAboutProgram_MKA.TabIndex = 0;
            this.toolTip_MKA.SetToolTip(this.buttonAboutProgram_MKA, "Информация о программе");
            this.buttonAboutProgram_MKA.UseVisualStyleBackColor = true;
            this.buttonAboutProgram_MKA.Click += new System.EventHandler(this.buttonAboutProgram_MKA_Click);
            // 
            // buttonInfo_MKA
            // 
            this.buttonInfo_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_MKA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_MKA.Image")));
            this.buttonInfo_MKA.Location = new System.Drawing.Point(446, 2);
            this.buttonInfo_MKA.Name = "buttonInfo_MKA";
            this.buttonInfo_MKA.Size = new System.Drawing.Size(60, 55);
            this.buttonInfo_MKA.TabIndex = 1;
            this.toolTip_MKA.SetToolTip(this.buttonInfo_MKA, "Руководство");
            this.buttonInfo_MKA.UseVisualStyleBackColor = true;
            this.buttonInfo_MKA.Click += new System.EventHandler(this.buttonInfo_MKA_Click);
            // 
            // panelBot_MKA
            // 
            this.panelBot_MKA.Controls.Add(this.buttonAboutProgram_MKA);
            this.panelBot_MKA.Controls.Add(this.buttonInfo_MKA);
            this.panelBot_MKA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot_MKA.Location = new System.Drawing.Point(0, 271);
            this.panelBot_MKA.Name = "panelBot_MKA";
            this.panelBot_MKA.Size = new System.Drawing.Size(509, 60);
            this.panelBot_MKA.TabIndex = 2;
            // 
            // toolTip_MKA
            // 
            this.toolTip_MKA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MKA.ToolTipTitle = "Подсказка";
            // 
            // buttonPatients_MKA
            // 
            this.buttonPatients_MKA.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPatients_MKA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatients_MKA.ForeColor = System.Drawing.Color.Black;
            this.buttonPatients_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonPatients_MKA.Image")));
            this.buttonPatients_MKA.Location = new System.Drawing.Point(12, 12);
            this.buttonPatients_MKA.Name = "buttonPatients_MKA";
            this.buttonPatients_MKA.Size = new System.Drawing.Size(200, 250);
            this.buttonPatients_MKA.TabIndex = 3;
            this.buttonPatients_MKA.Text = "Пациенты";
            this.buttonPatients_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonPatients_MKA, "Информация о пациентах");
            this.buttonPatients_MKA.UseVisualStyleBackColor = false;
            this.buttonPatients_MKA.Click += new System.EventHandler(this.buttonPatients_MKA_Click);
            // 
            // panelDoctors_MKA
            // 
            this.panelDoctors_MKA.Controls.Add(this.buttonDoctors_MKA);
            this.panelDoctors_MKA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDoctors_MKA.Location = new System.Drawing.Point(295, 0);
            this.panelDoctors_MKA.Name = "panelDoctors_MKA";
            this.panelDoctors_MKA.Size = new System.Drawing.Size(214, 271);
            this.panelDoctors_MKA.TabIndex = 5;
            this.toolTip_MKA.SetToolTip(this.panelDoctors_MKA, "Информация о докторах\r\n");
            // 
            // buttonDoctors_MKA
            // 
            this.buttonDoctors_MKA.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDoctors_MKA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDoctors_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDoctors_MKA.Image")));
            this.buttonDoctors_MKA.Location = new System.Drawing.Point(3, 12);
            this.buttonDoctors_MKA.Name = "buttonDoctors_MKA";
            this.buttonDoctors_MKA.Size = new System.Drawing.Size(200, 250);
            this.buttonDoctors_MKA.TabIndex = 0;
            this.buttonDoctors_MKA.Text = "Доктора";
            this.buttonDoctors_MKA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip_MKA.SetToolTip(this.buttonDoctors_MKA, "Информация о докторах");
            this.buttonDoctors_MKA.UseVisualStyleBackColor = false;
            this.buttonDoctors_MKA.Click += new System.EventHandler(this.buttonDoctors_MKA_Click);
            // 
            // panelPatients_MKA
            // 
            this.panelPatients_MKA.Controls.Add(this.buttonPatients_MKA);
            this.panelPatients_MKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPatients_MKA.Location = new System.Drawing.Point(0, 0);
            this.panelPatients_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.panelPatients_MKA.Name = "panelPatients_MKA";
            this.panelPatients_MKA.Size = new System.Drawing.Size(217, 271);
            this.panelPatients_MKA.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(217, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(72, 271);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 331);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelDoctors_MKA);
            this.Controls.Add(this.panelPatients_MKA);
            this.Controls.Add(this.panelBot_MKA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Поликлиника";
            this.panelBot_MKA.ResumeLayout(false);
            this.panelDoctors_MKA.ResumeLayout(false);
            this.panelPatients_MKA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAboutProgram_MKA;
        private System.Windows.Forms.ToolTip toolTip_MKA;
        private System.Windows.Forms.Button buttonInfo_MKA;
        private System.Windows.Forms.Panel panelBot_MKA;
        private System.Windows.Forms.Button buttonPatients_MKA;
        private System.Windows.Forms.Panel panelPatients_MKA;
        private System.Windows.Forms.Panel panelDoctors_MKA;
        private System.Windows.Forms.Button buttonDoctors_MKA;
        private System.Windows.Forms.Splitter splitter1;
    }
}

