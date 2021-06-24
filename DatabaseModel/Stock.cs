using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreStock.RepositoryManager;

namespace StoreStock.DatabaseModel {
  abstract class SpecialCase {
    internal abstract decimal priceChange { get; set; }
  }
  class Stock : SpecialCase {
    internal static int countID;
    internal static int countBook;
    internal static int countPen;
    internal static int countPencil;

    internal static List<Stock> allStock = new List<Stock>();

    internal int id;
    private string _type;

    internal int quantity;
    internal decimal price;
    internal string type {
      get {
        return _type;
      }
      set {
        _type = value;
        /*if (value.ToLower() == "book") {
          countBook += quantity;
          Console.WriteLine($"adding book { countBook } { quantity } ");
        }
        else if (value.ToLower() == "pen") {
          countPen += quantity;
        }
        else if (value.ToLower() == "pencil") {
          countPencil += quantity;
        }
        else {
        }*/
      }
    }
    public int ID { get { return id; } }
    public string Type { get { return type; } }
    public int Quantity { get { return quantity; } }
    public decimal Price {
      get {
        int _counter = 0;
        if (type.ToLower() == "book") {
          _counter = countBook;
        }
        else if (type.ToLower() == "pen") {
          _counter = countPen;
        }
        else if (type.ToLower() == "pencil") {
          _counter = countPencil;
        }
        else {
        }

        /*Console.WriteLine($"priceChange { priceChange } { _counter } { type }");*/
        return price - (price * priceChange);
      }
    }

    internal override decimal priceChange {
      get {
        int _counter = 0;
        if (type.ToLower() == "book") {
          _counter = countBook;
        }
        else if (type.ToLower() == "pen") {
          _counter = countPen;
        }
        else if (type.ToLower() == "pencil") {
          _counter = countPencil;
        }
        else {
        }
        return Math.Min(decimal.Multiply((decimal)0.3, (decimal)_counter / 1000), (decimal)0.3);
      }
      set => priceChange = value;
      /*Math.Min(
        decimal.Multiply(
          (decimal)0.3, (decimal)countID / 1000), (decimal)0.3);*/
    }

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
