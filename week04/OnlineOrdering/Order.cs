//Contains a list of products and a customer. Can calculate the total cost of the order. 
//Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
//If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer.

using System;
using System.Collections.Generic;
using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double SumOfProducts()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CostOfSingleProduct();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = "PACKING LABEL\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductID()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().ReturnFullAddress();
        return label;
    }





}