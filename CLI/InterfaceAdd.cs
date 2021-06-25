using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.Business {
  class AddStockInterface {
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
}
