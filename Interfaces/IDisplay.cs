using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public interface IDisplay 
    {
      void Display(IDisplayInfo);
    }
}