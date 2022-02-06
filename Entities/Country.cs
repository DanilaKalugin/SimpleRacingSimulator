namespace Entities
{
    public class Country
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        public Country(string _code, string _name)
        {
            CountryCode = _code;
            CountryName = _name;
        }
    }
}