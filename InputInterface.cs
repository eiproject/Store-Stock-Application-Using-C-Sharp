using System;

namespace StoreStock
{
  class InputInterface
  {
    internal static void AddOneStock()
    {
      Console.WriteLine(
        @"Input Format: 
1. Buku#Jumlah#Harga#Judul#Genre#Size
2. Pena#Jumlah#Harga#Judul#Brand#Warna Tinta#Size
3. Pensil#Jumlah#Harga#Judul#Brand#Size
Your input:"
        );
      string userInput = Console.ReadLine();
      try
      {
        InputInterface I = new InputInterface(userInput);
      }
      catch
      {
        Console.WriteLine("Wrong input. \n");
      }
    }

    internal static void ViewStock()
    {
      int choosenNumber;
      string userInput;

      Console.WriteLine(
        @"Choose data: 
1. All data
2. Buku
3. Pensil
4. Pena
Your input:"
        );
      userInput = Console.ReadLine();
      /*int choosenNumber = int.Parse(userInput);*/
      choosenNumber = int.TryParse(userInput, out choosenNumber) ? choosenNumber : 0;

      ViewData V = new ViewData();

      if (choosenNumber == 1)
      {
        V.AllData();
      }
      else if (choosenNumber == 2) 
      {
        V.SpecificClass("buku");
      }
      else if (choosenNumber == 3)
      {
        V.SpecificClass("pensil");
      }
      else if (choosenNumber == 4)
      {
        V.SpecificClass("pena");
      }
      else
      {
        Console.WriteLine("Wrong input number. \n");
      }

    }

    internal InputInterface(string inputText)
    {
      /*Console.WriteLine("inputText: " + inputText);*/
      string[] data = inputText.Split("#");
      if (data.Length == 6)
      {
        SavingInterface.SaveData(
        data[0].ToLower(), int.Parse(data[1]), decimal.Parse(data[2]),
        data[3], data[4], data[5]
        );
      }
      else if (data.Length == 7)
      {
        SavingInterface.SaveData(
        data[0].ToLower(), int.Parse(data[1]), decimal.Parse(data[2]),
        data[3], data[4], data[5], data[6]
        );
      }
      else
      {
        Console.WriteLine("Wrong input data. \n");
      }
    }
  }  
}