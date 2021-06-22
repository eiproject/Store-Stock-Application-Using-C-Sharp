using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace StoreStock
{
  class ViewData
  {
    internal ViewData()
    {

    }
    internal void AllData()
    {
      string jsonString;
      Stock[] FetchAllData = Stock.AllStock;
      
      foreach (Stock data in FetchAllData)
      {
        ObjectConverter C = new ObjectConverter(data);
        jsonString = JsonSerializer.Serialize(C.ConvertedObject);
        Console.WriteLine(jsonString);
      }
    }

    internal void SpecificClass(string className)
    {
      string jsonString;
      Stock[] fetchAllData = Stock.AllStock;
      IEnumerable<Stock> filteredData = fetchAllData.Where(
        data => data.Type == className);

      foreach (Stock data in filteredData)
      {
        ObjectConverter C = new ObjectConverter(data);
        jsonString = JsonSerializer.Serialize(C.ConvertedObject);
        Console.WriteLine(jsonString);
      }
    }
  }
}
