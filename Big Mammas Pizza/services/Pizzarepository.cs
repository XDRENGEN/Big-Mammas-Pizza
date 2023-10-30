using Big_Mammas_Pizza.model;
using System.Text;

namespace Big_Mammas_Pizza.services
{
    public class PizzaRepository
    {
        // instans felt
        Dictionary<int, Pizza> _katalog;

        // properties
        public Dictionary<int, Pizza> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }

        // konstruktør
        public PizzaRepository(bool mockData = false)
        {
            _katalog = new Dictionary<int, Pizza>();


            if (mockData)
            {
                PopualtePizzaRepository();
            }
        }

        private void PopualtePizzaRepository()
        {
            _katalog.Clear();

            _katalog.Add(1, new Pizza(1,"Margherita","Tomato & cheese", 69));
            _katalog.Add(2, new Pizza(2, "Vesuvio", "Tomato, cheese & ham", 75));
            //_katalog.Add(3, new Pizza(3, ));
            //_katalog.Add(4, new Pizza(4,));
            //_katalog.Add(5, new Pizza(5,));

        }



        /*
         * metoder
         */
        public Pizza Tilføj(Pizza pizza)
        {
            _katalog.Add(pizza.PizzaNumber, pizza);

            return pizza;
        }

        public Pizza Slet(int PizzaNumber)
        {
            if (_katalog.ContainsKey(PizzaNumber))
            {
                Pizza slettetPizza = _katalog[PizzaNumber];
                _katalog.Remove(PizzaNumber);
                return slettetPizza;

            }
            else
            {
                return null;
            }
        }

        public Pizza HentPizza(int Pizzanumber)
        {
            if (_katalog.ContainsKey(Pizzanumber))
            {
                return _katalog[Pizzanumber];

            }
            else
            {
                // opdaget en fejl
                throw new KeyNotFoundException("Pizzanumber does not exist");



                //return null;
            }
        }

        public List<Pizza> HentAllePizzaer()
        {
            return _katalog.Values.ToList();
        }


       

        public override string ToString()
        {
            String pænTekst = String.Join(", ", _katalog.Values);

            return $"{{{nameof(Katalog)}={pænTekst}}}";
        }
    
}
}
