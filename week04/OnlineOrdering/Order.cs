using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._products = new List<Product>();
        this._customer = customer;
    }

    public string GetShippingLabel()
    {
        return $"\n---DISCLAIMER - ALL FOREIGN SHIPMENTS ARE $35---\nShipping to:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (Product product in _products){
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUSA()){
            total += 3;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += product.GetPackingLabelLine() + "\n";
        }

        label +=  $"---Total: ${GetTotalPrice()}---\n";
        return label;
    }
}