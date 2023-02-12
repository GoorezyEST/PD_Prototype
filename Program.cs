namespace Prototype_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate a new drink object with brand "Pepsi" and price 15
            Drink pepsi = new Drink("Pepsi", 15);
            // create a clone of the drink object "pepsi" using the Clone method and assign it to anotherPepsi
            Drink? anotherPepsi = pepsi.Clone() as Drink;
        }

        // Abstract class Prototype which defines the Clone method
        public abstract class Prototype
        {
            public abstract Prototype Clone();
        }

        // Class Drink which implements the Prototype class
        public class Drink : Prototype
        {
            public string Brand { get; set; }
            public int Price { get; set; }

            // Constructor to initialize brand and price
            public Drink(string brand, int price)
            {
                Brand = brand;
                Price = price;
            }

            // Overriding the Clone method of Prototype class to return a new instance of Drink with same values of brand and price
            public override Prototype Clone()
            {
                return new Drink(Brand, Price);
            }
        }
    }
}