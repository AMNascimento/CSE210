public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            return totalCost += 5m;
        } else
        {
            return totalCost += 35m;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()}  --  {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}