using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override string Mode { get { return "Pro version"; } }
        public override void EditDocument()
        {
            Console.WriteLine("Rewrite document:");
            doc = Console.ReadLine();
            Console.WriteLine("The document has been edited");
        }

        public override void SaveDocument()
        {
            File.WriteAllText(filePath, doc);
            Console.WriteLine("The document is saved in the old format, saving in other formats is available in the Expert version");
            doc = "";
        }
    }
}
