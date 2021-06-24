using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreStock.DatabaseModel;
using StoreStock.DatabaseModel;

namespace StoreStock.RepositoryManager {
  interface IUserRepository {
    List<Stock> AllStock();
    List<Stock> FilterStocksByCategory(string category);
    void AddMoreStock(Stock newStock);
    void DeleteStock(int stockID);
  }
  class Repository : IUserRepository {
    public List<Stock> AllStock() {
      List<Stock> allStock = Stock.allStock;
      return allStock;
    }
    public List<Stock> FilterStocksByCategory(string className) {
      List<Stock> allStock = Stock.allStock;
      IEnumerable<Stock> filteredData = allStock.Where(
        data => data.type == className);
      return filteredData.ToList();
    }
    public void DeleteStock(int stockID) {
      List<Stock> allStock = Stock.allStock;
      Stock target = allStock.Find(data => data.id == stockID);
      allStock.Remove(target);
    }
    public void AddMoreStock(Stock obj) {
      List<Stock> allStock = Stock.allStock;
      allStock.Add(obj);
      Console.WriteLine("Adding Stock Done.");
    }
  }
}
