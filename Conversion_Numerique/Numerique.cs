using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion_Numerique
{
    class Numerique
    {
        private int baseNombreConverti;


        protected int nombreConvertir;
        private int baseNombreAConvertir;

        private Nombre nombre;
        private string nombreAtraiter;

        private string resultat;
        private string finalResultat;
        
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseNombreAConvertir"></param>
        /// <param name="baseNombreConverti"></param>
        public Numerique(int baseNombreAConvertir, int baseNombreConverti)
        {
            this.baseNombreAConvertir = baseNombreAConvertir;
            this.baseNombreConverti = baseNombreConverti;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseNbrChoix1"></param>
        /// <param name="baseNbrChoix2"></param>
        public Numerique(string baseNbrChoix1, string baseNbrChoix2)
        {

            InitialisationBaseChoix1(baseNbrChoix1);
            InitialisationBaseChoix2(baseNbrChoix2);

            Initialisation(baseNombreConverti);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreTraiment"></param>
        /// <param name="baseNbrChoix1"></param>
        /// <param name="baseNbrChoix2"></param>
        public Numerique(string nombreTraiment, string baseNbrChoix1, string baseNbrChoix2)
        {
            this.nombreAtraiter = nombreTraiment;

            InitialisationBaseChoix1(baseNbrChoix1);
            InitialisationBaseChoix2(baseNbrChoix2);

            Initialisation(baseNombreConverti);
        }

        /// <summary>
        /// 
        /// </summary>
        public string Resultat { get => resultat; }
        public int BaseNombreConverti { get => baseNombreConverti; set => baseNombreConverti = value; }
        public int BaseNombreAConvertir { get => baseNombreAConvertir; set => baseNombreAConvertir = value; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseNbrChoix1"></param>
        public void InitialisationBaseChoix1(string baseNbrChoix1)
        {
            switch (baseNbrChoix1)
            {
                case "Binaire":
                    this.baseNombreConverti = 2;
                    break;
                case "Octal":
                    this.baseNombreConverti = 8;
                    break;
                case "Décimal":
                    this.baseNombreConverti = 10;
                    break;
                case "Héxadécimal":
                    this.baseNombreConverti = 16;
                    break;
                default:
                    MessageBox.Show("ERREUR SUR LA BASE");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseNbrChoix2"></param>
        public void InitialisationBaseChoix2(string baseNbrChoix2)
        {
            switch (baseNbrChoix2)
            {
                case "Binaire":
                    this.baseNombreAConvertir = 2;
                    break;
                case "Octal":
                    this.baseNombreAConvertir = 8;
                    break;
                case "Décimal":
                    this.baseNombreAConvertir = 10;
                    break;
                case "Héxadécimal":
                    this.baseNombreAConvertir = 16;
                    break;
                default:
                    MessageBox.Show("ERREUR SUR LA BASE");
                    break;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseNombre"></param>
        private void Initialisation(int baseNombre  )
        {
            switch (baseNombre)
            {

                case 2:

                    this.nombre = new Binaire(nombreAtraiter + "", baseNombre);
                    this.nombre.BaseResultat = this.baseNombreAConvertir;
                    this.nombre.VerifierType();
                    this.finalResultat = this.nombre.GetResultatFinal();

                    break;
                case 10:
                    int nombre = 0;
                    int.TryParse(nombreAtraiter, out nombre);
                    this.nombre = new Decimal(nombre, baseNombre);
                    this.nombre.BaseResultat = this.baseNombreAConvertir;
                    this.finalResultat = this.nombre.GetResultatFinal();
                    break;
                case 16:
                    this.nombre = new Hexadecimal(nombreAtraiter + "", baseNombre);
                    this.nombre.BaseResultat = this.baseNombreAConvertir;
                    this.nombre.VerifierType();
                    this.finalResultat = this.nombre.GetResultatFinal();
                    break;
            }
          
        }

        /// <summary>
        /// 
        /// </summary>
        public void traitementResultat()
        {
              this.resultat = nombre.Resultat();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>finalResultat</returns>
        public string FinalResultat() { return finalResultat;}
      

        

    }
}
