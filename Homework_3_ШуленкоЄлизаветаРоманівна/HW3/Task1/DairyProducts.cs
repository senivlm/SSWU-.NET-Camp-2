namespace Task1
{
    internal class DairyProducts : Product
    {        
        public DateTime? ExpirationDate { get; }

        public DairyProducts(string name, double price, double weight, DateTime expirationDate)
        {
            Name = name;
            Price = price;
            Weight = weight;
            ExpirationDate = expirationDate;
        }

        public override void ChangePrice(double percent)
        {
            base.ChangePrice(percent);

            if (DateTime.Now.Month - ExpirationDate.Value.Month > 2)
            {
                base.ChangePrice(-30);
            }
            else if (DateTime.Now.Month - ExpirationDate.Value.Month > 6)
            {
                base.ChangePrice(-15);
            }
            else if (DateTime.Now.Month - ExpirationDate.Value.Month > 12)
            {
                base.ChangePrice(-5);
            }
        }

        public override string ToString()
        {
            return $"ExpirationDate: {this.ExpirationDate}";
        }

        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                DairyProducts dp = (DairyProducts)obj;
                return (ExpirationDate == dp.ExpirationDate);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ExpirationDate);
        }
    }
}
