using System.Reflection.Metadata.Ecma335;

public class Product
{
    private string _name;
    private string _productID;
    private int _quantity;
    private decimal _price;

    public Product(string name, string productID, int quantity, decimal price)
    {
        this._name = name;
        this._productID = productID;
        this._quantity = quantity;
        this._price = price;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public decimal GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetPackingLabelLine()
    {
        return $"{_name} (ID: {_productID}) Price: ${_price} Qty: {_quantity} - ${GetTotalCost()}";
    }

}