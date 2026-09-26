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

    public int TotalCost()
    {
        return _price * _quantity;
    }






}