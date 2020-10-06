using System;
namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program.");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Sudipta", "Bala", "HelloWorld", "Kolkata", "WB", "sudipta@gmail.com", 123456, 1234567890);
            addressBook.ViewContact();
        }
    }
}
