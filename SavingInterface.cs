using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace StoreStock
{
  class SavingInterface
  {
    internal static void SaveData(
      string type, int quantitiy, decimal price,
      string title, string genre_or_brand, string size)
    {
      if (type.ToLower() == "book")
      {
        Book newBook = new Book
        {
          Type = type,
          Quantity = quantitiy,
          Price = price,
          Title = title,
          Genre = genre_or_brand,
          PaperSize = size
        };

        Stock newStock = newBook;
        Stock.AddMoreStock(newStock);
      }
      else if (type.ToLower() == "pencil")
      {
        Pencil newPensil = new Pencil
        {
          Type = type,
          Quantity = quantitiy,
          Price = price,
          Title = title,
          Brand = genre_or_brand,
          PencilSize = size
        };

        Stock newStock = newPensil;
        Stock.AddMoreStock(newStock);
      }
      else
      {
        Console.WriteLine("Failed to save data.");
      }
    }

    internal static void SaveData(
      string type, int quantitiy, decimal price,
      string title, string brand, string inkColor, string linesize)
    {
      Pen newPen = new Pen
      {
        Type = type,
        Quantity = quantitiy,
        Price = price,
        Title = title,
        Brand = brand,
        InkColor = inkColor,
        LineSize = linesize
      };

      Stock newStock = newPen;
      Stock.AddMoreStock(newStock);
    }
  }
}
