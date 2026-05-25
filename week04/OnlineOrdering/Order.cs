using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Each Order object manages its own list of products,
    // similar to how real online shopping systems organize
    // items inside a customer's cart before checkout.
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost is automatically determined
        // based on whether the customer lives in the USA.
        // This simulates how real e-commerce systems
        // calculate shipping charges dynamically.
        if (_customer.LivesInUSA())
        {
            total += 5;
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
            label += $"{product.GetName()} " +
                     $"- ID: {product.GetProductId()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n" +
               $"{_customer.GetName()}\n" +
               $"{_customer.GetAddress().GetFullAddress()}";
    }
}