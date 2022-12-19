using System;
using System.Windows.Forms;

namespace Conversion_Numerique
{
    class Decimal : Nombre
    {
        string resultatFinal;
        public override int BaseResultat { get => base.BaseResultat; set => base.BaseResultat = value; }

        public Decimal():base()
        {
        }

        public Decimal(int nombre, int baseNombre) : base(nombre, baseNombre)
        {
        }

        public Decimal(string nombreTxt, int baseNombre) : base(nombreTxt, baseNombre)
        {
        }

        public override string Binaire()
        {
            return Convert.ToString(base.nombre, base.BaseResultat);
        }

        public override int Octal()
        {
            return int.Parse(Convert.ToString(base.nombre, base.BaseResultat)) ;
        }
        public override string Hexadecimal()
        {
            
            return (Convert.ToString(base.nombre, base.BaseResultat)).ToUpper();
        }

        public override string Convertir()
        {
            return 
                base.BaseResultat != 16 ? 
                Convert.ToString(base.nombre, base.BaseResultat) :
                Convert.ToString(base.nombre, base.BaseResultat).ToUpper();
        }

        public override string MelangerResultat()
        {
            DivisionProgressive(base.BaseResultat);
            Processus += "\r\n\rResultat : " + Convertir();

           
            return Processus;
        }

        public override string Resultat()
        {
            string resultat = string.Empty;

            if(base.BaseResultat == 2)
            {
                resultat = MelangerResultat();
            }
            else if(base.BaseResultat == 8)
            {
                resultat = MelangerResultat();
            }
            else if (base.BaseResultat == 16)
            {
                resultat = MelangerResultat();
            }
            else
            {
                resultat = base.nombre.ToString();
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
    }

}
