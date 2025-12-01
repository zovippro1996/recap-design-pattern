using System;

namespace Prototype3;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EmpAddress EmpAddress { get; set; }
    public Employee(int id, string name, EmpAddress empAddress)
    {
        this.Id = id;
        this.Name = name;
        this.EmpAddress = empAddress;
    }

    public override string ToString()
    {
        return string.Format(
            "Employee Id is : {0}, Employee Name is: {1}, Employee Address is: {2}",
            this.Id,
            this.Name,
            this.EmpAddress);
    }

    public object Clone()
    {
        // Shallow Copy
        // return this.MemberwiseClone();

        // Deep Copy
        Employee employee = (Employee)this.MemberwiseClone();
        employee.EmpAddress = (EmpAddress)this.EmpAddress.CloneAddress();
        return employee;
    }
}
