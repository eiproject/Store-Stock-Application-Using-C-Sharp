using System;

namespace StoreStock
{
  class InputInterface
  {
    internal InputInterface(string inputText)
    {
      string[] data = inputText.Split("#");
      if (data.Length == 6)
      {
        SavingInterface.SaveData(
        data[0], int.Parse(data[1]), decimal.Parse(data[2]),
        data[3], data[4], data[5]
        );
      }
      else if (data.Length == 7)
      {
        SavingInterface.SaveData(
        data[0], int.Parse(data[1]), decimal.Parse(data[2]),
        data[3], data[4], data[5], data[6]
        );
      }
      else
      {
        Console.WriteLine("Wrong input data.");
      }
    }
  }  
}
