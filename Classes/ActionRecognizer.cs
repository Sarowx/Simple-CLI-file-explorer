using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class ActionRecognizer 
    {
          public static ActionEnum? Recognize(string actionName)
          {
            switch(actionName)
            {
              case "pwd":
              {
                return ActionEnum.pwd;
              }
              case "ls":
              {
                return ActionEnum.ls;
              }
              case "cd":
              {
                return ActionEnum.cd;
              }
              case "exit":
              {
                return ActionEnum.exit;
              }
              case "clear":
              {
                return ActionEnum.clear;
              }
              default:
              {
                return null;
              }
            }
          }
    }
}