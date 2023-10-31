using Big_Mammas_Pizza.model;

namespace Big_Mammas_Pizza.services
{
    public class SandwichRepository
    {
     // instans felt
            Dictionary<int, Sandwich> _katalog;

            // properties
            public Dictionary<int, Sandwich> Katalog
            {
                get { return _katalog; }
                set { _katalog = value; }
            }

            // konstruktør
            public SandwichRepository(bool mockData = false)
            {
                _katalog = new Dictionary<int, Sandwich>();


                if (mockData)
                {
                    PopualteSandwichRepository();
                }
            }

            private void PopualteSandwichRepository()
            {
                _katalog.Clear();

                _katalog.Add(1, new Sandwich(1, "Margherita", "Tomato & cheese", 69));
                _katalog.Add(2, new Sandwich(2, "Vesuvio", "Tomato, cheese & ham", 75));
                _katalog.Add(3, new Sandwich(3, "Capricciosa", "Tomato, cheese, ham and mushrooms", 80));
                _katalog.Add(4, new Sandwich(4, "Calzone", "Baked pizza with tomato, cheese, ham and mushrooms", 80));
                _katalog.Add(5, new Sandwich(5, "Quattro Stagioni", "Tomato, cheese, ham, mushrooms, shrimp and peppers", 85));
                _katalog.Add(6, new Sandwich(6, "Marinara", "Tomato, cheese, shrimps, mussels and garlic", 85));
                _katalog.Add(7, new Sandwich(7, "Vegetarian", "Tomato, cheese and vegestables", 80));
                _katalog.Add(8, new Sandwich(8, "Italiana", "tomato, cheese, onion & meetsauce", 75));
                _katalog.Add(9, new Sandwich(9, "Gorgonzola", "Tomato, gorgonzola, onion and mushrooms", 85));
                _katalog.Add(10, new Sandwich(10, "Contadina", "Tomato, cheese, mushrooms & olives", 75));
                _katalog.Add(11, new Sandwich(11, "Naples", "Tomato, cheese, anchovies & olives", 79));
                _katalog.Add(12, new Sandwich(12, "Vichinga", "Tomato, cheese, ham, mushrooms, peppers, garlic & chili (strong)", 80));
                _katalog.Add(13, new Sandwich(13, "Calzone Special", "(Not baked) tomato, cheese, shrimp, ham & meat sauce", 80));
                _katalog.Add(14, new Sandwich(14, "Esotica", "Tomato, cheese, ham, shrimp & pineapple", 80));
                _katalog.Add(15, new Sandwich(15, "Tonno", "Tomato, cheese, tuna & shrimp", 85));
                
            }



            /*
             * metoder
             */
            public Sandwich Tilføj(Sandwich sandwich)
            {
                _katalog.Add(sandwich.SandwichNumber, sandwich);

                return sandwich;
            }

            public Sandwich Slet(int SandwichNumber)
            {
                if (_katalog.ContainsKey(SandwichNumber))
                {
                    Pizza slettetSandwich = _katalog[SandwichNumber];
                    _katalog.Remove(SandwichNumber);
                    return slettetSandwich;

                }
                else
                {
                    return null;
                }
            }

            public Sandwich HentSandwich(int Sandwichnumber)
            {
                if (_katalog.ContainsKey(Sandwichnumber))
                {
                    return _katalog[Sandwichnumber];

                }
                else
                {
                    // opdaget en fejl
                    throw new KeyNotFoundException("Sandwichnumber does not exist");



                    //return null;
                }
            }

            public List<Pizza> HentAlleSandwiches()
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
