using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreStock.RepositoryManager;

namespace StoreStock.DatabaseModel {
  class Stock {
    internal static int countID;
    internal static List<Stock> allStock = new List<Stock>();

    internal int id;
    internal string type;
    internal int quantity;
    internal decimal price;
    public int ID { get { return id; } }
    public string Type { get { return type; } }
    public int Quantity { get { return quantity; } }
    public decimal Price { get { return price; } }
    /*internal string ObjType;*/

    /*public List<Stock> AllStock { get { return allStock; } }*/

    /*private static Stock[] allStock = new Stock[] { };*/

    internal Stock() {
    }
    /*internal static void AddStock(Stock obj)
    {
      allStock.Add(obj);
    }*/

    
  }
}
