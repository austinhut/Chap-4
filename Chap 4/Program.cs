

using System;
    
class AccountTest
    {
    static void Main()
        {
            //create an account object and assign it my myAccount
            Account myAccount = new Account();

            //display myAccounts' initial name (there is not one yet)
            Console.WriteLine($"The initial name is: {myAccount.GetName()}");

            //prompt for and read the name, then put the name in the object
            Console.Write("Enter the name: ");  //prompt
            string theName = Console.ReadLine();    //read the name
            myAccount.SetName(theName);     //put theName in the myAccount object

            //display the name stoed in the myAccount object
            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");

        }
    }