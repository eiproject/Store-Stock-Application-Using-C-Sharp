using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.AddingStock;
using StoreStock.ViewingStock;
using StoreStock.RepositoryManager;
using StoreStock.Models;

namespace StoreStock.Business {
  class BusinessFunction {
    enum userSelection {
      addStock = 1,
      viewStock,
      deleteStock,
      sellStock,
    }
    BusinessFunction(int menuSelected) {
      // check selected main menu
      if (menuSelected == (int)userSelection.addStock) {
        AddStockInterface addInterface = new AddStockInterface();
      }
      else if (menuSelected == (int)userSelection.viewStock) {
        ViewStockInterface viewInterface = new ViewStockInterface();
      }
      else if (menuSelected == (int)userSelection.deleteStock) {
        ViewStock All = new ViewAllData();

        Console.WriteLine("Enter Specific ID to delete: ");
        string idInput = Console.ReadLine();
        int intIdInput = int.TryParse(idInput, out intIdInput) ? intIdInput : 0;
        Repository del = new Repository();
        del.DeleteStock(intIdInput);
      }
      else if (menuSelected == (int)userSelection.sellStock) {
        ViewStock All = new ViewAllData();

        Console.WriteLine("Enter Specific ID to sell: ");
        string idInput = Console.ReadLine();
        Console.WriteLine("How many? ");
        string amountInput = Console.ReadLine();
        int intIdInput = int.TryParse(idInput, out intIdInput) ? intIdInput : 0;
        int intAmountInput = int.TryParse(amountInput, out intAmountInput) ? intAmountInput : 0;
        Repository sell = new Repository();
        sell.SellStock(intIdInput, intAmountInput);
      }
      else {
        Console.WriteLine("Thanks for using Store Stock.");
        loopCondition = false;
      }
    }
  }
}
