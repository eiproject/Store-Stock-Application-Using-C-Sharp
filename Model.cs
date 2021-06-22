using System;
using System.Collections.Generic;

namespace StoreStock
{
  class Stock
  {
    internal string Type { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
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
    public string Title{ get; set; } 
    public string Genre{ get; set; }
    public string PaperSize{ get; set; }
  }

  class Pen : Stock
  {
    public string Title{ get; set; }
    public string Brand{ get; set; }
    public string InkColor{ get; set; }
    public string LineSize{ get; set; }
  }

  class Pencil : Stock
  {
    public string Title{ get; set; }
    public string Brand{ get; set; }
    public string PencilSize{ get; set; }
  }
}
