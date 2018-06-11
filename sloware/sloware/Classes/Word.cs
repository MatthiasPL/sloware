using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sloware.Classes
{
    public class Word
    {
        public Word() { }
        public Word(string wordtext, List<Translation> translations, List<Example> examples)
        {
            this.WordText = wordtext;
            //this.Language = language;
            this.Translations = translations;
            this.Examples = examples;
        }
        public Word(string wordtext)
        {
            this.WordText = wordtext;
        }
        public string WordText { get; set; }
        //public string Language { get; set; }
        [XmlArray("Translations")]
        [XmlArrayItem("Translation")]
        public List<Translation> Translations { get; set; }
        [XmlArray("Examples")]
        [XmlArrayItem("Example")]
        public List<Example> Examples { get; set; }
    }
}
