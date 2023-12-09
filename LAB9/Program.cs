try
{
    Console.WriteLine("ТОВАР");
    Console.WriteLine("Введите название товара: ");
    string name = Console.ReadLine();
    Console.WriteLine("Введите цену товара в рублях: ");
    decimal price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Введите год выпуска товара: ");
    int yearOfRelease = int.Parse(Console.ReadLine());
    Product product = new Product(name, price, yearOfRelease);
    int yearsAgo = product.YearsAgoReleased();
    Console.WriteLine($"Товар выпущен {yearsAgo} лет назад");
    product.IncreasePriceIfTV();
    Console.WriteLine($"Новая цена товара: {product.Price} рублей");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Product
{
    private string name;
    private decimal price;
    private int yearOfRelease;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }
    public int YearOfRelease
    {
        get { return yearOfRelease; }
        set { yearOfRelease = value; }
    }
    public Product(string name, decimal price, int yearOfRelease)
    {
        this.name = name;
        this.price = price;
        this.yearOfRelease = yearOfRelease;
    }
    public int YearsAgoReleased()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - yearOfRelease;
    }
    public void IncreasePriceIfTV()
    {
        if (Name.Contains("TV", StringComparison.OrdinalIgnoreCase))
        {
            price *= 1.2m;
        }
    }
}
