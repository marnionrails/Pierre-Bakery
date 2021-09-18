using System.Collections.Generic;

  namespace Bakery.Models
  {
    public class Bread
    {

      public int BreadNumber {get; set;} = 2;
      public double BreadCost {get; set;} = 2.0;

      public Bread(int breadNumber)
      {
        BreadNumber = breadNumber;
        
      }
      public double totalBreadCost()
      {
        double totalBreadCost = 5 * BreadNumber;
        if (BreadNumber == 3)
        {
          totalBreadCost -=5;
        }
        return totalBreadCost;
      }
    }
  }
