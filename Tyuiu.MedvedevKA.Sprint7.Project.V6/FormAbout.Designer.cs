
namespace Tyuiu.MedvedevKA.Sprint7.Project.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_MKA = new System.Windows.Forms.PictureBox();
            this.labelAbout_MKA = new System.Windows.Forms.Label();
            this.buttonOK_MKA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_MKA
            // 
            this.pictureBoxAvatar_MKA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_MKA.Image")));
            this.pictureBoxAvatar_MKA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_MKA.Name = "pictureBoxAvatar_MKA";
            this.pictureBoxAvatar_MKA.Size = new System.Drawing.Size(140, 158);
            this.pictureBoxAvatar_MKA.TabIndex = 0;
            this.pictureBoxAvatar_MKA.TabStop = false;
            // 
            // labelAbout_MKA
            // 
            this.labelAbout_MKA.AutoSize = true;
            this.labelAbout_MKA.Location = new System.Drawing.Point(159, 13);
            this.labelAbout_MKA.Name = "labelAbout_MKA";
            this.labelAbout_MKA.Size = new System.Drawing.Size(290, 130);
            this.labelAbout_MKA.TabIndex = 1;
            this.labelAbout_MKA.Text = resources.GetString("labelAbout_MKA.Text");
            // 
            // buttonOK_MKA
            // 
            this.buttonOK_MKA.Location = new System.Drawing.Point(373, 147);
            this.buttonOK_MKA.Name = "buttonOK_MKA";
            this.buttonOK_MKA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_MKA.TabIndex = 2;
            this.buttonOK_MKA.Text = "Ок";
            this.buttonOK_MKA.UseVisualStyleBackColor = true;
            this.buttonOK_MKA.Click += new System.EventHandler(this.buttonOK_MKA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 181);
            this.Controls.Add(this.buttonOK_MKA);
            this.Controls.Add(this.labelAbout_MKA);
            this.Controls.Add(this.pictureBoxAvatar_MKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_MKA;
        private System.Windows.Forms.Label labelAbout_MKA;
        private System.Windows.Forms.Button buttonOK_MKA;
    }
}