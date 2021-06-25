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
    void SellStock(int stockID, int amount);
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
    
    public void AddMoreStock(Stock obj) {
      List<Stock> allStock = Stock.allStock;
      allStock.Add(obj);
      Console.WriteLine("Adding Stock Done.");
    }

    public void DeleteStock(int stockID) {
      List<Stock> allStock = Stock.allStock;
      Stock target = allStock.Find(data => data.ID == stockID);
      if (target != null) {
        allStock.Remove(target);
        Console.WriteLine($"Product iD: {target?.ID } '{target?.Title}' Quantitiy: { target?.Quantity } sucessfully removed.");
      }
      else {
        Console.WriteLine($"Product ID: { stockID } is not exist.");
      }
    }
    
    public void SellStock(int stockID, int amount) {
      List<Stock> allStock = Stock.allStock;
      Stock target = allStock.Find(data => data.ID == stockID);
      if (target != null) {
        if (amount > target.Quantity) {
          Console.WriteLine($"Amount { amount } is exceed Product ID: { stockID } stock. (Available: {target?.Quantity})");
        }
        else {
          target.quantity -= amount;
          Console.WriteLine($"Product iD: {target?.ID } '{target?.Title}' Sold { amount } pcs");
          if (target.quantity == 0) {
            Repository del = new Repository();
            del.DeleteStock(stockID);
          }
        }        
      }
      else {
        Console.WriteLine($"Product ID: { stockID } is not exist.");
      }
    }
  }
}
