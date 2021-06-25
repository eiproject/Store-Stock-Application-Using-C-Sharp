﻿using System;
using StoreStock.Business;
using StoreStock.Models;

namespace StoreStock {
  /*
  fitur:
 - input barang ( inget bisa macem2 tipe barang, bikin classnya )
 - simpan jumlah stock barang di array saja
 - bisa liat ada barang apa saja yang sudah diinput dan berapa jumlahnya 

  + Repository Manager

  */

  class Run {
    /* Tipe Barang#Jumlah#Harga#Judul#Genre#PaperType */
    /* Tipe Barang = Buku, Pena, Pensil */
    internal Run() {
      Werehouse FormulatrixStore = new Werehouse();

      GenerateDummyData dummy = new GenerateDummyData(FormulatrixStore);

      while (FormulatrixStore.isRunning) {
        CLI FormulatrixInterface = new CLIMenu(FormulatrixStore);
        FormulatrixInterface.InterfaceMenu();
      }
    }
  }
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Welcome to Store Stock Application!");
      Run App = new Run();
    }
  }
}
