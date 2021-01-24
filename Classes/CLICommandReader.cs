using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Shell
{

  public class CLICommandReader
  {

    public CLICommandReader()
    {

    }

    public Command Read()
    {
      string plainCommandText = ReadPlainText();
      
      var orderQueue = SplitToOrders(plainCommandText);
      
      Command command = new Command(orderQueue);
      
      return command;
    }

    private string ReadPlainText()
    {
      Console.Write("$ ");
      string plainText = Console.ReadLine();
      return plainText;
    }

    private Queue<string> SplitToOrders(string plainCommandText)
    {
      Queue<string> orders = new Queue<string>();

      char? quotationMark = null;
      StringBuilder orderSB = new StringBuilder();


      foreach (char c in plainCommandText)
      {
        if (char.IsWhiteSpace(c))
        {
          if (quotationMark != null)
          {
            orderSB.Append(c);
            continue;
          }
          orders.Enqueue(orderSB.ToString());
          orderSB.Clear();

          continue;
        }

        if (c == "'".First() || c == '"')
        {
          if (quotationMark == null)
          {
            quotationMark = c;
            continue;
          }

          if (c == quotationMark)
          {
            orders.Enqueue(orderSB.ToString());
            orderSB.Clear();

            quotationMark = null;

            continue;
          }

          orderSB.Append(c);
          continue;
        }

        orderSB.Append(c);

      }

      if (orderSB.Length > 0)
      {
        orders.Enqueue(orderSB.ToString());
        orderSB.Clear();
      }

      return orders;
    }

  }
}