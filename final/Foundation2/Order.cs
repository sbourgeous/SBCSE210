public class Order
{
    private List<Product> _productList;
    private Customer _customer;
    private string _packingLabel;
    private string _shippingLabel;

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }

    public float CalculateTotalCost()
    {
        float totalCost = 0;

        foreach (var product in _productList)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.IsUSA())
        {
            totalCost += 5; // Shipping cost for USA
        }
        else
        {
            totalCost += 35; // Shipping cost for non-USA
        }

        return totalCost;
    }

    public string CreatePackingLabel()
    {
        _packingLabel = "Packing Label:\n";
        foreach (var product in _productList)
        {
            _packingLabel += $"Product: {product.GetTotalCost()}, ID: {product.GetTotalCost()}\n";
        }
        return _packingLabel;
    }

    public string CreateShippingLabel()
    {
        _shippingLabel = $"Shipping Label:\n{_customer.IsUSA()}\n{_customer.Address.GetFullAddress()}\n";
        return _shippingLabel;
    }
}