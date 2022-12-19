using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Numerique
{
    class Binaire : Nombre 
    {
        public Binaire()
        {
        }

        public Binaire(int nombre, int baseNombre) : base(nombre, baseNombre)
        {
        }

        public Binaire(string nombreTxt, int baseNombre) : base(nombreTxt, baseNombre)
        {
            
        }
        public override void VerifierType()
        {
            if (VerifierBinaire(nombreTxt) is false)
            {
                base.nombreTxt = "";
                base.baseNombre = 0;
            }
        }

        public override int Octal()
        {
            return baseNombre;
        }

        public override int Decimal()
        {          
            return Somme();
        }
        public override string Hexadecimal()
        {
            if (base.nombreTxt.Length > 0)
            {
                FormDemiOctal();
                startStep();
                SeparerParQuatre();
            }
                
            
            return base.Processus;
        }
        public bool VerifierBinaire(string binaire)
        {
            foreach (char bit in binaire)
            {
                if (bit != '0' && bit != '1')
                {
                    return false;
                }
                    
            }
            return true;
        }

        public override string Resultat()
        {
            string resultat = ""; 

            if (base.BaseResultat == base.baseNombre)
            {
                FormDemiOctal();
                resultat = base.nombreTxt;
            }else if(base.BaseResultat == 8)
            {
                resultat = BinaireOctale();
            }

            else if (base.BaseResultat == 10)
            {
                resultat = BinaireEnDecimal();
            }
            else if (base.BaseResultat == 16)
            {
                
                resultat = Hexadecimal();
            }

            return resultat;
        }
        public override string GetResultatFinal()
        {
            if (base.BaseResultat == 2)
                return Binaire();
            else
                return string.Empty;
        }


        public string BinaireEnDecimal()
        {
            if(base.nombreTxt.Length> 0)
            {
                
                Etape1();
                Etape2();
                Etape3();
                base.Processus +=  Decimal();

            }
           
            return base.Processus;
        }
        
    
        private void startStep()
        {
            if (this.nombreTxt.Length > 0)
            {
                base.Processus = nombreTxt + $" en base {base.BaseResultat}  \r\n\r\nEtape 1\r\n";
            }
        }
        private void Etape1()
        {

            FormDemiOctal();
            startStep();
            int compteur = 0;
            foreach (char bit in this.nombreTxt)
            {
                compteur++;
                base.Processus += string.Format(
                    "{0}{1} x {2} " +
                    (compteur == nombreTxt.Length ? "" : "+") + " ",
                    baseNombre, caractereExposant( (nombreTxt.Length - compteur)), bit);
            }

        }
       
        private void Etape2()
        {
            base.Processus += "\r\n\r\nEtape 2\r\n";
            int compteur = 0;

            foreach (char bit in this.nombreTxt)
            {
                compteur++;
                base.Processus += string.Format(
                    "({0} x {1}) " +
                    (compteur == nombreTxt.Length ? "" : "+") + " ",
                    Math.Pow(baseNombre, nombreTxt.Length - compteur), bit);
            }
        }
   
        private void Etape3()
        {
            base.Processus += "\r\n\r\nEtape 3\r\n";
            int compteur = 0;

            foreach (char bit in this.nombreTxt)
            {
                compteur++;
                base.Processus += string.Format(
                    "{0}" +
                    (compteur == nombreTxt.Length ? "\r\n\r\nResultat\r\n-------\r\n" : "+") + " ",
                    Math.Pow(baseNombre, nombreTxt.Length - compteur) * int.Parse(bit.ToString()));
            }
        }


        private int Somme()
        {
            base.Processus += "\r\n\r\nResultat\r\n\r\n";
            int compteur = 0;
            int somme = 0;
            foreach (char bit in this.nombreTxt)
            {
                compteur++;
                somme += (int)Math.Pow(baseNombre, nombreTxt.Length - compteur) * int.Parse(bit.ToString());
            }

            return somme;
        }

        public string BinaireOctale()
        {
            if(base.NombreTxt.Length > 0)
            {
                FormDemiOctal();
                startStep();
                CompleteZeroPourOctal();
                SeparerParTrois();
            }
            
            return base.Processus;
        }

        private void CompleteZeroPourOctal()
        {
            
            int taille = nombreTxt.Length;
            string str = "";

            while (taille % 3 != 0)
            {
                str += "0";
                taille++;
            }

            base.nombreTxt = str + base.nombreTxt;

        }

        private void FormDemiOctal()
        {

            int taille = nombreTxt.Length;
            string str = "";

            while (taille % 4 != 0)
            {
                str += "0";
                taille++;
            }

            base.nombreTxt = str + base.nombreTxt;

        }

        private void SeparerParTrois()
        {
            string[] partiNombre = new string[base.nombreTxt.Length / 3];
            int go = 0;
            for(int i = 0; i < partiNombre.Length; i++)
            {
                partiNombre[i] = base.nombreTxt.Substring(go, 3);
                go += 3;
            }

            foreach(string str in partiNombre)
            {
                calculeOctal(str);
            }
            base.Processus += "\r\n\r\nEtape 2\r\n";
            
                calculeOctal2(partiNombre);
            


        }

        private void SeparerParQuatre()
        {
            string[] partiNombre = new string[base.nombreTxt.Length / 4];
            int go = 0;
            for (int i = 0; i < partiNombre.Length; i++)
            {
                partiNombre[i] = base.nombreTxt.Substring(go, 4);
                go += 4;
            }

            foreach (string str in partiNombre)
            {
                calculeHexadecimal(str);
            }
            base.Processus += "\r\n\r\nEtape 2\r\n";

            calculeHexadecimal2(partiNombre);



        }

        private void calculeOctal(string bin)
        {
            int trace = 4;
            foreach(char c in bin)
            {
                base.Processus += string.Format("{0} x {1}   ", c, trace);
                trace /= 2;
            }
            


        }

        private void calculeOctal2(string [] nombreParti )
        {
            string resultat = "";
            string resultat2 = "";
            
            
            foreach(string bin in nombreParti)
            {
                resultat += "(";
                int trace = 4;
                int i = 0;
                foreach (char c in bin)
                {
                    resultat += string.Format(" {0} " + (i == 2?"":"+"), int.Parse(c.ToString()) * trace);
                    trace /= 2;
                    i++;
                }
                resultat += ") ";

                trace = 4;
                 i = 0;
                foreach (char c in bin)
                {
                    resultat2 += string.Format("{0}", int.Parse(c.ToString()) * trace);
                    trace /= 2;
                    i++;
                }

            }

            base.Processus += resultat;

            base.Processus += "\r\n\r\nResultat\r\n";

            base.Processus += (resultat2.Replace("0",""));
        }



        private void calculeHexadecimal(string bin)
        {
            int trace = 8;
            foreach (char c in bin)
            {
                base.Processus += string.Format("{0} x {1}   ", c, trace);
                trace /= 2;
            }

        }

        private void calculeHexadecimal2(string[] nombreParti)
        {
            string resultat = "";
            string resultat2 = "";
            string[] hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string resultat3 = "";


            foreach (string bin in nombreParti)
            {
                resultat += "(";
                int trace = 8;
                int i = 0;
                foreach (char c in bin)
                {
                    resultat += string.Format(" {0} " + (i == 3 ? "" : "+"), int.Parse(c.ToString()) * trace);
                    trace /= 2;
                    i++;
                }
                resultat += ") ";

                trace = 8;
                i = 0;
                foreach (char c in bin)
                {
                    resultat2 += string.Format("{0}", int.Parse(c.ToString()) * trace);
                    trace /= 2;
                    i++;
                }

            }

            base.Processus += resultat;

            base.Processus += "\r\n\r\nEtape 3\r\n";

            foreach (string bin in nombreParti)
            {
                int trace = 8;
                int i = 0;
                int somme = 0;
                
                foreach (char c in bin)
                {
                    somme += int.Parse(c.ToString()) * trace;
                    trace /= 2;
                    i++;
                }

                base.Processus += "Hex("+somme +") = "+ hex[somme] +"\r\n";
            }

            base.Processus += resultat3;
            base.Processus += "\r\nResultat\r\n";

            foreach (string bin in nombreParti)
            {
                int trace = 8;
                int i = 0;
                int somme = 0;

                foreach (char c in bin)
                {
                    somme += int.Parse(c.ToString()) * trace;
                    trace /= 2;
                    i++;
                }
                resultat3 += hex[somme];
            }

            base.Processus += resultat3;
        }

        


    }   
}
