using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class CLIDisplay
    {
      
      
    	public static void DisplayText(string text)
    	{
    	  Console.WriteLine(text);
    	}
    	
    	public static void DisplayList(List<string> strList, string separator = "\n")
    	{
    	  foreach (string str in strList)
    	  {
    	    Console.Write(str);
    	    Console.Write(separator);
    	  }
    	  
    	  Console.WriteLine();
    	}
    	
    	// Display list items containing invisibles in quotations
    	public static void DisplayListWithQuotations(List<string> strList, string separator = "\n", string quotation = "'")
    	{
    	  var quotatedList = QuotateItemsHavingInvisibles(strList,quotation);
    	  
    	  DisplayList(quotatedList,separator);
    	}
    	
    	private static List<string> QuotateItemsHavingInvisibles(List<string> items, string quotation)
    	{
    	  List<string> newList = new List<string>();
    	  
    	  System.Text.StringBuilder sb = new System.Text.StringBuilder();
    	  
    	  foreach(string item in items)
    	  {
    	    if(item.Any(char.IsWhiteSpace))
    	    {
    	      sb.Append(quotation);
    	      sb.Append(item);
    	      sb.Append(quotation);
    	      
    	      newList.Add(sb.ToString());
    	    }
    	    else
    	    {
    	      newList.Add(item);
    	    }
    	  }
    	  
    	  return newList;
    	}
    	
    	
    	
    }
      
}