
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
            this.panelGuide_MKA = new System.Windows.Forms.Panel();
            this.textBoxGuide_MKA = new System.Windows.Forms.TextBox();
            this.panelGuide_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGuide_MKA
            // 
            this.panelGuide_MKA.Controls.Add(this.textBoxGuide_MKA);
            this.panelGuide_MKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuide_MKA.Location = new System.Drawing.Point(0, 0);
            this.panelGuide_MKA.Name = "panelGuide_MKA";
            this.panelGuide_MKA.Size = new System.Drawing.Size(492, 267);
            this.panelGuide_MKA.TabIndex = 0;
            // 
            // textBoxGuide_MKA
            // 
            this.textBoxGuide_MKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGuide_MKA.Location = new System.Drawing.Point(0, 0);
            this.textBoxGuide_MKA.Multiline = true;
            this.textBoxGuide_MKA.Name = "textBoxGuide_MKA";
            this.textBoxGuide_MKA.ReadOnly = true;
            this.textBoxGuide_MKA.Size = new System.Drawing.Size(492, 267);
            this.textBoxGuide_MKA.TabIndex = 0;
            this.textBoxGuide_MKA.Text = resources.GetString("textBoxGuide_MKA.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 267);
            this.Controls.Add(this.panelGuide_MKA);
            this.Name = "FormGuide";
            this.Text = "Руководство";
            this.panelGuide_MKA.ResumeLayout(false);
            this.panelGuide_MKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuide_MKA;
        private System.Windows.Forms.TextBox textBoxGuide_MKA;
    }
}