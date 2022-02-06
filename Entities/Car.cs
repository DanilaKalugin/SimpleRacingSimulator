namespace Entities
{
    public class Car
    {
        public int Year;
        public string manufacturer;
        public string Model;
        public string Division;
        public int Price;
        public float Speed;
        public float Handling;
        public float Acceleration;
        public float Brake;
        public int Power;
        public int Torque;
        public int Weight;
        public int Front;
        public string Drive;
        public string EnginePlacement;
        public int PI;
        public bool WasBought { get; set; }
        public bool IsFE { get; set; }
        public string CollectionTier;
        public int CollectionPoints;
        public string ShortTitle;
        public int ImageNumber { get; set; }
        public double PowerToWeight()
        {
            return Power / (double)Weight;
        }
        public char carClass()
        {
                if (PI == 999)
                {
                    return 'X';
                }
                if (PI > 900 && PI < 999)
                {
                    return 'P';
                }
                if (PI > 800 && PI <= 900)
                {
                    return 'R';
                }
                if (PI > 700 && PI <= 800)
                {
                    return 'S';
                }
                if (PI > 600 && PI <= 700)
                {
                    return 'A';
                }
                if (PI > 500 && PI <= 600)
                {
                    return 'B';
                }
                if (PI > 400 && PI <= 500)
                {
                    return 'C';
                }
                if (PI > 300 && PI <= 400)
                {
                    return 'D';
                }
                if (PI >= 100 && PI <= 300)
                {
                    return 'E';
                }
                else return ' ';
        }

        public Car(int _year, string _manufacturer, string _model, string _division, int _price, float _spped, 
                   float _handling, float _acceleration, float _brake, int _power, int _torque, int _weight, 
                   int _front, int _performance, string _drive, string _enginePlace, bool _Bought, string _tier, 
                   int _points, string _shortTitle, bool _fe, int _number)
        {
            Year = _year;
            manufacturer = _manufacturer;
            Model = _model;
            Division = _division;
            Price = _price;
            Speed = _spped;
            Handling = _handling;
            Acceleration = _acceleration;
            Brake = _brake;
            Power = _power;
            Torque = _torque;
            Weight = _weight;
            Front = _front;
            Drive = _drive;
            EnginePlacement = _enginePlace;
            PI = _performance;
            WasBought = _Bought;
            CollectionTier = _tier;
            CollectionPoints = _points;
            ShortTitle = _shortTitle;
            IsFE = _fe;
            ImageNumber = _number;
        }
    }
}