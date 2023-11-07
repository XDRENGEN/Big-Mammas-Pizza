using Big_Mammas_Pizza.model;
using System.Text.Json;

namespace Big_Mammas_Pizza.services
{
    public class PizzaRepositoryJson : IPizzaRepository
    {
        // instans felt
        Dictionary<int, Pizza> _katalog;
        private object pizza;

        // properties
        public Dictionary<int, Pizza> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }

        // konstruktør
        public PizzaRepositoryJson()
        {
            _katalog = ReadFromJson();
        }



        /*
         * metoder
         */
        public Pizza Tilføj(Pizza pizza)
        {
            if (!_katalog.ContainsKey(pizza.PizzaNumber))
            {
                _katalog.Add(pizza.PizzaNumber, pizza);


                WriteToJson();
                return pizza;
            }

            throw new ArgumentException($"PizzaNummer {pizza.PizzaNumber} findes i forvejen");
        }

        public Pizza Slet(int pizzanummer)
        {
            Pizza slettetPizza = HentPizza(pizzanummer);
            _katalog.Remove(pizzanummer);

            WriteToJson();
            return slettetPizza;
        }

        public Pizza Opdater(Pizza pizza)
        {
            Pizza editKunde = HentPizza(pizza.PizzaNumber);
            _katalog[pizza.PizzaNumber] = pizza;


            WriteToJson();
            return pizza;
        }



        public Pizza HentPizza(int pizzanummer)
        {
            if (_katalog.ContainsKey(pizzanummer))
            {
                return _katalog[pizzanummer];
            }
            else
            {
                // opdaget en fejl
                throw new KeyNotFoundException($"pizzanumber {pizzanummer} findes ikke");
            }
        }

        public List<Pizza> HentAllePizzaer()
        {
            return _katalog.Values.ToList();
        }

        //public Pizza HentPizzaUdFraTlf(string tlf)
        //{
        //    Pizza resKunde = null;

        //    foreach (Pizza p in _katalog.Values)
        //    {
        //        if (p.Tlf == tlf)
        //        {
        //            return p;
        //        }
        //    }

        //    return resPizza;
        //}

        public override string ToString()
        {
            String pænTekst = String.Join(", ", _katalog.Values);

            return $"{{{nameof(Katalog)}={pænTekst}}}";
        }


        /*
         * Hjælpe metoder til at læse og skrive til en fil i json format
         */

        private const string FILENAME = "PizzaRepository.json";

        private Dictionary<int, Pizza> ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {
                StreamReader reader = File.OpenText(FILENAME);
                Dictionary<int, Pizza> katalog = JsonSerializer.Deserialize<Dictionary<int, Pizza>>(reader.ReadToEnd());
                reader.Close();
                return katalog;
            }
            else
            {
                return new Dictionary<int, Pizza>();
            }

        }

        private void WriteToJson()
        {
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            Utf8JsonWriter writer = new Utf8JsonWriter(fs);
            JsonSerializer.Serialize(writer, _katalog);
            fs.Close();
        }



    }
}
