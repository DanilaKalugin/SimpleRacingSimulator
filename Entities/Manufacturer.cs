namespace Entities
{
    public class Manufacturer
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string ShortTitle { get; set; }

        public Manufacturer(int _number, string _Name, string _Country, string _ShortTitle)
        {
            Number = _number;
            Title = _Name;
            Country = _Country;
            ShortTitle = _ShortTitle;
        }
    }
}