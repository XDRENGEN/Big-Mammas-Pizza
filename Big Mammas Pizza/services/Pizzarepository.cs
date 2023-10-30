﻿using Big_Mammas_Pizza.model;
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
            _katalog.Add(8, new Pizza(8, "Italiana", "tomato, cheese, onion & meetsauce", 75));
            _katalog.Add(9, new Pizza(9, "Gorgonzola", "Tomato, gorgonzola, onion and mushrooms", 85));
            _katalog.Add(10, new Pizza(10, "Contadina", "Tomato, cheese, mushrooms & olives", 75));
            _katalog.Add(11, new Pizza(11, "Naples", "Tomato, chreese, anchovies & olives", 79));
            _katalog.Add(12, new Pizza(12, "Vichinga", "Tomato, cheese, ham, mushrooms, peppers, garlic & chili (strong)" , 80));
            _katalog.Add(13, new Pizza(13, "Calzone Special", "(Not baked) tomato, cheese, shrimp, ham & meat sauce", 80));
            _katalog.Add(14, new Pizza(14, "Esotica", "Tomato, cheese, ham, shrimp & pineapple", 80));
            _katalog.Add(15, new Pizza(15, "Tonno", "Tomato, cheese, tuna & shrimp", 85));
            _katalog.Add(16, new Pizza(16, "Sardegna", "Tomato, cheese, cocktail sausages, bacon, onions & eggs", 80));
            _katalog.Add(17, new Pizza(17, "Romana", "Tomato, cheese,ham, bacon & onion", 78));
            _katalog.Add(18, new Pizza(18, "Sole", "Tomato, cheese, ham, bacon & eggs", 78));
            _katalog.Add(19, new Pizza(19, "Big Mamma", "Tomato, gorgonzola, shrimp, asparagus and parma ham", 90));

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
