//1. This violate the SRP becaue it has more responsibility

//using System;

//class OrderService
//{
//    public void PlaceOrder(string product, int quantity)
//    {
//        Console.WriteLine($"Order placed: {product} x {quantity}");

//        // Send email confirmation
//        Console.WriteLine($"Email sent: Order confirmation for {product}");

//        // Generate invoice
//        Console.WriteLine($"Invoice generated for {product}");
//    }
//}

//this follow srp

//using System;
//class placeorder
//{
//    public void order(string product,int quantity)
//    {
//        Console.WriteLine($"Order placed {product},quantity {quantity}");
//    }
//}

//class email
//{
//    public void mail(string product)
//    {
//        Console.WriteLine($"Email sent successfully {product}");
//    }
//}
//class invoice
//{
//    public void bil(string product)
//    {
//        Console.WriteLine($"The ivoce for product {product}");
//    }
//}
//class main
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("enter the product name:");
//        string product=Console.ReadLine();
//        Console.WriteLine("Enter the quantity:");
//        int quantity=int.Parse(Console.ReadLine());

//        placeorder p1= new placeorder();
//        p1.order(product, quantity);

//        email e1=new email();
//        e1.mail(product);

//        invoice i1=new invoice();
//        i1.bil(product);

//    }
//}

//===========================================================================================//
//using System;
//class placeorder
//{
//    public void order(string product, int quantity)
//    {
//        Console.WriteLine($"Order placed {product},quantity {quantity}");
//    }
//}

//class email
//{
//    public void mail(string product)
//    {
//        Console.WriteLine($"Email sent successfully {product}");
//    }
//}
//class invoice
//{
//    public void bil(string product)
//    {
//        Console.WriteLine($"The ivoce for product {product}");
//    }
//}


//class Orderprocess
//{
//    private readonly placeorder _placeorder;
//    private readonly email _email;
//    private readonly invoice _invoice; // this is property using manually

//    public Orderprocess(placeorder p1,email e1,invoice i1)
//    {
//        _placeorder = p1;
//        _email = e1;                // this is the constructor for the Orderprocess
//        _invoice = i1;
//    }

//    public void Process(string product, int quantity)
//    {
//        _placeorder.order(product, quantity);
//        _email.mail(product);
//        _invoice.bil(product); //using dependency injection
//    }
//}
//class main
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("enter the product name:");
//        string product = Console.ReadLine();
//        Console.WriteLine("Enter the quantity:");
//        int quantity = int.Parse(Console.ReadLine());

//        placeorder p1 = new placeorder();
//        email e1= new email();
//        invoice i1= new invoice();

//        Orderprocess o1 = new Orderprocess(p1, e1, i1);
//        o1.Process(product, quantity);

//    }
//}
