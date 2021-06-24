using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using StoreStock.DatabaseModel;
using StoreStock.RepositoryManager;

namespace StoreStock.ViewingStock {
  class ViewStock {
    protected List<Stock> fetchedStock;
    public object FetchedStock { get { return fetchedStock; } }
  }

  class ViewAllData : ViewStock{
    string jsonString;
    internal ViewAllData() {
      Repository repo = new Repository();
      fetchedStock = repo.AllStock();
      ViewJSON viewer = new ViewJSON(fetchedStock);
      /*foreach (Stock data in FetchAllData) {
        ObjectConverter C = new ObjectConverter(data);
        jsonString = JsonSerializer.Serialize(C.ConvertedObject);
        Console.WriteLine(jsonString);
      }*/
    }
  }

  class ViewSpecificClass : ViewStock{
    string jsonString;
    internal ViewSpecificClass(string className) {
      Repository repo = new Repository();
      fetchedStock = repo.AllStock();
      IEnumerable<Stock> filteredData = fetchedStock.Where(
        data => data.type == className);
      fetchedStock = filteredData.ToList();
      ViewJSON viewer = new ViewJSON(fetchedStock);
      /*foreach (Stock data in filteredData) {
        ObjectConverter C = new ObjectConverter(data);
        jsonString = JsonSerializer.Serialize(C.ConvertedObject);
        Console.WriteLine(jsonString);
      }*/
    }
  }
}
