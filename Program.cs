using System;

namespace StoreStock
{
   /*
   fitur:
  - input barang ( inget bisa macem2 tipe barang, bikin classnya )
  - simpan jumlah stock barang di array saja
  - bisa liat ada barang apa saja yang sudah diinput dan berapa jumlahnya 
   */

  class Run
  {
    /* Tipe Barang#Jumlah#Harga#Judul#Genre#PaperType */
    /* Tipe Barang = Buku, Pena, Pensil */
    internal bool isLoop = true;
    string[] testInput = new string[] {
        "Buku#4#895000#Magic Tree House Boxed Set, Books 1-4#Dongeng#A5",
        "Pensil#2#49800#Conte Pieree Noire#Conte#3B",
        "Buku#1#105900#It Ends with Us#Novel#A5",
        "Pensil#3#5400#Drawing Pencil Joyko#Joyko#2B",
        "Pena#1#51000#Pilot Pen Mr 2 Metropolitan#Pilot#Black#0.5"
      };
    string mainMenu = @"Main Menu
1. Add Stock
2. View Stock
99. Exit
Choose menu:";
    int userChoosenNumber;

    internal Run()
    {

      foreach (string inputData in testInput)
      {
        InputInterface IN = new InputInterface(inputData);
      }

      while (isLoop)
      {
        Console.WriteLine(mainMenu);

        string inTmp = Console.ReadLine();
        userChoosenNumber = int.Parse(inTmp);
        Console.WriteLine(userChoosenNumber);

        if (userChoosenNumber == 1)
        {
          InputInterface.AddOneStock();
        } else if (userChoosenNumber == 2)
        {
          InputInterface.ViewStock();
        } else
        {
          Console.WriteLine("Thanks for using Store Stock.");
          isLoop = false;
        }
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Store Stock Application!");
      Run App = new Run();
    }
  }
}
