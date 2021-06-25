using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.AddingStock;
using StoreStock.ViewingStock;
using StoreStock.RepositoryManager;

namespace StoreStock.CLI {
  
  class CommandLineInterface{
    internal bool loopCondition = true;
    enum userSelection {
      addStock = 1,
      viewStock,
      deleteStock,
      sellStock
    }
    internal CommandLineInterface(int menuSelected) {
      if (menuSelected == (int)userSelection.addStock) {
        AddStockInterface addInterface = new AddStockInterface();
      }
      else if (menuSelected == (int)userSelection.viewStock) {
        ViewStockInterface viewInterface = new ViewStockInterface();
      }
      else if (menuSelected == (int)userSelection.deleteStock) {
        ViewAllData All = new ViewAllData();

        Console.WriteLine("Enter Specific ID to delete: ");
        string idInput = Console.ReadLine();
        int intIdInput = int.TryParse(idInput, out intIdInput) ? intIdInput : 0;
        Repository del = new Repository();
        del.DeleteStock(intIdInput);
      }
      else if (menuSelected == (int)userSelection.sellStock) {
        ViewAllData All = new ViewAllData();

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
    internal class AddStockInterface {
      internal AddStockInterface() {
        Console.WriteLine(
@"Input Format: 
- Book#Stock amount#Price#Stock title#Genre#Size
- Pen#Stock amount#Price#Stock title#Brand#Ink color#Size
- Pencil#Stock amount#Price#Stock title#Brand#Size
Your input:"
        );
        string userInput = Console.ReadLine();
        try {
          InputParser userInputObj = new InputParser(userInput);
        }
        catch {
          Console.WriteLine("Wrong input. \n");
        }
      }
    }

    internal class ViewStockInterface {
      int choosenNumber;
      string userInput;
      enum dataType{
        all=1, 
        book,
        pencil,
        pen
      }
      internal ViewStockInterface() {
        Console.WriteLine(
@"Choose data: 
1. All data
2. Book
3. Pencil
4. Pen
Your input:"
          );
        userInput = Console.ReadLine();
        /*int choosenNumber = int.Parse(userInput);*/
        choosenNumber = int.TryParse(userInput, out choosenNumber) ? choosenNumber : 0;

        if (choosenNumber == (int)dataType.all) {
          ViewAllData fetchData = new ViewAllData();
        }
        else if (choosenNumber == (int)dataType.book) {
          ViewSpecificClass fetchData = new ViewSpecificClass("book");
        }
        else if (choosenNumber == (int)dataType.pencil) {
          ViewSpecificClass fetchData = new ViewSpecificClass("pencil");
        }
        else if (choosenNumber == (int)dataType.pen) {
          ViewSpecificClass fetchData = new ViewSpecificClass("pen");
        }
        else {
          Console.WriteLine("Wrong input number. \n");
        }
      }
    }

    internal class InputParser {
      internal InputParser(string inputText) {
        /*Console.WriteLine("inputText: " + inputText);*/
        string[] data = inputText.Split("#");
        AddStock newStock = new AddStock();
        if (data.Length == 6) {
          newStock.SaveData(
          data[0].ToLower(), int.Parse(data[1]), decimal.Parse(data[2]),
          data[3], data[4], data[5]
          );
        }
        else if (data.Length == 7) {
          newStock.SaveData(
          data[0].ToLower(), int.Parse(data[1]), decimal.Parse(data[2]),
          data[3], data[4], data[5], data[6]
          );
        }
        else {
          Console.WriteLine("Wrong input data. \n");
        }
      }
    }
  }
}
