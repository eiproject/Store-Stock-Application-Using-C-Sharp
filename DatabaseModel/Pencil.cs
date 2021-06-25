using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.Models {
  class Pencil : Stock {
    /*internal string title;*/
    internal string brand;
    internal string pencilSize;
    /*public string Title { get { return title; } }*/
    public string Brand { get { return brand; } }
    public string PencilSize { get { return pencilSize; } }
  }
}
