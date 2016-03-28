using System;

//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class PrintCompanyInformation_02
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phonenumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxnumber = Console.ReadLine();
        Console.Write("Web site: ");
        string website = Console.ReadLine();
       
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company name: " + companyName);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Phone number: " + phonenumber);
        Console.WriteLine("Fax number: " + faxnumber);
        Console.WriteLine("Web site: " + website);
        Console.WriteLine("Manager: {0} {1} (Age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

