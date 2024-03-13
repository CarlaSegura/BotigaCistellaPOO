namespace BotigaCistella
{
	public class Botiga
	{
        //ATRIBUTS
        private string nomBotiga;
        private Producte[] productes;
        private int nElements;

        //CONSTRUCTORS
        public Botiga()
		{
            productes = [10];
            nElements = 0;
		}

        public Botiga(string nomBotiga, int nombreProductes)
        {
            this.nomBotiga = nomBotiga;
            Producte[nombreProductes];
            nElements = 0;
        }

        public Botiga()
        {
            
        }

        //PROPIETATS
        public string NomBotiga
        {
            set { nomBotiga = value; }
            get { return nomBotiga; }
        }
        public Producte[] Productes
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
            if (productes.Length == nElements)
            {
                return -1;
            }
            else
            {
                return nElements + 1;
            }
        }

        public void Idexador()
        {

        }

        public bool AfegirProducte(Producte producte)
        {
            if (nElements == productes.Length)
            {
                Console.WriteLine("La botiga esta plena");
                return false;
            }
            else
            {
                nElements++;
                productes[nElements] = producte;
                return true;
            }
        }

        public int AfegirProducte(Producte[] productes)
        {

        }

        public void AmpliarBotiga(int num)
        {
            Producte[] novaTaula = new Producte[productes.Length + num];

            Array.Copy(productes, novaTaula, productes.Length);

            productes = novaTaula;
        }

        public int ModificarPreu(string producte, double preu)
        {
            for(int i = 0; i <= nElements; i++)
            {
               
            }
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

