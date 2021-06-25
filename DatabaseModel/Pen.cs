using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.DatabaseModel {
  class Pen : Stock {
    /*internal string title;*/
    internal string brand;
    internal string inkColor;
    internal string lineSize;
    /*public string Title { get { return title; } }*/
    public string Brand { get { return brand; } }
    public string InkColor { get { return inkColor; } }
    public string LineSize { get { return lineSize; } }
  }
}
