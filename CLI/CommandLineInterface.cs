using System;
using System.Collections.Generic;
using System.Text;
using StoreStock.AddingStock;
using StoreStock.ViewingStock;

namespace StoreStock.CLI {
  class CommandLineInterface {
    internal bool loopCondition = true;
    internal CommandLineInterface(int userChoosenNumber) {
      if (userChoosenNumber == 1) {
        AddStockInterface addInterface = new AddStockInterface();
      }
      else if (userChoosenNumber == 2) {
        ViewStockInterface viewInterface = new ViewStockInterface();
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
1. Book#Stock amount#Price#Stock title#Genre#Size
2. Pen#Stock amount#Price#Stock title#Brand#Ink color#Size
3. Pencil#Stock amount#Price#Stock title#Brand#Size
Your input:"
        );
        string userInput = Console.ReadLine();
        try {
          InputParser userInputObj = new InputParser(userInput);
        } catch {
          Console.WriteLine("Wrong input. \n");
        }
      }
    }

    internal class ViewStockInterface {
      int choosenNumber;
      string userInput;
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

        

        if (choosenNumber == 1) {
          ViewAllData fetchData = new ViewAllData();
        } else if (choosenNumber == 2) {
          ViewSpecificClass fetchData = new ViewSpecificClass("book");
        } else if (choosenNumber == 3) {
          ViewSpecificClass fetchData = new ViewSpecificClass("pencil");
        } else if (choosenNumber == 4) {
          ViewSpecificClass fetchData = new ViewSpecificClass("pen");
        } else {
          Console.WriteLine("Wrong input number. \n");
        }
      }
    }

    internal class InputParser {
      internal InputParser(string inputText) {
        /*Console.WriteLine("inputText: " + inputText);*/
        string[] data = inputText.Split("#");
        AddStock newStock= new AddStock();
        if (data.Length == 6) {
          newStock.SaveData(
          data[0].ToLower(), int.Parse(data[1]), decimal.Parse(data[2]),
          data[3], data[4], data[5]
          );
        } else if (data.Length == 7) {
          newStock.SaveData(
          data[0].ToLower(), int.Parse(data[1]), decimal.Parse(data[2]),
          data[3], data[4], data[5], data[6]
          );
        } else {
          Console.WriteLine("Wrong input data. \n");
        }
      }
    }
  }
}
