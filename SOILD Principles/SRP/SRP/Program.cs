using System;
//1.A class should have only one reason to change, it should have only one responsibility


//Here the above class has to responsibility to calculte salary and greanarate report it 
//violate SRP
//class Employee
//{
//    public string name { get; set; }
//    public int age { get; set; }

//    public void calculatesalary()
//    {

//    }
//    public void report()
//    {

//    }
//}

//Crt SRP program is========================//

//class Employee
//{
//    public string name { get; set; }
//    public double salary { get; set; } //properties

//    public Employee(string Name,double Salary) //constructor
//    {
//        name= Name;
//        salary= Salary;
//    }
//}
//class salarycalculate
//{
//    public double calculate(Employee employee)
//        {
//        double tax = employee.salary * 0.1; //10% tax
//        double netsalary = employee.salary - tax;
//        return netsalary;

//        }
//}
//class report
//{
//    public void employee_rep(Employee employee,double netsalary)
//    {
//        Console.WriteLine("Employee salary report \nEmployee name: " + employee.name);
//        Console.WriteLine("Employee basic salary: "+employee.salary);
//        Console.WriteLine("employee net salary: " + netsalary);
//   }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        Employee employee = new Employee("Sanjay",60000);

//        salarycalculate s1=new salarycalculate();

//        double netsalary=s1.calculate(employee);

//        report r1=new report();
//        r1.employee_rep(employee, netsalary);


//    }
//}