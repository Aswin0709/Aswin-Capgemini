using Assignment7Qthree;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

class EmployeeManagement3
{
    public static void Main()
    {
        



        Console.WriteLine("Enter the name of the manager");
        string name= Console.ReadLine();
        Console.WriteLine("Enter employee id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the salary of the manager");
        double salary = double.Parse(Console.ReadLine());
        Manager manager = new Manager(id, name, salary);
        Stream stream = File.Open(@"D:\serialisation\manager.txt",FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(stream, manager);
        stream.Close();


        stream = File.Open(@"D:\serialisation\manager.txt", FileMode.Open);
        binaryFormatter = new BinaryFormatter();
        Manager manager2;
        manager2 = (Manager)binaryFormatter.Deserialize(stream);
        stream.Close();
        Console.WriteLine(manager.ToString());
        


    }

}
