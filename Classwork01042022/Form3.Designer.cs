
namespace Classwork01042022
{
    partial class Skrimerform
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
            this.pictureBoxSkrimer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkrimer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSkrimer
            // 
            this.pictureBoxSkrimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSkrimer.Image = global::Classwork01042022.Properties.Resources.youdied;
            this.pictureBoxSkrimer.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSkrimer.Name = "pictureBoxSkrimer";
            this.pictureBoxSkrimer.Size = new System.Drawing.Size(1137, 618);
            this.pictureBoxSkrimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSkrimer.TabIndex = 0;
            this.pictureBoxSkrimer.TabStop = false;
            // 
            // Skrimerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 618);
            this.Controls.Add(this.pictureBoxSkrimer);
            this.Name = "Skrimerform";
            this.Text = "Skrimer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkrimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSkrimer;
    }
}