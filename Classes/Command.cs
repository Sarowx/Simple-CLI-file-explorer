using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class Command
  {
		public ActionEnum? ActionCode { get; private set; }
		public Queue<string> ActionParams { get; private set; }

		public Command()
		{
			
		}
		
		public Command(ActionEnum? actionCode)
		{
		  ActionCode = actionCode;
		  ActionParams = new Queue<string>();
		}
		
		public Command(ActionEnum? actionCode, Queue<string> actionParams)
		{
		  ActionCode = actionCode;
		  ActionParams = new Queue<string>(actionParams.ToArray());
		  
		}
  }
}