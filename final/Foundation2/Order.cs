public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    private float CalculateTotalCost()
    {
        float totalCost = 0;
        foreach (Product x in _products)
        {
            totalCost = totalCost + x.TotalPrice();
        }
        if (_customer.GetAddress().IsInUSA())
            totalCost = totalCost + 5;
        else
            totalCost = totalCost + 35;
        return totalCost;
    }

    public string ProductLabel()
    {
        string label = ("-------Products-------\n");
        foreach(Product p in _products)
        {
            label += $"{p.GetName()} {p.GetID()} @ {p.GetPrice()} x {p.GetQuantity()}\n";
        }
        label += $"Total: {CalculateTotalCost()}\n"; 
        return label;
    }


    public string ShippingLabel(){

        return $"Name: {_customer.GetName()}\n" 
            + $"Address: {_customer.GetAddress().GetAddressString()}";
    }
}