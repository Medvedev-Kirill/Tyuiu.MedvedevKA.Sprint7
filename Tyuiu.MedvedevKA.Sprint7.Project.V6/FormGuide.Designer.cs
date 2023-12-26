
namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.panelFill_MKA = new System.Windows.Forms.Panel();
            this.groupBoxGuide_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxGuide_MKA = new System.Windows.Forms.TextBox();
            this.buttonOK_MKA = new System.Windows.Forms.Button();
            this.panelFill_MKA.SuspendLayout();
            this.groupBoxGuide_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFill_MKA
            // 
            this.panelFill_MKA.Controls.Add(this.groupBoxGuide_MKA);
            this.panelFill_MKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MKA.Location = new System.Drawing.Point(0, 0);
            this.panelFill_MKA.Name = "panelFill_MKA";
            this.panelFill_MKA.Size = new System.Drawing.Size(317, 327);
            this.panelFill_MKA.TabIndex = 0;
            // 
            // groupBoxGuide_MKA
            // 
            this.groupBoxGuide_MKA.Controls.Add(this.buttonOK_MKA);
            this.groupBoxGuide_MKA.Controls.Add(this.textBoxGuide_MKA);
            this.groupBoxGuide_MKA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxGuide_MKA.Name = "groupBoxGuide_MKA";
            this.groupBoxGuide_MKA.Size = new System.Drawing.Size(302, 317);
            this.groupBoxGuide_MKA.TabIndex = 0;
            this.groupBoxGuide_MKA.TabStop = false;
            this.groupBoxGuide_MKA.Text = "Руководство:";
            // 
            // textBoxGuide_MKA
            // 
            this.textBoxGuide_MKA.Location = new System.Drawing.Point(6, 17);
            this.textBoxGuide_MKA.Multiline = true;
            this.textBoxGuide_MKA.Name = "textBoxGuide_MKA";
            this.textBoxGuide_MKA.ReadOnly = true;
            this.textBoxGuide_MKA.Size = new System.Drawing.Size(255, 260);
            this.textBoxGuide_MKA.TabIndex = 0;
            this.textBoxGuide_MKA.Text = resources.GetString("textBoxGuide_MKA.Text");
            // 
            // buttonOK_MKA
            // 
            this.buttonOK_MKA.Location = new System.Drawing.Point(186, 283);
            this.buttonOK_MKA.Name = "buttonOK_MKA";
            this.buttonOK_MKA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_MKA.TabIndex = 1;
            this.buttonOK_MKA.Text = "ОК";
            this.buttonOK_MKA.UseVisualStyleBackColor = true;
            this.buttonOK_MKA.Click += new System.EventHandler(this.buttonOK_MKA_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 327);
            this.Controls.Add(this.panelFill_MKA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.Text = "Руководство";
            this.panelFill_MKA.ResumeLayout(false);
            this.groupBoxGuide_MKA.ResumeLayout(false);
            this.groupBoxGuide_MKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill_MKA;
        private System.Windows.Forms.GroupBox groupBoxGuide_MKA;
        private System.Windows.Forms.Button buttonOK_MKA;
        private System.Windows.Forms.TextBox textBoxGuide_MKA;
    }
}