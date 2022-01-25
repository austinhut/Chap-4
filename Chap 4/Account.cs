// Fig. 4.13: Account.cs
// Account class with a balance and a Deposit method

using System;

class Account
{
   public string Name { get; set; }    //auto implemented property 
   private decimal balance;   //instance variable

   //constructor sets the Name property to parameter accountName's value
   public Account(string accountName, decimal initialBalance)
   {
      Name = accountName;
      balance = initialBalance;  //Balance's set accessor validates here
   }

   //Balance property with validation
   public decimal Balance
   {
      get
      {
         return balance;
      }
      private set    //can only be used within Account class
      {
         //validate that the balance is greater than 0.0; if it
         //is not, instance vaariable balance keeps its prior value 

         if (value > 0.0m) //m indicates that 0.0 is a decimal literal
         {
         balance = value;
         }
      }
   }
   // method that deposits (adds) only a valid amount to the balance
   public void Deposit(decimal depositAmount)
   {
      if (depositAmount > 0.0m)  //if the depositAmount is valid
      {
         Balance = Balance + depositAmount;  //add it to the balance
      }
   }
}














