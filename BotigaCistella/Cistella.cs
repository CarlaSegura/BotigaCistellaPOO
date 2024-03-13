using System;
namespace BotigaCistella
{
	public class Cistella
	{
        //ATRIBUTS
        private Botiga botiga;
        private DateTime data;
        private Producte[] productes;
        private int quantitat;
        private int nElements;
        private int diners;

        //CONSTRUCTORS
        public Cistella()
		{
            botiga = null;
            productes = new Producte[10];
            nElements = 0;
            diners = 0;
        }

        public Cistella()
        {

        }


        //PROPIETATS
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

        public int Diners
        {
            set { diners = value; }
            get { return diners; }
        }

        public DateTime Data
        {
            set { data = value; }
            get { return data; }
        }

        public void ComprarProducte(Producte producte, int quantitat)
        {

        }

        public void ComprarProducte(Producte[] productes, int[] quantitats)
        {

        }

        public void OrdernarCistella()
        {

        }

        public void Mostra()
        {

        }

        public void CostTotal()
        {

        }

        public void ToString()
        {

        }
    }
}

