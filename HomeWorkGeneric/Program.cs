using HomeWorkGeneric;
using System.Xml.Schema;

CustomCollection<Employee> collection = new CustomCollection<Employee>();
int choice;
do
{
    Console.WriteLine("Secim edin : 1-Add 2-FindByID 3-GetAll 0-Exit");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Employee employe = CreateEmployee();
            if (employe != null)
            {
                collection.Add(employe);
            }
            break;
        case 2:
            Console.WriteLine("id ver");
            int id = int.Parse(Console.ReadLine());
            Employee employee1 = collection.FindById(id);
            if (employee1 == null)
            {
                Console.WriteLine("Tapilmadi!!");
            }
            else
            {
                Console.WriteLine($@"id : {employee1.Id}
name : {employee1.Name}
age : {employee1.Age}");
            }
            break;
        case 3:
            Console.WriteLine("Butun ishciler ----->");
            collection.GetAll();
            break;
        case 0:
            Console.WriteLine("Program dayandirrrr....");
            break;
        default:
            Console.WriteLine("Secimi duzgun et");
            break;
    }

} while (choice != 0);


static Employee CreateEmployee()
{
    Console.WriteLine("Isci elave edin");
    Console.WriteLine("Adiniz:");
    string name = Console.ReadLine();
    Console.WriteLine("Soyadiniz:");
    string surname = Console.ReadLine();
    Console.WriteLine("Yasiniz:");
    int? age = int.Parse(Console.ReadLine());
    Console.WriteLine("Salary:");
    double salary = double.Parse(Console.ReadLine());

    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && age != null)
    {
        Employee employee = new Employee();
        employee.Name = name;
        employee.SurName = surname;
        employee.Age = age;
        employee.Salary = salary;


        return employee;
    }
    else
    {
        Console.WriteLine("Butun melumatlari daxil edin");

        return null;
    }



}
