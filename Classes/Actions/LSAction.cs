using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class LSAction : CommonAction
  {

    override public bool TryDo(out int responseCode)
    {
      List<string> itemNames = GetDirectoryItemNames(Directory.GetCurrentDirectory());


      if (itemNames != null)
      {
        CLIDisplay.DisplayListWithQuotations(itemNames, " ");
      }
      else
      {
        CLIDisplay.DisplayText("Directory doesn't exist");
      }
      
      responseCode = 0;
      return true;
    }

    private List<string> GetDirectoryItemNames(string dir)
    {
      DirectoryInfo dirInfo = new DirectoryInfo(dir);

      if (!dirInfo.Exists)
      {
        return null;
      }

      List<string> itemList = new List<string>();


      var filenames = from FileInfo f in dirInfo.GetFiles()
                      select f.Name;
      var dirnames = from DirectoryInfo d in dirInfo.GetDirectories()
                     select d.Name;

      itemList.AddRange(dirnames);
      itemList.AddRange(filenames);

      return itemList;
    }



  }
}