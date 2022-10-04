using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3._1
{
    internal class BaseContent
    {
        public string Content { get; set; }
        protected void Show(string heading) => Console.WriteLine($"{heading}: {Content}");
    }
}
