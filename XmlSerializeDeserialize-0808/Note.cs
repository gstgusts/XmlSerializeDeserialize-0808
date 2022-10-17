using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializeDeserialize_0808
{
    [XmlRoot("note")]
    public class Note
    {
        [XmlElement("to")]
        [JsonPropertyName("to")]
        public string To { get; set; }
        
        [XmlElement("from")]
        [JsonPropertyName("from")]
        public string From { get; set; }

        [XmlElement("heading")]
        [JsonPropertyName("heading")]
        public string Heading { get; set; }

        [XmlElement("body")]
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
