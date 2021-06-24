using System;
using StoreStock.CLI;

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
    internal bool isLoop = true;
    int userChoosenMainMenu;
    string strChoosenMainMenu;
    string[] testInput = new string[] {
        "Book#10#895000#Magic Tree House Boxed Set, Books 1-4#Dongeng#A5",
        "PENcil#21#49800#Conte Pieree Noire#Conte#3B",
        "BOOK#1#105900#It Ends with Us#Novel#A5",
        "pencil#3#5400#Drawing Pencil Joyko#Joyko#2B",
        "PEN#2#51000#Pilot Pen Mr 2 Metropolitan#Pilot#Black#0.5"
      };
    string mainMenu =
@"Welcome to Main Menu
1. Add Stock
2. View Stock
3. Delete Stock
99. Exit
Choose menu:";
    internal Run() {

      foreach (string inputData in testInput) {
        try {
            CommandLineInterface.InputParser initialData = new CommandLineInterface.InputParser(inputData);
        }
        catch {
          Console.WriteLine("Wrong input. \n");
        }
      }

      while (isLoop) {
        Console.WriteLine(mainMenu);
        strChoosenMainMenu = Console.ReadLine();
        userChoosenMainMenu = int.TryParse(strChoosenMainMenu, out userChoosenMainMenu) ? userChoosenMainMenu : 0;
        CommandLineInterface CLI = new CommandLineInterface(userChoosenMainMenu);
        isLoop = CLI.loopCondition;
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
