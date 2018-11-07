namespace IMDB2
{
    partial class Form1
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.castComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.Text = "matrix";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Maroon;
            this.HeadLabel.Location = new System.Drawing.Point(209, 9);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(0, 25);
            this.HeadLabel.TabIndex = 2;
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(12, 38);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(186, 160);
            this.moviesListBox.TabIndex = 3;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(211, 38);
            this.DescLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(0, 13);
            this.DescLabel.TabIndex = 4;
            // 
            // castComboBox
            // 
            this.castComboBox.FormattingEnabled = true;
            this.castComboBox.Location = new System.Drawing.Point(446, 38);
            this.castComboBox.Name = "castComboBox";
            this.castComboBox.Size = new System.Drawing.Size(121, 21);
            this.castComboBox.TabIndex = 5;
            this.castComboBox.Visible = false;
            this.castComboBox.SelectedIndexChanged += new System.EventHandler(this.castComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 312);
            this.Controls.Add(this.castComboBox);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.moviesListBox);
            this.Controls.Add(this.HeadLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.ComboBox castComboBox;
    }
}

