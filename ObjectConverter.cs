using System;

namespace StoreStock
{
  class ObjectConverter
  {
    public Object ConvertedObject;
    internal ObjectConverter(Stock obj)
    {
      if (obj.type == "book")
      {
        Book convertedObject = (Book)obj;
        ConvertedObject = convertedObject;
      }
      else if (obj.type == "pencil")
      {
        Pencil convertedObject = (Pencil)obj;
        ConvertedObject = convertedObject;
      }
      else if (obj.type == "pen")
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
