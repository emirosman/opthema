namespace IMDB2
{
    partial class CastForm
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
            this.CastNameLabel = new System.Windows.Forms.Label();
            this.castBioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CastNameLabel
            // 
            this.CastNameLabel.AutoSize = true;
            this.CastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CastNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.CastNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CastNameLabel.Name = "CastNameLabel";
            this.CastNameLabel.Size = new System.Drawing.Size(57, 20);
            this.CastNameLabel.TabIndex = 0;
            this.CastNameLabel.Text = "label1";
            // 
            // castBioLabel
            // 
            this.castBioLabel.AutoSize = true;
            this.castBioLabel.Location = new System.Drawing.Point(13, 43);
            this.castBioLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.castBioLabel.Name = "castBioLabel";
            this.castBioLabel.Size = new System.Drawing.Size(35, 13);
            this.castBioLabel.TabIndex = 1;
            this.castBioLabel.Text = "label1";
            // 
            // CastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 450);
            this.Controls.Add(this.castBioLabel);
            this.Controls.Add(this.CastNameLabel);
            this.Name = "CastForm";
            this.Text = "CastForm";
            this.Load += new System.EventHandler(this.CastForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CastNameLabel;
        private System.Windows.Forms.Label castBioLabel;
    }
}