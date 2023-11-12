namespace bank.Entities
{
    public class Turns
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Official Official { get; set; }
        public Customer Customer { get; set; }
    }
}
