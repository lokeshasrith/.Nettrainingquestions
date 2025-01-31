using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_training
{
    public class FileHandlingdemo
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public FileHandlingdemo(int id, string Name, string Description, string Type)
        {
            Id = id;
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
        }

        public void CreateTransaction()
        {
            FileStream fs = new FileStream("transaction.txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Id : " + Id);
            sw.WriteLine("Name : " + Name);
            sw.WriteLine("Description : " + Description);
            sw.WriteLine("Type : " + Type);
            sw.Close();
        }
        public void ReadTransaction()   // these method will show the output in the console
        {
            FileStream fs = new FileStream("transaction.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            fs.Close();
        }
    }
}

// object
FileHandlingdemo transaction = new FileHandlingdemo(4405, "LA", "Purchase", "Debit");

transaction.ReadTransaction();
