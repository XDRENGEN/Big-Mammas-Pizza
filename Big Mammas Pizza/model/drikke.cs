namespace Big_Mammas_Pizza.model
{
    public class drikke
    {
        /*
         * instans felter
         */

        private int _number;  
        private string _name;
        private string _price;
        private bool _alcoholic;

        /*
         * properties
         */

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool Alcoholic
        {
            get { return _alcoholic;}
            set { _alcoholic = value;}
        }

        /*
         * konstruktør 
         */

        public drikke()
        {
            _number = 0;
            _name = "";
        }


    }
}
