using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.DatabaseModel;
using StoreStock.RepositoryManager;

namespace StoreStock.AddingStock {
  class AddStock {
    int currentID = Stock.countID;
    internal void SaveData(
      string type, int quantitiy, decimal price,
      string title, string genre_or_brand, string size) {
      Stock.countID++;
      if (type.ToLower() == "book") {
        Book newBook = new Book {
          id = currentID,
          type = type,
          quantity = quantitiy,
          price = price,
          title = title,
          genre = genre_or_brand,
          paperSize = size
        };

        Stock newStock = newBook;

        Repository repo = new Repository();
        repo.AddMoreStock(newStock);
      }
      else if (type.ToLower() == "pencil") {
        Pencil newPensil = new Pencil {
          id = currentID,
          type = type,
          quantity = quantitiy,
          price = price,
          title = title,
          brand = genre_or_brand,
          pencilSize = size
        };

        Stock newStock = newPensil;

        Repository repo = new Repository();
        repo.AddMoreStock(newStock);
      }
      else {
        Console.WriteLine("Failed to save data.");
      }
    }

    internal void SaveData(
      string type, int quantitiy, decimal price,
      string title, string brand, string inkColor, string linesize) {
      Stock.countID++;
      Pen newPen = new Pen {
        id = currentID,
        type = type,
        quantity = quantitiy,
        price = price,
        title = title,
        brand = brand,
        inkColor = inkColor,
        lineSize = linesize
      };

      Stock newStock = newPen;
      Repository repo = new Repository();
      repo.AddMoreStock(newStock);
    }
  }

}
