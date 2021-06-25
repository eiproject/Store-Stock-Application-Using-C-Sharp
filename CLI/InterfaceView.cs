using System;
using System.Collections.Generic;
using System.Text;

namespace StoreStock.Business {
  class ViewStockInterface {
    int choosenNumber;
    string userInput;
    enum dataType {
      all = 1,
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
}
