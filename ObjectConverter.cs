using System;

namespace StoreStock
{
  class ObjectConverter
  {
    public Object ConvertedObject;
    internal ObjectConverter(Stock obj)
    {
      if (obj.Type == "buku")
      {
        Book convertedObject = (Book)obj;
        ConvertedObject = convertedObject;
      }
      else if (obj.Type == "pensil")
      {
        Pencil convertedObject = (Pencil)obj;
        ConvertedObject = convertedObject;
      }
      else if (obj.Type == "pena")
      {
        Pen convertedObject = (Pen)obj;
        ConvertedObject = convertedObject;
      }
      else
      {
        Console.WriteLine("Unidentified Filled Object");
      }
    }
  }
}
