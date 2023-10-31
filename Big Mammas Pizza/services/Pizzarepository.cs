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
            _katalog.Add(3, new Pizza(3, "Capricciosa", "Tomato, cheese, ham and mushrooms", 80));
            _katalog.Add(4, new Pizza(4, "Calzone", "Baked pizza with tomato, cheese, ham and mushrooms", 80));
            _katalog.Add(5, new Pizza(5, "Quattro Stagioni", "Tomato, cheese, ham, mushrooms, shrimp and peppers", 85));
            _katalog.Add(6, new Pizza(6, "Marinara", "Tomato, cheese, shrimps, mussels and garlic", 85));
            _katalog.Add(7, new Pizza(7, "Vegetarian", "Tomato, cheese and vegestables", 80));
            _katalog.Add(8, new Pizza(8, "Italiana", "Tomato, cheese, onion & meetsauce", 75));
            _katalog.Add(9, new Pizza(9, "Gorgonzola", "Tomato, gorgonzola, onion and mushrooms", 85));
            _katalog.Add(10, new Pizza(10, "Contadina", "Tomato, cheese, mushrooms & olives", 75));
            _katalog.Add(11, new Pizza(11, "Naples", "Tomato, cheese, anchovies & olives", 79));
            _katalog.Add(12, new Pizza(12, "Vichinga", "Tomato, cheese, ham, mushrooms, peppers, garlic & chili (strong)" , 80));
            _katalog.Add(13, new Pizza(13, "Calzone Special", "(Not baked) tomato, cheese, shrimp, ham & meat sauce", 80));
            _katalog.Add(14, new Pizza(14, "Esotica", "Tomato, cheese, ham, shrimp & pineapple", 80));
            _katalog.Add(15, new Pizza(15, "Tonno", "Tomato, cheese, tuna & shrimp", 85));
            _katalog.Add(16, new Pizza(16, "Sardegna", "Tomato, cheese, cocktail sausages, bacon, onions & eggs", 80));
            _katalog.Add(17, new Pizza(17, "Romana", "Tomato, cheese,ham, bacon & onion", 78));
            _katalog.Add(18, new Pizza(18, "Sole", "Tomato, cheese, ham, bacon & eggs", 78));
            _katalog.Add(19, new Pizza(19, "Big Mamma", "Tomato, gorgonzola, shrimp, asparagus and parma ham", 90));
            _katalog.Add(20, new Pizza(20, "La Salami", "Tomato, cheese, salami & ham", 92));
            _katalog.Add(21, new Pizza(21, "Rocco", "Tomato, cheese, beef strips, onion & garlic", 95));
            _katalog.Add(22, new Pizza(22, "Marco", "Tomato, cheese, ham, mushroom, onion & meet strips", 95));
            _katalog.Add(23, new Pizza(23, "Kokkode", "(New) tomato, cheese, chicken fillet, peas, pancetta (italien bacon)", 95));
            _katalog.Add(24, new Pizza(24, "Antonello", "Tomato, cheese, pepperoni, meetsauce, cocktail sausages & onion", 95));
            _katalog.Add(25, new Pizza(25, "Pasqualino", "Tomato, cheese, pepperoni & pineapple", 99));
            _katalog.Add(26, new Pizza(26, "Felix", "Tomato, cheese & pepperoni", 89));
            _katalog.Add(27, new Pizza(27, "Bambino", "Ham/cheese or pepperoni/cheese or meat sauce/cheese with Nutella", 63));

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
