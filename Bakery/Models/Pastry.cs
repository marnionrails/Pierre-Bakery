using System.Collections.Generic;

  namespace Bakery.Models
  {
    public class Pastry
    {

      public int PastryNumber {get; set;} = 2;
      public double PastryCost {get; set;} = 2.0;

      public Pastry(int pastryNumber)
      {
        PastryNumber = pastryNumber;
        
      }

      public double TotalPastryCost()
      {
        double totalPastryCost;
        if (PastryNumber == 3)
        {
          totalPastryCost = 5;
        }
        else
        {
          totalPastryCost = PastryNumber * 2;
        }
        return totalPastryCost;
      }
    }
  }