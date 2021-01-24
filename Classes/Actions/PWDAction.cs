using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class PWDAction : CommonAction
  {
  

    override public bool TryDo(out int responseCode)
    {
      string currentDir = Directory.GetCurrentDirectory();
      CLIDisplay.DisplayText(currentDir);
     
      responseCode = 0;
      return true;
    }
    
  }
}