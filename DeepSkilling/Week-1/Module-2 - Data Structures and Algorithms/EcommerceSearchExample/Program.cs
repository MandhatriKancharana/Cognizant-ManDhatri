using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    
    static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }

        return null;
    }

    
    static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == targetId)
                return products[mid];

            if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Phone","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Bag","Fashion")
        };

        int searchId = 104;

        Console.WriteLine("Linear Search:");

        Product linearResult = LinearSearch(products, searchId);

        if (linearResult != null)
            Console.WriteLine($"Found: {linearResult.ProductName}");

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        Product binaryResult = BinarySearch(products, searchId);

        if (binaryResult != null)
            Console.WriteLine($"Found: {binaryResult.ProductName}");
    }
}