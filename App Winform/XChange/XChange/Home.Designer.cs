﻿
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace XChange
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Statistique = new ListBox();
            ListeObjet = new ListBox();
            ListeEchange = new ListBox();
            ListeUtilisateur = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(738, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 2;
            label1.Text = "Rakoto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(699, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(12, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 478);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(283, 11);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 1;
            label2.Text = "Tableau de Bord";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Statistique, 0, 0);
            tableLayoutPanel1.Controls.Add(ListeObjet, 1, 0);
            tableLayoutPanel1.Controls.Add(ListeEchange, 1, 1);
            tableLayoutPanel1.Controls.Add(ListeUtilisateur, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(905, 428);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Statistique
            // 
            Statistique.ItemHeight = 15;
            Statistique.Items.AddRange(new object[] { "Bobo est là", "Bobo est là 2", "Bobo est là 3" });
            Statistique.Location = new Point(6, 6);
            Statistique.MultiColumn = true;
            Statistique.Name = "Statistique";
            Statistique.Size = new Size(442, 199);
            Statistique.TabIndex = 4;
            // 
            // ListeObjet
            // 
            ListeObjet.Font = new Font("Segoe UI", 12F);
            ListeObjet.ItemHeight = 21;
            ListeObjet.Location = new Point(457, 6);
            ListeObjet.Name = "ListeObjet";
            ListeObjet.Size = new Size(442, 193);
            ListeObjet.TabIndex = 5;
            ListeObjet.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // ListeEchange
            // 
            ListeEchange.Font = new Font("Segoe UI", 12F);
            ListeEchange.ItemHeight = 21;
            ListeEchange.Location = new Point(457, 218);
            ListeEchange.Name = "ListeEchange";
            ListeEchange.Size = new Size(442, 193);
            ListeEchange.TabIndex = 7;
            ListeEchange.SelectedIndexChanged += ListeEchange_SelectedIndexChanged;
            // 
            // ListeUtilisateur
            // 
            ListeUtilisateur.Font = new Font("Segoe UI", 12F);
            ListeUtilisateur.ItemHeight = 21;
            ListeUtilisateur.Location = new Point(6, 218);
            ListeUtilisateur.Name = "ListeUtilisateur";
            ListeUtilisateur.Size = new Size(442, 193);
            ListeUtilisateur.TabIndex = 6;
            ListeUtilisateur.SelectedIndexChanged += ListeUtilisateur_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(803, 14);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 3;
            label7.Text = "Se deconnecter";
            label7.Click += label7_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 526);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox Statistique;
        private ListBox ListeObjet;
        private ListBox ListeUtilisateur;
        private ListBox ListeEchange;
        private Form dialog;
        private System.Windows.Forms.Button oui;
        private System.Windows.Forms.Button non;
        private Label label7;
    }
}