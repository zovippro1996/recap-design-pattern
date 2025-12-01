// See https://aka.ms/new-console-template for more information
using Prototype3;

System.Console.WriteLine("***Shallow vs Deep Copy Demo.***\n");
EmpAddress initialAddress = new EmpAddress("21, abc Road, USA");
Employee emp = new Employee(1, "John", initialAddress);

Console.WriteLine("The original object is emp1 which is as follows:");
Console.WriteLine(emp);

System.Console.WriteLine("Making a clone of emp1 now.");
Employee empClone = (Employee)emp.Clone();
System.Console.WriteLine("empClone object is as follows");
System.Console.WriteLine(empClone);

Console.WriteLine("\n Now changing the name, id and address of the cloned object ");
empClone.Id=10;
empClone.Name="Sam";
empClone.EmpAddress.Address= "221, xyz Road, Canada";

Console.WriteLine("Now emp1 object is as follows:");
Console.WriteLine(emp);
Console.WriteLine("And emp1Clone object is as follows:");
Console.WriteLine(empClone);