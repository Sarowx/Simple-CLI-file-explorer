using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class ActionInitializer
    {
          public static IAction GetAction(Command command)
          {
            IAction action;
            
            string actionName = command.ActionOrders.Peek();
            
            command.ActionOrders.Dequeue();
            
            switch(actionName)
            {
              case "pwd":
              {
                action = new PWDAction();
                break;
              }
              case "ls":
              {
                action = new LSAction();
                break;
              }
              case "cd":
              {
                action = new CDAction();
                break;
              }
              case "exit":
              {
                action = new ExitAction();
                break;
              }
              case "clear":
              {
                action = new ClearAction();
                break;
              }
              case "beep":
              {
                action = new BeepAction();
                break;
              }
              default:
              {
                return null;
              }
            }
            
            action.SetArgs(command.ActionOrders);
            
            return action;
          }
    }
}