using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sloware.Classes
{
    public class Dictionary
    {
        public Dictionary() { }
        [XmlArray("Words")]
        [XmlArrayItem("Word")]
        public List<Word> Words { get; set; }
    }
}
