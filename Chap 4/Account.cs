// Fig. 4.6: Account.cs
// Account class that replaces public methods SetName
// and GetName with a public Name property

class Account
{
   private string name;

   public string Name
   {
      get
      {
         return name;
      }
      set
      {
         name = value;
      }
   }
}














