using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.AddingStock;
using StoreStock.ViewingStock;
using StoreStock.RepositoryManager;
using StoreStock.Models;

namespace StoreStock.Business {
  
  class CommandLineInterface{
    internal bool loopCondition = true;
    
    int menuSelected;
    string mainMenu =
@"Welcome to Main Menu
1. Add Stock
2. View Stock
3. Delete Stock
4. Sell Stock;
99. Exit
Choose menu:";
    string strChoosenMainMenu;
    internal CommandLineInterface(Werehouse StoreWerehouse) {
      // Generate main manu
      Console.WriteLine(mainMenu);
      strChoosenMainMenu = Console.ReadLine();
      menuSelected = int.TryParse(strChoosenMainMenu, out menuSelected) ? menuSelected : 0;
    }
  }
}
