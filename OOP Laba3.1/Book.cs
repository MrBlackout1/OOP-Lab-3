using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Laba3._1
{
    internal class Book
    {
        public Title Title {get; set;} = new Title() {Content = "Title1"};
        public Author Author {get; set;} = new Author() {Content = "Author1"};
        public Content Content {get; set;} = new Content() {Content = "Content1"};
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Title.Show();
             Console.ForegroundColor = ConsoleColor.Yellow;
            Author.Show();
           Console.ForegroundColor = ConsoleColor.White;
            Content.Show();            
        }
    }
}
