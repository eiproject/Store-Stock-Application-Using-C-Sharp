using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreStock.RepositoryManager;

namespace StoreStock.DatabaseModel {
  abstract class Pricing {
    protected abstract decimal discount { get; } // price change
  }
  class Stock : Pricing {
    const decimal maxDiscount = 0.3m; // max discount
    const decimal maxDiscountStock = 1000m; // max stock that get discount

    // internal static data
    internal static int countID;
    internal static int countBook;
    internal static int countPen;
    internal static int countPencil;
    internal static List<Stock> allStock = new List<Stock>();

    // internal data
    internal int id;
    internal string title;
    internal int quantity;
    internal decimal price;
    internal string type;

    // All public data
    public int ID { get { return id; } }
    public string Type { get { return type; } }
    public int Quantity { get { return quantity; } }
    public decimal Discount { get { return discount; } }
    public decimal Price {
      get {
        /*int _counter = 0;
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
        }*/

        /*Console.WriteLine($"priceChange { priceChange } { _counter } { type }");*/
        /*Console.WriteLine(discount);*/
        return price - discount;
      }
    }
    public string Title { get { return title; } }

    protected override decimal discount {
      get {
        int _counter = quantity;
        /*Console.WriteLine(quantity);*/
        decimal percentage;
        /*if (type.ToLower() == "book") {
          _counter = countBook;
        }
        else if (type.ToLower() == "pen") {
          _counter = countPen;
        }
        else if (type.ToLower() == "pencil") {
          _counter = countPencil;
        }
        else {
        }*/
        percentage = Math.Min(decimal.Multiply(maxDiscount, _counter / maxDiscountStock), maxDiscount);
        return decimal.Multiply(percentage, price);
      }
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
