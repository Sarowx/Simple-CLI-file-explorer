using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class ExitAction : CommonAction
  {

    override public bool TryDo(out int responseCode)
    {
      responseCode = -1;
      
      return true;
    }

  }
}