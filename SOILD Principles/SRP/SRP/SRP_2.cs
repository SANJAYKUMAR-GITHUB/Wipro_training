//using System;

//class Bankaccount
//{
//    public string Acc_num { get; set; }
//    public double Balance { get; set; }

//    public Bankaccount(string acc_num, Double balance)
//    {
//        Acc_num = acc_num;
//        Balance = balance;
//    }
//    public void deposit(double amount)
//    {
//        Balance += amount;
//    }
//    public void withdraw(double amount)
//    {
//        Balance -= amount;
//    }
// }

//class Printing
//{
//    public void print(Bankaccount b1)
//    {
//        Console.WriteLine($"Account: {b1.Acc_num}, Balance: {b1.Balance}");
//    }
//}

//class notificaton
//{
//    public void sendmail(string message)
//    {
//        Console.WriteLine("Email sent: " + message);
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("enter the account number: ");
//        string Acc_numeber=Console.ReadLine();
//        Console.WriteLine("enter the balance ammount: ");
//        double balance=double.Parse(Console.ReadLine());
//        Bankaccount b1 = new Bankaccount(Acc_numeber, balance);

//        Console.WriteLine("Enter the ammount to be depoit: ");
//        double money=double.Parse(Console.ReadLine());
//        b1.deposit(money);

//        Console.WriteLine("Enter the ammoun to be debit: ");
//        double debit=double.Parse(Console.ReadLine());
//        b1.withdraw(debit);

//        Printing p1= new Printing();
//        p1.print(b1);

//        notificaton n1 = new notificaton();
//        n1.sendmail("Your deposit was successfully");

//    }
//}