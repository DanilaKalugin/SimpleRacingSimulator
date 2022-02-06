namespace Entities
{
    public class User
    {
        public enum SortingType { Division, Manufacturer, Class, Year, Price, Country };
        public enum UnitsSystem { English, Metric };

        public bool IsAdmin { get; private set; }
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Country { get; private set; }
        public bool IsBlocked { get; private set; }
        public int Balance { get; private set; }
        public int CollectorLevel { get; private set; }
        public int CountOfCars { get; private set; }
        public SortingType DefaultSortingType { get; set; }
        public UnitsSystem DefaultUnitsSystem { get; set; }
        public int LastPurchasedCarID { get; set; }

        public User(string _name, string _login, bool _isAdmin, string _Country, bool _IsBlocked, SortingType type, UnitsSystem _defaultSystem, int _carId)
        {
            Login = _login;
            IsAdmin = _isAdmin;
            Name = _name;
            Country = _Country;
            IsBlocked = _IsBlocked;
            DefaultSortingType = type;
            DefaultUnitsSystem = _defaultSystem;
            LastPurchasedCarID = _carId;
        }

        public User(string _name, int _balance, int _level, string _country, bool _isBlocked, bool _IsAdmin, int _countOfCars)
        {
            Name = _name;
            Balance = _balance;
            CollectorLevel = _level;
            Country = _country;
            IsBlocked = _isBlocked;
            IsAdmin = _IsAdmin;
            CountOfCars = _countOfCars;
        }

    }
}