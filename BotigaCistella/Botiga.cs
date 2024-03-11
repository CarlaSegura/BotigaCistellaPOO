namespace BotigaCistella
{
	public class Botiga
	{
        //ATRIBUTS
        private string nomBotiga;
        private int[] productes;
        private int nElements;

        //CONSTRUCTORS
        public Botiga()
		{
            productes = new int[10];
            nElements = 0;
		}

        public Botiga(string nomBotiga, int producte)
        {
            this.nomBotiga = nomBotiga;
            productes = producte;
        }

        public Botiga():this()
        {
            
        }

        //PROPIETATS
        public string NomBotiga
        {
            set { nomBotiga = value; }
            get { return nomBotiga; }
        }
        public int[] Productes
        {
            set { productes = value; }
            get { return productes; } 
        }
        public int NElements
        {
            set { nElements = value; }
            get { return nElements; } 
        }

        //METODES
        public int EspaiLliure()
        {

        }

        public int AfegirProducte(Producte producte)
        {

        }

        public int AfegirProducte(Producte[] productes)
        {

        }

        public int AmpliarBotiga(int num)
        {

        }

        public int ModificarPreu(string producte, double preu)
        {

        }

        public int BuscarProducte(Producte producte)
        {

        }

        public int ModificarProducte(Producte producte, String nouNom, double nouPreu, int novaQuantitat)
        {

        }

        public int OrdenarProducte()
        {

        }
        public int OrdenarPreus()
        {

        }
        public int Mostrar()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

