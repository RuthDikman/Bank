using bank.Entities;

namespace bank
{
    public class DataContext
    {
        public List<Customer> Customers { get; set; }
        public List<Official> Officials { get; set; }
        public List<Turns> Turns { get; set; }

        public DataContext() 
        {
            Customers = new List<Customer>();
            Officials = new List<Official>();
            Turns=new List<Turns>();
        }
    }
}
