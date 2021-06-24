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
          type = type,
          quantity = quantitiy,
          price = price,
          title = title,
          genre = genre_or_brand,
          paperSize = size
        };

        Stock newStock = newBook;
        Stock.AddMoreStock(newStock);
      }
      else if (type.ToLower() == "pencil")
      {
        Pencil newPensil = new Pencil
        {
          type = type,
          quantity = quantitiy,
          price = price,
          title = title,
          brand = genre_or_brand,
          pencilSize = size
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
        type = type,
        quantity = quantitiy,
        price = price,
        title = title,
        brand = brand,
        inkColor = inkColor,
        lineSize = linesize
      };

      Stock newStock = newPen;
      Stock.AddMoreStock(newStock);
    }
  }
}
