using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Numerique
{
    class Hexadecimal : Nombre
    {
        public Hexadecimal(string nombreTxt, int baseNombre) : base(nombreTxt.ToUpper(), baseNombre)
        {
        }

        public override string Binaire()
        {
            startStep();

            if (nombreTxt.Length > 0)

                base.Processus += "\r\n\r\nResultat\r\n" + Transformation(Decomposition());
            else

                base.Processus = "";
           

            return base.Processus;
        }

        public override int Octal()
        {
            return 0;
        }

        public override int Decimal()
        {
            return 0;
        }

        public override void VerifierType()
        {
            if (VerifierHexadecimal(nombreTxt) is false)
            {
                base.nombreTxt = "";
                base.baseNombre = 0;
            }
        }

        public bool VerifierHexadecimal(string hex)
        {
            bool presence = false;
            char[] tableHex = new char[]
            {
                '0', '1', '2', '3', 
                '4', '5', '6', '7',
                '8', '9', 'A', 'B',
                'C', 'D', 'E', 'F'
            };

            foreach (char element in hex)
            {
                presence = false;

               foreach(char index in tableHex)
                {
                    if (element == index)
                    {
                        presence = true;
                    }   
                }

               if(presence is false)
                {
                    break;
                }

            }

            return presence;
        }

        public override string MelangerResultat()
        {
            base.Processus += "\r\n\r\nResultat\r\n"; 
            

            if (base.BaseResultat == 2)
            {
                base.Processus += Transformation(Decomposition());
            }


            return Processus;
        }
        public override string Resultat()
        {
            string resultat = "";

            if (base.BaseResultat == base.baseNombre)
            {
                resultat = base.nombreTxt;
            }
            else
            {
                resultat = MelangerResultat();
            } 
               
            


            return resultat;
        }

        private string [] Decomposition()
        {
            char[] valeurs = nombreTxt.ToCharArray();
            string[] valeursString = new string[valeurs.Length];

            for(int i = 0; i < valeurs.Length; i++)
            {
                valeursString[i] = valeurs[i].ToString();
            }

            Replace(valeursString);

            for (int i = 0; i < valeurs.Length; i++)
            {
                base.Processus += $"Dec({valeurs[i]}) == > {valeursString[i]}\r\n";
            }
            

            return valeursString;
        }

        private void startStep()
        {
            base.Processus = nombreTxt + $" en base {base.BaseResultat}  \r\n\r\nEtape 1\r\n";
        }

        private string Transformation(string [] valeursArray)
        {
            string binaire = "";
            string tmp = "";

            foreach(string element in valeursArray)
            {
                tmp = Convert.ToString(int.Parse(element), base.BaseResultat);
                tmp = FormDemiOctal(tmp);
                binaire += tmp;
            }
            
            return binaire ;
        }

        private string  FormDemiOctal(string chaine)
        {

            int taille = chaine.Length;
            string str = "";

            while (taille % 4 != 0)
            {
                str += "0";
                taille++;
            }

            chaine = str + chaine;

            return chaine;
        }

        private void Replace(string[] valeurs)
        {
            base.Processus +="\r\n\r\nEtape 2\r\n";
            for (int i = 0; i < valeurs.Length; i++)
            {
                valeurs[i] = valeurs[i].Replace("A", "10");
                valeurs[i] = valeurs[i].Replace("B", "11");
                valeurs[i] = valeurs[i].Replace("C", "12");
                valeurs[i] = valeurs[i].Replace("D", "13");
                valeurs[i] = valeurs[i].Replace("E", "14");
                valeurs[i] = valeurs[i].Replace("F", "15");
            }

           
        }
    }
}
