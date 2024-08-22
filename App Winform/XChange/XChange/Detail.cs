﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XChange.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace XChange
{
    public partial class Detail : Form
    {
        public Detail(string data)
        {
            InitializeComponent();
            try
            {
                string apiUrl = "http://referentiel.intranet.oma/api/objet/" + data;

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        InitializeComponent();
                        string apiResponse = response.Content.ReadAsStringAsync().Result;

                        List<Objet> objets = JsonConvert.DeserializeObject<List<Objet>>(apiResponse);
                        label4.Text = objets[0].nom;
                        label6.Text = objets[0].valeur.ToString();
                        label5.Text = objets[0].proprietaire.Username;
                        label9.Text = objets[0].description;
                    }
                    else
                    {
                        Console.WriteLine($"Erreur de l'API : {response.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home form2 = new Home();
            form2.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            dialog = new Form();
            dialog.Text = "Confirmation deconnexion";
            dialog.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = "Voulez-vous vraiment vous deconnecter?";
            label.AutoSize = true;
            label.Location = new Point(10, 10);
            dialog.Controls.Add(label);
            oui = new System.Windows.Forms.Button();
            oui.BackColor = Color.LightSteelBlue;
            oui.Location = new Point(10, 50);
            oui.Name = "oui_btn";
            oui.Size = new Size(93, 29);
            oui.TabIndex = 5;
            oui.Text = "Oui";
            oui.UseVisualStyleBackColor = false;
            oui.Click += (s, e) => { dialog.DialogResult = DialogResult.OK; dialog.Close(); };
            dialog.Controls.Add(oui);

            non = new System.Windows.Forms.Button();
            non.BackColor = Color.LightSteelBlue;
            non.Location = new Point(100, 50);
            non.Name = "non_btn";
            non.Size = new Size(93, 29);
            non.TabIndex = 5;
            non.Text = "Non";
            non.UseVisualStyleBackColor = false;
            non.Click += (s, e) => { dialog.DialogResult = DialogResult.Cancel; dialog.Close(); };
            dialog.Controls.Add(non);

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Connexion form3 = new Connexion();
                form3.Show();
                this.Hide();
            }
        }
    }
}
