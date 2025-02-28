
////this is Open/closed principle example.
////the ocp means entities like(class,modules,fucntion) is open fir extension but closed for modification.

////here we are Instead of modifying an existing PaymentProcessor class to support new payment methods, create separate subclasses like CreditCardPayment and UPIPayment that extend the base class.

////public class PaymentProcessor
////{
////    public void Pay(string paymentType)
////    {
////        if (paymentType == "CreditCard")
////        {
////            // Process credit card payment
////        }
////        else if (paymentType == "UPI")
////        {
////            // Process UPI payment
////        }
////    }
////}



//using System;

//public interface payment
//{
//    void pay();
//}

//public class credit : payment
//{
//    public void pay()
//    {
//        Console.WriteLine("Processing credit payment");
//    }
//}

//public class upi : payment
//{
//    public void pay()
//    {
//        Console.WriteLine("proccessing upi payment");
//    }
//}

//public class paymentprocess
//{
//    public void process(payment Ipayment)
//    {
//        Ipayment.pay();
//    }
//}

//public class program

//{
//    static void Main(string[] args)
//    {
        
//        payment pay1 = new credit();
//        payment pay2 = new upi();

//        paymentprocess p1=new paymentprocess();

//        p1.process(pay1);
//        p1.process(pay2);

//    }
//}