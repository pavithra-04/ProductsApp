using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serial_Example
{
    //Below Employee Class going to be saved in text file (File IO) using Binary & Soap Serialization.
    //Deserialization using Binary Serialization  
    [Serializable]
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        double sal;
        public double Sal
        {
            get
            {
                return sal;
            }
            set
            {
                sal = value;
            }
        }
        public Employee()
        {
            Eid = 0;
            Ename = string.Empty;
            Sal = 0.00;
        }
        public Employee(int Eid, string Ename, double Sal)
        {
            this.Eid = Eid;
            this.Ename = Ename;
            this.Sal = Sal;
        }
    }
    internal class Program
    {
        public void savedatainfile()
        {
            FileStream fs = new FileStream(@"Sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Employee emp = new Employee(Eid: 10, Ename: "Krish", Sal: 200.92);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(emp.Eid);
            sw.WriteLine(emp.Ename);
            sw.WriteLine(emp.Sal); sw.Close(); Console.WriteLine("Data Saved Successfully");
        }
        public void BinSerializeData()
        {
            Employee emp = new Employee(Eid: 50, Ename: "Meena", Sal: 520.123); 
            FileStream fs = new FileStream(@"Emp.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); 
            BinaryFormatter bf = new BinaryFormatter(); 
            bf.Serialize(fs, emp); 
            fs.Close();
            Console.WriteLine("Binary Data Serialized Successfully");
        }

        public void DeSerilizeData()
        {
            FileStream fs = new FileStream(@"Emp.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Employee result = (Employee)bf.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Data Deserialized Successfully"); 
            Console.WriteLine("Emp ID: {0} having Name of: {1} getting Salary of: {2}", result.Eid, result.Ename, result.Sal);
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            //prog.savedatainfile();
            prog.BinSerializeData();
            prog.DeSerilizeData(); Console.ReadLine();
        }
    }
}