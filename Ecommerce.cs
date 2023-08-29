using System;
using System.Collections.Generic;

class User
{
    public bool Role;
    public string LoginID;
    public string Password;

    public bool VerifyUser(string inputLogin, string inputPassword)
    {
        return LoginID == inputLogin && Password == inputPassword;
    }
}

class Customer : User
{
    public string Id;
    public string Address;
    public string Phone;
    public string Email;
    public ShoppingCart ShoppingCart;
    public List<Reviews> Reviews;
    public List<Orders> Orders;

    public void Login()
    {
        Console.WriteLine("Customer login");
    }

    public void Register()
    {
        Console.WriteLine("Customer registered");
    }

    public void UpdateProfile()
    {
        Console.WriteLine("Customer profile updated");
    }
}

class Seller : User
{
    public string Id;
    public string Address;
    public string Phone;
    public string Email;
    public int SellerRating;
    public List<Product> Products;

    public void Login()
    {
        Console.WriteLine("Seller login");
    }

    public void Register()
    {
        Console.WriteLine("Seller registered");
    }

    public void UpdateProfile()
    {
        Console.WriteLine("Seller profile updated");
    }
}

class Product
{
    public string ProductID;
    public string ProductName;
    public int ProductCost;
    public string SellerID;
    public DateTime PostedDate;
    public List<Reviews> Reviews;
    public List<Orders> Orders;

    public void AddToCart()
    {
        Console.WriteLine("Product added to cart");
    }

    public void SellProduct()
    {
        Console.WriteLine("Product sold");
    }

    public void GetProductDetails()
    {
        Console.WriteLine("Product details");
    }

    public void BuyProduct()
    {
        Console.WriteLine("Product bought");
    }
}

class Reviews
{
    public string ReviewID;
    public string CustomerID;
    public string ReviewContent;
    public int Rating;
    public string ParentID;
    public string ProductID;

    public void AddReview()
    {
        Console.WriteLine("Review added");
    }

    public void DeleteReview()
    {
        Console.WriteLine("Review deleted");
    }

    public void EditReview()
    {
        Console.WriteLine("Review edited");
    }
}

class Orders
{
    public string Id;
    public string SellerID;
    public string CustomerID;
    public string ProductID;
    public string TotalAmount;
    public DateTime OrderDate;
    public string Address;
    public DateTime DeliveryDate;
    public string DeliveryStatus;
    public Payment Payment;

    public void PlaceOrder()
    {
        Console.WriteLine("Order placed");
    }
}

class Payment
{
    public string Id;
    public string OrderID;
    public bool Paid;
    public int Total;
    public string Details;

    public void SendOtp()
    {
        Console.WriteLine("OTP sent");
    }
}

class ShoppingCart
{
    public DateTime Created;
    public List<Product> CartItems;

    public void AddCartItem()
    {
        Console.WriteLine("Cart item added");
    }

    public void CheckOut()
    {
        Console.WriteLine("Checkout completed");
    }

    public void ViewCartDetails()
    {
        Console.WriteLine("Cart details viewed");
    }

    public void UpdateQuantity()
    {
        Console.WriteLine("Quantity updated");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test your classes and relationships here
    }
}
