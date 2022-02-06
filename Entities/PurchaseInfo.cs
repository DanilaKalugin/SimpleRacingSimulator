namespace Entities
{
    public class PurchaseInfo
    {
        public string Model { get; private set; }
        public string TimeOfPurchase { get; private set; }
        public string OperationType { get; private set; }
        public int Balance { get; private set; }
        public int CollectorScore { get; private set; }

        public PurchaseInfo(string _model, string _timeOfPurchase, string _type, int _balance, int _collectorScore)
        {
            Model = _model;
            TimeOfPurchase = _timeOfPurchase;
            OperationType = _type;
            Balance = _balance;
            CollectorScore = _collectorScore;
        }
    }
}