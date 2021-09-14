using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace e2_fileStorage
{
    public class PersonPersistence
    {
        public static void storeObject(List<Person> persons)
        {
            using StreamWriter sw = new StreamWriter("persons.txt");
            string serial = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});
            sw.WriteLine(serial);
        }

        public static List<Person> readObject()
        {
            string serial = File.ReadAllText("persons.txt");
            var blackisback = JsonSerializer.Deserialize<List<Person>>(serial);
            return blackisback;
        }
    }
}