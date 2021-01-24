using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class CDAction : CommonAction
  {

    override public bool TryDo(out int responseCode)
    {
      responseCode = 0;
      
      string arg;
      
      if(Args != null && Args.Count > 0)
      {
        arg = Args.Peek();
      }
      else
      {
        responseCode = 1;
        return false;
      }
      
      if(arg == "..")
      {
        Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory()).FullName);
      }
      else if(Directory.Exists(arg))
      {
        ChangeDirTo(arg);
      }
      else
      {
        string dir = ConcatDirectories(Directory.GetCurrentDirectory(), arg);
        
        if(Directory.Exists(dir))
        {
          ChangeDirTo(dir);
        }
        else
        {
          CLIDisplay.DisplayText("There is no such directory");
          return false;
        }
      }
      
      
      return true;
    }
    
    private void ChangeDirTo(string dir)
    {
      Directory.SetCurrentDirectory(dir);
    }
    
    private string ConcatDirectories(string dir1, string dir2)
    {
      if(dir1 == null || dir2 == null)
      {
        return "";
      }
      
      string dir;
      
      if(dir1.Last() == '/' || dir2.First() == '/')
      {
        if(dir1.Last() == '/' && dir2.First() == '/')
        {
          dir = dir1 + dir2.Remove(0,1);
        }
        else
        {
          dir = dir1 + dir2;
        }
      }
      else
      {
        dir = dir1 + '/' + dir2;
      }
      
      return dir;
    }
    
    
  }
}