using System;
using System.Collections.Generic;

namespace StoreStock
{
  class Stock
  {
    internal string type;
    internal int quantity;
    internal decimal price;
    public int Quantity { get { return quantity; } }
    public decimal Price { get { return price; }  }
    /*internal string ObjType;*/

    /*static List<Stock> allStock = new List<Stock>();*/
    private static Stock[] allStock = new Stock[] { };

    protected Stock()
    {

    }
    /*internal static void AddStock(Stock obj)
    {
      allStock.Add(obj);
    }*/

    internal static void AddMoreStock(Stock obj)
    {
      /*Console.WriteLine(allStock.Length);*/
      Array.Resize(ref allStock, allStock.Length + 1);
      allStock[allStock.Length - 1] = obj;
      Console.WriteLine("Adding Stock Done.");
    }

    internal static Stock[] AllStock { get { return allStock; } }
  }

  class Book : Stock
  {
    internal string title;
    internal string genre;
    internal string paperSize;
    public string Title{ get { return title; } } 
    public string Genre{ get { return genre; } }
    public string PaperSize{ get{ return paperSize; } }
  }

  class Pen : Stock
  {
    internal string title;
    internal string brand;
    internal string inkColor;
    internal string lineSize;
    public string Title{ get{ return title; } }
    public string Brand{ get{ return brand; } }
    public string InkColor{ get{ return inkColor; } }
    public string LineSize{ get{ return lineSize; } }
  }

  class Pencil : Stock
  {
    internal string title;
    internal string brand;
    internal string pencilSize;
    public string Title{ get{ return title; } }
    public string Brand{ get{ return brand; } }
    public string PencilSize{ get{ return pencilSize; } }
  }
}
