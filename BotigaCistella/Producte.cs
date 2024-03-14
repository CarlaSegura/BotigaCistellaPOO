namespace BotigaCistella
{
	public class Producte
	{
        //ATRIBUTS
        private string nom;
        private double preuSenseIva;
        private int iva;
        private int quantitat;

        //CONSTRUCTORS

        /// <summary>
        /// 
        /// </summary>
        public Producte()
		{
            iva = 21;
            quantitat = 0;
		}
        //Explica sempre el QUE FA,

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="preuInicial"></param>
        public Producte(string nom, int preuInicial) : this()
        {
            this.nom = nom;
            preuSenseIva = preuInicial;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="preuInicial"></param>
        /// <param name="iva"></param>
        /// <param name="quantitat"></param>
        public Producte(string nom, int preuInicial, int iva, int quantitat)
        {
            this.nom = nom;
            preuSenseIva = preuInicial;
            this.iva = iva;
            this.quantitat = quantitat;
        }

        //PROPIETATS

        public string Nom
        {
            set { nom = value; }
            get { return nom; } 
        }
        public double PreuSenseIva
        {
            set { if (preuSenseIva > 0) preuSenseIva=value; }
            get { return preuSenseIva; } 
        }
        public int Iva
        {
            set { if (iva > 0) iva = value; }
            get { return iva; } 
        }
        public int Quantitat
        {
            set { if (iva > 0) iva = value; }
            get { return quantitat; } 
        }

        //METODES (PUBLICS)

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double Preu()
        {
            double preu = iva / 100 + preuSenseIva;
            return preu;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Nom: {nom}\nPreu: {preuSenseIva}\nQuantitat: {quantitat}"; ;
        }
    }
}

