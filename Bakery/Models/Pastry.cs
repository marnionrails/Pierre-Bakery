using System.Collections.Generic;

  namespace Bakery.Models
  {
    public class Pastry
    {

      public int PastryNumber {get; set;} = 0;
      public double PastryCost {get; set;} = 0.0;

      private static int _totalPastry = 0;

      public Pastry(int pastryNumber)
      {
        PastryNumber = pastryNumber;
        
      }

      public double TotalPastryCost()
      {
        double totalPastryCost;
        if (PastryNumber % 3 == 0)
        {
          totalPastryCost = 5 * (PastryNumber/3);
        }
        else
        {
          totalPastryCost = ((PastryNumber - PastryNumber % 3)/3)*5 + ((PastryNumber%3)*2);
        }
        return totalPastryCost;
      }
      public static int GetPastryTotal()
      {
        return _totalPastry;
      }
    }
  }