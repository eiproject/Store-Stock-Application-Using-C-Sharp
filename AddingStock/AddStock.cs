﻿using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.Models;
using StoreStock.RepositoryManager;

namespace StoreStock.AddingStock {
  class AddStock {
    int currentID;
    internal AddStock( Werehouse SelectedWerehouse) {
      currentID = SelectedWerehouse.WerehouseData[-1].ID + 1;
    }
    internal void SaveData(
      string type, int quantity, decimal price,
      string title, string genre_or_brand, string size) {
      if (type.ToLower() == "book") {
        Book newBook = new Book {
          id = currentID,
          type = type,
          quantity = quantity,
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
          quantity = quantity,
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
      string type, int quantity, decimal price,
      string title, string brand, string inkColor, string linesize) {
      Stock.countID++;
      Pen newPen = new Pen {
        id = currentID,
        type = type,
        quantity = quantity,
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
