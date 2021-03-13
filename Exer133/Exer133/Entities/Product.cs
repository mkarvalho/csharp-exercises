namespace Exer133.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Pricetag()
        {
            return Name + " $ " + Price;
        }
    }
}
