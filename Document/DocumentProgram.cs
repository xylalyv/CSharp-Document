using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    public class DocumentProgram
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                try
                {
                    if (value != ".") _name = value;
                    else throw new Exception("Name couldn't be .!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public DocumentProgram() { }
        public DocumentProgram(string name)
        {
            Name = name;
        }
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
            Thread.Sleep(1000);
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
            Thread.Sleep(1000);
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
            Thread.Sleep(1000);
        }
    }
}
