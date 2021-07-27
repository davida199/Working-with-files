using System.Globalization;
namespace Fixação
{
    class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Item(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double totalValue()
        {
            return price * quantity;
        }

        public override string ToString()
        {
            return name+", "+totalValue().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
