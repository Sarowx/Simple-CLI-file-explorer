using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class ClearAction : CommonAction
  {

    override public bool TryDo(out int responseCode)
    {
      Console.Clear();

      responseCode = 0;
      return true;
    }


  }
}