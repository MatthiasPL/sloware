using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using sloware.Classes;

namespace sloware.Models
{
    class Model
    {
        public Model() { }
        public Dictionary LoadDictionary()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Dictionary));
            Dictionary dictionary = null;
            StreamReader reader = new StreamReader("file.xml");

            dictionary = (Dictionary)serializer.Deserialize(reader);
            reader.Close();

            return dictionary;
        }
        public string[] LoadWords()
        {
            List<string> words = new List<string>();
            foreach (var word in LoadDictionary().Words)
            {
                words.Add(word.WordText.ToString());
                Console.WriteLine(word.WordText.ToString());
            }
            return words.ToArray();
        }
        public string[] LoadExamples()
        {
            List<string> examples = new List<string>();
            foreach(var word in LoadDictionary().Words)
            {
                //word.Examples.
            }
            return examples.ToArray();
        }
        public string[] LoadTranslations(int id)
        {
            List<string> translations = new List<string>();
            foreach (var word in LoadDictionary().Words)
            {
                foreach(var translationlist in word.Translations)
                {
                    translations.Add(translationlist.TranslationText + " | " + translationlist.Language);
                }
            }
            return translations.ToArray();
        }
    }
}
