using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class BeepAction : CommonAction
  {
    override public bool TryDo(out int responseCode)
    {
      Console.Beep();
      
      responseCode = 0;
      return true;
    }
  }
}