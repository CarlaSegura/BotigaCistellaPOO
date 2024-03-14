namespace BotigaCistella
{
	public class Botiga
	{
        //ATRIBUTS

        private string nomBotiga;
        private Producte[] productes;
        private int nElements;

        //CONSTRUCTORS

        /// <summary>
        /// 
        /// </summary>
        public Botiga()
		{
            productes = new Producte[10];
            nElements = 0;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomBotiga"></param>
        /// <param name="nombreProductes"></param>
        public Botiga(string nomBotiga, int nombreProductes)
        {
            this.nomBotiga = nomBotiga;
            productes = new Producte[nombreProductes];
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public int Idexador(string nom)
        {
            int index = -1;
            for (int i = 0; i <= nElements; i++)
            {
                if (nom.Equals(productes[i].Nom))
                {
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="producte"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="producte"></param>
        /// <returns></returns>
        public bool BuscarProducte(Producte producte)
        {
            bool trobat = false;
            if (Idexador(producte.Nom) != -1)
            {
                trobat = true;
            }
            return trobat;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="producte"></param>
        /// <param name="nouNom"></param>
        /// <param name="nouPreu"></param>
        /// <param name="novaQuantitat"></param>
        /// <returns></returns>
        public bool ModificarProducte(Producte producte, string nouNom, double nouPreu, int novaQuantitat)
        {
            int index;
            bool trobat = false;
            if (Idexador(producte.Nom) != -1)
            {
                index = Idexador(producte.Nom);
                producte.Nom = nouNom;
                producte.PreuSenseIva = nouPreu;
                producte.Quantitat = novaQuantitat;
                trobat = true;
            }
            return trobat;
        }

        /// <summary>
        /// 
        /// </summary>
        public void OrdenarProducte()
        {
            int posicioMenor;
            for (int volta = 0; volta < nElements - 1; volta++)
            {
                posicioMenor = volta;
                for (int i = volta + 1; i < nElements; i++)
                {
                    if (productes[posicioMenor].Nom.CompareTo(productes[i].Nom) > 0) posicioMenor = i;
                }
                if (posicioMenor != volta)
                {
                    Producte aux = productes[posicioMenor];
                    productes[posicioMenor] = productes[volta];
                    productes[volta] = aux;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void OrdenarPreus()
        {
            int posicioMenor;
            for (int volta = 0; volta < nElements - 1; volta++)
            {
                posicioMenor = volta;
                for (int i = volta + 1; i < nElements; i++)
                {
                    if (productes[posicioMenor].PreuSenseIva > productes[i].PreuSenseIva) posicioMenor = i;
                }
                if (posicioMenor != volta)
                {
                    Producte aux = productes[posicioMenor];
                    productes[posicioMenor] = productes[volta];
                    productes[volta] = aux;
                }
            }
        }

        public void EsborrarProducte(Producte producte)
        {

        }

        public void Mostrar()
        {
            for (int i=0; i <= nElements; i++)
            {

            }
        }

        public override string ToString()
        {
            return 
        }
    }
}

