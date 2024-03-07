namespace BotigaCistella
{
	public class Producte
	{
        //Atributs
        private string nom;
        private int preuSenseIva;
        private int iva;
        private int quantitat;

        //Constructors
        public Producte()
		{
            iva = 21;
            quantitat = 0;
		}
        public Producte(string nom, int preuInicial) : this()
        {
            this.nom = nom;
            preuSenseIva = preuInicial;
        }
        public Producte(string nom, int preuInicial, int iva, int quantitat)
        {
            this.nom = nom;
            preuSenseIva = preuInicial;
            this.iva = iva;
            this.quantitat = quantitat;
        }

        //Propietats
        //VALIDAR VALORS POSITIUS
        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }
        public int PreuSenseIva
        {
            set { preuSenseIva = value; }
            get { return preuSenseIva; }
        }
        public int Iva
        {
            set { iva = value; }
            get { return iva; }
        }
        public int Quantitat
        {
            set { quantitat = value; }
            get { return quantitat; }
        }

        //Metodes (publics)
        public int Preu()
        {
            int preu = iva / 100 + preuSenseIva;
            return preu;
        }

        public override string ToString()
        {
            return ;
        }
    }
}

