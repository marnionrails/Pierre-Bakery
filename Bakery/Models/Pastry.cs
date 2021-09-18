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
        return 2 * PastryNumber;
      }
    }
  }