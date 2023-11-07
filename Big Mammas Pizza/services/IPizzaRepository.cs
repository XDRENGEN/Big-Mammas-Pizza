using Big_Mammas_Pizza.model;

namespace Big_Mammas_Pizza.services
{
    public interface IPizzaRepository
    {
        public Dictionary<int, Pizza> Katalog { get; set; }

        List<Pizza> HentAllePizzaer();
        Pizza HentPizza(int pizzanummer);
        Pizza Opdater(Pizza pizza);
        Pizza Slet(int pizzanummer);
        Pizza Tilføj(Pizza pizza);
    }
}