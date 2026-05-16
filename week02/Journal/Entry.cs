
using System;
public class Entry
{
   public string _date;
   public string _time;
   public string _promptText;
   public string _entryText;
   public void Display()
   {
      Console.WriteLine($"Date: {_date}");
      Console.WriteLine($"Time: {_time}");
      Console.WriteLine($"Prompt: {_promptText}");
      Console.WriteLine($"Response: {_entryText}");

      Console.WriteLine();
   }
   
}