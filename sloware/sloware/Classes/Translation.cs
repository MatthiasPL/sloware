using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sloware.Classes
{
    public class Translation
    {
        public Translation() { }
        public Translation(string translationtext, string language)
        {
            this.TranslationText = translationtext;
            this.Language = language;
        }
        public string TranslationText { get; set; }
        public string Language { get; set; }
    }
}
