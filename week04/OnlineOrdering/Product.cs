// Contains the name, product id, price, and quantity of each product.
// The total cost of this product is computed by multiplying the price per unit and the quantity. 
//(If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)

using System;

public class Product
{
    private string _name;
    private double _productID;
    private double _price;
    private double _quantity;

    public Product(string name, double productID, double price, double quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double CostOfSingleProduct()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public double GetProductID()
    {
        return _productID;
    }
    public void Display()
    {
        Console.WriteLine($"Product: {_name}\nProduct ID: {_productID}\nProduct Price: ${_price} Dollars\nAmount purchased: {_quantity}");
        Console.WriteLine($"Total Cost of product is: ${CostOfSingleProduct()}");
    }





}