using System.Xml;
using System.Xml.Serialization;

namespace XmlSerializeDeserialize_0808
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var note = new Note()
            {
                To = "Gusts",
                From = "Gusts",
                Heading = "Some news",
                Body = "ajsdk ljas;kdf jas;kdf as;kdfkdffjkf"
            };

            XmlSerializer xsSubmit = new XmlSerializer(typeof(Note));

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, note);
                    Console.WriteLine(sww.ToString());
                }
            }



            using (var stream = System.IO.File.OpenRead("note.xml"))
            {
                var serializer = new XmlSerializer(typeof(Note));
                var note2 = serializer.Deserialize(stream) as Note;

                Console.WriteLine(note2.From);
            }

            
        }
    }
}