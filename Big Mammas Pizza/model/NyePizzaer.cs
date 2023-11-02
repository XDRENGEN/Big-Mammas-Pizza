namespace Big_Mammas_Pizza.model
{
    public class NyePizzaer
    {
        /*
         * Instans felter
         */
        private int _pizzaNummer;
        private string _navn;
        private string _ingredienser;

        /*
         * Properties
         */
        public int PizzaNummer
        {
            get { return _pizzaNummer; }
            set { _pizzaNummer = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Tlf
        {
            get { return _ingredienser; }
            set { _ingredienser = value; }
        }

        /*
         * Constructor
         */
        public NyePizzaer()
        {
            _pizzaNummer = 0;
            _navn = "";
            _ingredienser = "";
        }
        public NyePizzaer(int nr, string navn, string tlf)
        {
            _pizzaNummer = nr;
            _navn = navn;
            _ingredienser = tlf;
        }

        public override string ToString()
        {
            return $"{{{nameof(PizzaNummer)}={PizzaNummer}, {nameof(Navn)}={Navn}, {nameof(Ingredienser)}={Ingredienser}}}";
        }


    }
}
