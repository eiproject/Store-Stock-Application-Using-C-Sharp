using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.RepositoryManager;
using StoreStock.Models;
using System.Linq;

namespace StoreStock.Business {
  class ViewFilteredStock : ViewStock {
    string jsonString;
    internal ViewFilteredStock(string className, Werehouse theStore) {
      Repository repo = new Repository(theStore);
      fetchedStock = repo.AllStock();
      IEnumerable<Stock> filteredData = fetchedStock.Where(
        data => data.type == className);
      fetchedStock = filteredData.ToList();
      ViewJSON viewer = new ViewJSON(fetchedStock);
    }
  }
}
