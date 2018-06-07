using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sloware.Classes
{
    public class Example
    {
        public Example() { }
        public Example(string exampletext, string exampletranslation, string language)
        {
            this.ExampleText = exampletext;
            this.ExampleTranslation = exampletranslation;
            this.Language = language;
        }
        public string ExampleText { get; set; }
        public string ExampleTranslation { get; set; }
        public string Language { get; set; }

    }
}
