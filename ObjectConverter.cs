using System;

namespace StoreStock
{
  class ObjectConverter
  {
    public Object ConvertedObject;
    internal ObjectConverter(Stock obj)
    {
      if (obj.Type == "book")
      {
        Book convertedObject = (Book)obj;
        ConvertedObject = convertedObject;
      }
      else if (obj.Type == "pencil")
      {
        Pencil convertedObject = (Pencil)obj;
        ConvertedObject = convertedObject;
      }
      else if (obj.Type == "pen")
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
