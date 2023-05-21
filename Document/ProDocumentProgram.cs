using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class ProDocumentProgram : DocumentProgram
    {
        public override sealed void EditDocument()
        {
            Console.WriteLine("Document Edited");
            Thread.Sleep(1000);
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
            Thread.Sleep(1000);
        }
    }
}
