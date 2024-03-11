namespace BotigaCistella
{
	public class Producte
	{
        //ATRIBUTS
        private string nom;
        private int preuSenseIva;
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
            get { return nom; } //VALIDAR VALORS POSITIUS
        }
        public int PreuSenseIva
        {
            set { preuSenseIva = value; }
            get { return preuSenseIva; } //VALIDAR VALORS POSITIUS
        }
        public int Iva
        {
            set { iva = value; }
            get { return iva; } //VALIDAR VALORS POSITIUS
        }
        public int Quantitat
        {
            set { quantitat = value; }
            get { return quantitat; } //VALIDAR VALORS POSITIUS
        }

        //METODES (PUBLICS)

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Preu()
        {
            int preu = iva / 100 + preuSenseIva;
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

