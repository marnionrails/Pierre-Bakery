using System.Collections.Generic;

  namespace Bakery.Models
  {
    public class Bread
    {

      public int BreadNumber {get; set;} = 0;
      public double BreadCost {get; set;} = 0.0;

      private static int _totalBread = 0;

      public Bread(int breadNumber)
      {
        BreadNumber = breadNumber;
        _totalBread += BreadNumber;
      }
      public double totalBreadCost()
      {
        double totalBreadCost = 5 * BreadNumber;
        if (BreadNumber % 3 == 0)
        {
          totalBreadCost -=5*BreadNumber/3;
        }
        return totalBreadCost;
      }

      public static int GetBreadTotal()
      {
        return _totalBread;
      }
    }
  }
