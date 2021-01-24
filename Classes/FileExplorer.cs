using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class FileExplorer
  {
    private CLICommandReader CommandReader { get; set; }


    public FileExplorer()
    {
      Initialize();

    }

    public void Run()
    {
      int responseCode = 0;

      do
      {
        Command command = CommandReader.Read();

        IAction action = ActionInitializer.GetAction(command);

        if(action == null)
        {
          CLIDisplay.DisplayText("Action is not recognized");
          
          continue;
        }

        if (action.TryDo(out responseCode))
        {

        }
        else
        {

        }


      }
      while (responseCode >= 0);
    }

    private void Initialize()
    {
      CommandReader = new CLICommandReader();

    }
  }
}