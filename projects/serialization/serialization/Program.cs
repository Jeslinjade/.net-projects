using System;
using System.IO;

namespace DemoApplication
{
    class Tutorial
    {
        public int ID { get; set; }
        public string Name { get; set; }=string.Empty;

        static void Main(string[] args)
        {
            // Create a new Tutorial object
            Tutorial obj = new Tutorial
            {
                ID = 1,
                Name = "Serialization Example"
            };

            // Serialize the object using BinaryWriter
            using (FileStream fs = new FileStream(@"E:\ExampleNew.bin", FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(obj.ID);
                writer.Write(obj.Name);
            }

            // Deserialize the object using BinaryReader
            Tutorial objnew = new Tutorial();
            using (FileStream fs = new FileStream(@"E:\ExampleNew.bin", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                objnew.ID = reader.ReadInt32();
                objnew.Name = reader.ReadString();
            }

            // Output the deserialized object
            Console.WriteLine("ID: " + objnew.ID);
            Console.WriteLine("Name: " + objnew.Name);

            Console.ReadKey();
        }
    }
}
