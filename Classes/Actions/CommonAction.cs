using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class CommonAction : IAction
  {
    protected Queue<string> Args;

    virtual public bool TryDo(out int responseCode)
    {
      responseCode = 0;
      return true;
    }

    public void SetArgs(Queue<string> args)
    {
      Args = new Queue<string>(args.ToArray());
    }
  }
}