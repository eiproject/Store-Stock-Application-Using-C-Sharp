using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.DatabaseModel {
  class Book : Stock {
    internal static int countBook;

    /*internal string title;*/
    internal string genre;
    internal string paperSize;
    /*public string Title { get { return title; } }*/
    public string Genre { get { return genre; } }
    public string PaperSize { get { return paperSize; } }

  }
}
