using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Numerique
{
    public partial class Convertisseur : Form
    {
        Numerique numerique;
        

        public ComboBox Choix1 { get => this.choix1; set => this.choix1 = value; }

        public Convertisseur()
        {
            
            InitializeComponent();
        }

        private void Convertisseur_Load(object sender, EventArgs e)
        {

            this.numerique = new Numerique(10,2);
            loadDataSelected();
            loadDataInput();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inverseBtn_Click(object sender, EventArgs e)
        {
            string tmp = this.choix1.Text;
            this.choix1.Text = this.choix2.Text;
            this.choix2.Text = tmp;

            tmp = this.champEntrer.Text;
            champEntrer.Text = numerique.FinalResultat();
            champResultat.Text = tmp;

            SaveSelected();

        }


        private void choix1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }


        private void choix1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.numerique = new Numerique(this.choix1.Text,this.choix2.Text);
            SaveSelected();
        }

        private void choix2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numerique = new Numerique(this.choix1.Text,this.choix2.Text);
            SaveSelected();
        }


        private void champEntrer_TextChanged(object sender, EventArgs e)
        {
            Traitement();
            SaveCalcule();
        }

        public void Traitement()
        {
            numerique = new Numerique(champEntrer.Text, this.choix1.Text, this.choix2.Text);
            numerique.traitementResultat();
            champResultat.Text = numerique.Resultat;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveSelected()
        {
            string data = choix1.Text + ',' + choix2.Text;
            string path = "../../../bdd/bddChoix.aml";
            File.WriteAllText(path, data);
        }
        public void SaveCalcule()
        {
           
            string path1 = "../../../bdd/bddEntrer.aml";
            string path2 = "../../../bdd/bddResultat.aml";
            File.WriteAllText(path1, champEntrer.Text);
            File.WriteAllText(path2, champResultat.Text);
        }

        /// <summary>
        /// La methode permet de lancer les comboBox 
        /// avec les derniers valeurs selectionnées.
        /// </summary>
        public void loadDataSelected()
        {
            string path = "../../../bdd/bddChoix.aml";
            string data = File.ReadAllText(path);
            string[] choix = data.Split(",");
            choix1.Text = choix[0];
            choix2.Text = choix[1];
        }

        public void loadDataInput()
        {
            string path1 = "../../../bdd/bddEntrer.aml";
            string path2 = "../../../bdd/bddResultat.aml";
            string data1 = File.ReadAllText(path1);
            string data2 = File.ReadAllText(path2);

            champEntrer.Text =data1;
            champResultat.Text = data2;
        }

    }
}
