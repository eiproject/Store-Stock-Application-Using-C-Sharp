using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreStock
{
  class ViewData
  {
    internal ViewData()
    {

    }
    internal void AllData()
    {
      Stock[] FetchAllData = Stock.AllStock;
      foreach (Stock data in FetchAllData)
      {
        Console.WriteLine(data.GetType());
      }
    }
    internal void SpecificClass(string className)
    {
      Stock[] fetchAllData = Stock.AllStock;
      IEnumerable<Stock> filteredData = fetchAllData.Where(data => data.Type == className);
      foreach (Stock data in filteredData)
      {
        Console.WriteLine(data.GetType());
      }
    }
  }
}
