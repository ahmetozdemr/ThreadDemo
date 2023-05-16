namespace TheadExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            buttonlistBox = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            buttonProgres = new Button();
            progressBar1 = new ProgressBar();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(429, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 68);
            panel4.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 27);
            textBox1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(445, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 163);
            panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 110);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(buttonlistBox);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(31, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 201);
            panel2.TabIndex = 11;
            // 
            // buttonlistBox
            // 
            buttonlistBox.Location = new Point(28, 15);
            buttonlistBox.Name = "buttonlistBox";
            buttonlistBox.Size = new Size(176, 29);
            buttonlistBox.TabIndex = 3;
            buttonlistBox.Text = "ListBox Yazdır";
            buttonlistBox.UseVisualStyleBackColor = true;
            buttonlistBox.Click += buttonlistBox_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(28, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 144);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Controls.Add(buttonProgres);
            panel1.Controls.Add(progressBar1);
            panel1.Location = new Point(31, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 125);
            panel1.TabIndex = 10;
            // 
            // buttonProgres
            // 
            buttonProgres.Location = new Point(25, 25);
            buttonProgres.Name = "buttonProgres";
            buttonProgres.Size = new Size(227, 29);
            buttonProgres.TabIndex = 0;
            buttonProgres.Text = "Progres Bar Doldur";
            buttonProgres.UseVisualStyleBackColor = true;
            buttonProgres.Click += buttonProgres_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(25, 78);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(278, 29);
            progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox textBox1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button buttonlistBox;
        private ListBox listBox1;
        private Panel panel1;
        private Button buttonProgres;
        private ProgressBar progressBar1;
    }
}