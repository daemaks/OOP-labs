using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    internal class DocumentWorker
    {
        protected string doc = "";
        protected string filePath;
        public virtual string Mode { get { return "Free version"; } }
        public string Doc { get { return doc; } }

        public DocumentWorker()
        {
            string? path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = path + "/test.txtold";
            File.Create(filePath).Dispose();
        }

        public virtual void OpenDocument()
        {
            Console.WriteLine("Document is opened");
            Console.WriteLine(File.ReadAllText(filePath));
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing the document is available in the Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving the document is available in the Pro version");
        }
    }
}
