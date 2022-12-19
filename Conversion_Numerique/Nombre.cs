using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Numerique
{
    class Nombre
    {
        protected int baseNombre;
        protected int nombre;
        private int baseResultat;
        protected string nombreTxt;

        private string processus;

        public int BaseNombre { get => baseNombre; set => baseNombre = value; }
        public int Nbr { get => nombre; set => nombre = value; }
        public string NombreTxt { get => nombreTxt; set => nombreTxt = value; }
        public string Processus { get => processus; set => processus = value; }
        public virtual int BaseResultat { get => baseResultat; set => baseResultat = value; }

        public Nombre()
        {
            nombre = 0;
            nombreTxt = string.Empty;
            baseNombre = -1;
        }

        public Nombre(int nombre, int baseNombre)
        {
            this.baseNombre = baseNombre;
            this.nombre = nombre;
        }

        public Nombre(string nombreTxt, int baseNombre)
        {
            this.baseNombre = baseNombre;
            this.nombreTxt = nombreTxt;
        }
        public virtual string Binaire()
        {
            return null;
        }

        public virtual int Octal()
        {
            return 0;
        }
        public virtual int Decimal()
        {
            return 0;
        }
        public virtual string Hexadecimal()
        {
            return null;
        }
        public void DivisionProgressive(int baseCalcule)
        {
            int reponse = 0;
            int reste = 0;
            int nbr = nombre;

            this.processus = "";

            while (nbr >= baseCalcule)
            {
                reponse = nbr / baseCalcule;
                reste = nbr % baseCalcule;

                this.processus += string.Format(
                    "{0} ÷ {1} = {2} ; reste = {3}\r\n",
                    nbr, baseCalcule, reponse, reste);


                nbr = reponse;

            }

        }

        public virtual string MelangerResultat()
        {
           
            return string.Empty;
        }

        public virtual string Resultat()
        {

            return "Resultat en base ";
        }
        public virtual string GetResultatFinal()
        {
            return null;
        }
        public virtual string Convertir()
        {
            return null;
        }
        public virtual void VerifierType()
        {

        }

        public virtual void CalculerDePuissance(int baseCalcule)
        {
            if(this.nombreTxt.Length > 0)
            {
                processus = nombreTxt + $" en base {this.baseResultat} =  \r\n\r";
            }
           
            int compteur = 0;
            foreach(char bit in this.nombreTxt)
            {
                compteur++;
                this.processus += string.Format(
                    "{0} puissance {1} x {2} " + 
                    (compteur == nombreTxt.Length ? "=":"+") + " ", 
                    baseNombre, (nombreTxt.Length - compteur), bit);
            }

            processus += "\r\n\r\n\r";
            compteur = 0;

            foreach (char bit in this.nombreTxt)
            {
                compteur++;
                this.processus += string.Format(
                    "({0} * {1}) " +
                    (compteur == nombreTxt.Length ? "=" : "+") + " ",
                    Math.Pow(baseNombre, nombreTxt.Length - compteur), bit);
            }

            processus += "\r\n\r\n\r";
            compteur = 0;

            foreach (char bit in this.nombreTxt)
            {
                compteur++;
                this.processus += string.Format(
                    "{0}" +
                    (compteur == nombreTxt.Length ? "=" : "+") + " ",
                    Math.Pow(baseNombre, nombreTxt.Length - compteur) * int.Parse(bit.ToString()));
            }

        }
        /// <summary>
        ///     La methode caractereExposant(int) permet
        ///     de transformer un chiffre en indice exposant
        /// </summary>
        /// <param name="exposant"></param>
        public string caractereExposant(int exposant)
        {
            char[] unicode = new char[] { 
                '\u2070',
                '\u00B9',
                '\u00B2',
                '\u00B3',
                '\u2074',
                '\u2075',
                '\u2076',
                '\u2077',
                '\u2078',
                '\u2079' };

           
            char[] chiffre = exposant.ToString().ToCharArray();
            string index = "";


            foreach(char element in chiffre)
            {
                index += unicode[int.Parse(element.ToString())];
            }

            return index;

        }

    }
}
