using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetClassLibrary;
namespace DotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DotNetClassLibrary.Context();
            a.Categories.ToList();
        }
    }
}
