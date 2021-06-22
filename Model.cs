using System;
using System.Collections.Generic;

namespace StoreStock
{
  class Stock
  {
    internal string Type;
    internal int Quantity;
    internal decimal Price;
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
      Array.Resize(ref allStock, allStock.Length + 2);
      allStock[allStock.Length - 1] = obj;
    }

    internal Stock[] AllStock { get { return allStock; } }
  }

  class Book : Stock
  {
    internal string Title; 
    internal string Genre;
    internal string PaperSize;
  }

  class Pen : Stock
  {
    internal string Title;
    internal string Brand;
    internal string InkColor;
    internal string LineSize;
  }

  class Pencil : Stock
  {
    internal string Title;
    internal string Brand;
    internal string PencilSize;
  }
}
