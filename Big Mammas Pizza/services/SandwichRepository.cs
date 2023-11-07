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

                _katalog.Add(1, new Sandwich(65, "Pollo & Pancetta","Kylling, pancetta, rocula, ost & rød pesto", 69));
                _katalog.Add(2, new Sandwich(66, "Alla Contadina", "Marineret ovnbagt peberfrugt, aubergine, squash, mozzarella & rucola", 69));
                _katalog.Add(3, new Sandwich(67, "Gorgonzola", "Skinke, gorgonzola, champignon & løg", 69));
                _katalog.Add(4, new Sandwich(68, "Skinke", "Ost, skinke, champignon & løg", 69));
                _katalog.Add(5, new Sandwich(69, "Mortadella", "Ost, mortadella, champignon & løg", 69));
                _katalog.Add(6, new Sandwich(70, "Kødstrimler", "Ost, kødstrimler, champignon paprika", 69));
                _katalog.Add(7, new Sandwich(71, "Skinke & ost", "Skinke, ost, salat & dressing", 69));
                _katalog.Add(8, new Sandwich(72, "Tun", "Tun, salat & dressing", 69));
                _katalog.Add(9, new Sandwich(73, "Parma", "italiensk lufttørret skinke, Grana Padano & rucola", 70));
                _katalog.Add(10, new Sandwich(74, "Ventricina", "Ventricina (stærk salami), Grana Padano & rucola", 69));
               
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
                    Sandwich slettetSandwich = _katalog[SandwichNumber];
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
        
        public List<Sandwich> HentAlleSandwiches()
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
