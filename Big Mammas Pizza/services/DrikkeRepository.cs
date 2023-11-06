using Big_Mammas_Pizza.model;
using System.Text;

namespace Big_Mammas_Pizza.services
{
    public class DrikkeRepository
    {
        // instans felt
        Dictionary<int, Drikke> _katalog;

        // properties
        public Dictionary<int, Drikke> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }

        // konstruktør
        public DrikkeRepository(bool mockData = false)
        {
            _katalog = new Dictionary<int, Drikke>();


            if (mockData)
            {
                PopualteDrikkeRepository();
            }
        }

        private void PopualteDrikkeRepository()
        {
            _katalog.Clear();

            _katalog.Add(1, new Drikke(1, "Water 0,5 L", 10, false));
            _katalog.Add(2, new Drikke(2, "Coca Cola 0,33 L", 15, false));
            _katalog.Add(4, new Drikke(3, "Fanta 0,33 L", 15, false));
            _katalog.Add(5, new Drikke(4, "Sprite 0,33 L", 15, false));
            _katalog.Add(6, new Drikke(5, "Coca Cola 0,5 L", 25, false));
            _katalog.Add(6, new Drikke(6, "Fanta 0,5 L", 25, false));
            _katalog.Add(6, new Drikke(7, "Sprite 0,5 L", 25, false));
            _katalog.Add(6, new Drikke(8, "Coca Cola 1,5 L", 35, false));
            _katalog.Add(6, new Drikke(9, "Fanta 1,5 L", 35, false));
            _katalog.Add(6, new Drikke(10, "Sprite 1,5 L", 35, false));
            _katalog.Add(6, new Drikke(11, "Ayran 0,33 L", 15, false));
            _katalog.Add(7, new Drikke(12, "Homemade lemonade 0,5 L", 25, false));
            _katalog.Add(8, new Drikke(13, "House wine 1,5 L", 90, true));
            _katalog.Add(9, new Drikke(14, "Beer 0,33 L", 17, true));

        }

        /*
         * metoder
         */
        public Drikke Tilføj(Drikke drikke)
        {
            _katalog.Add(drikke.Number, drikke);

            return drikke;
        }

        public Drikke Slet(int Number)
        {
            if (_katalog.ContainsKey(Number))
            {
                Drikke slettetDrikke = _katalog[Number];
                _katalog.Remove(Number);
                return slettetDrikke;

            }
            else
            {
                return null;
            }
        }

        public Drikke HentDrikke(int Number)
        {
            if (_katalog.ContainsKey(Number))
            {
                return _katalog[Number];

            }
            else
            {
                // opdaget en fejl
                throw new KeyNotFoundException("Drink does not exist");



                //return null;
            }
        }

        public List<Drikke> HentAlleDrikke()
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
