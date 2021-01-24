using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

  public class Command
  {
		public Queue<string> ActionOrders { get; private set; }
		
		public Command(Queue<string> actionOrders)
		{
		  ActionOrders = new Queue<string>(actionOrders.ToArray());
		  
		}
  }
}