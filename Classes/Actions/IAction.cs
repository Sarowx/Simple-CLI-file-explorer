using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public interface IAction 
    {
      public void SetArgs(Queue<string> args);
      public bool TryDo(out int responseCode);
    }
}