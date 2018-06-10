using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using sloware.Classes;
using System.Windows.Forms;

namespace sloware.Models
{
    public class Model
    {
        public Model() { }
        private Dictionary dictionary;
        private int wordID=-1;
        #region Dictionary
        public void AddWord(string wordtext, string language,List<Translation> translations, List<Example> examples)
        {
            this.dictionary.Words.Add(new Word(wordtext, language, translations, examples));
            SaveDictionaryToFile(dictionary);
        }
        public void AddWord()
        {
            this.dictionary.Words.Add(new Word());
        }
        public void AddWord(string wordtext, string language)
        {
            this.dictionary.Words.Add(new Word(wordtext, language));
        }
        public void AddTranslation(string translationtext, string language, int wordid)
        {
            this.dictionary.Words[wordid].Translations.Add(new Translation(translationtext, language));
        }
        public void AddExample(string exampletext, string exampletranslation, string language, int wordid)
        {
            this.dictionary.Words[wordid].Examples.Add(new Example(exampletext, exampletranslation, language));
        }
        public void RemoveWord(int wordid)
        {
            this.dictionary.Words.RemoveAt(wordid);
        }
        #endregion
        public void LoadDictionaryFromFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Dictionary));
            Dictionary dictionary = null;
            StreamReader reader = new StreamReader("file.xml");

            dictionary = (Dictionary)serializer.Deserialize(reader);
            reader.Close();

            this.dictionary = dictionary;
        }
        public void SaveDictionaryToFile(Dictionary dictionary)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Dictionary));
            serializer.Serialize(File.Create("file.xml"), dictionary);
        }
        public Dictionary LoadDictionary()
        {
            return this.dictionary;
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
        public string[] LoadTranslations(int id)
        {
            List<string> translations = new List<string>();

            for(int i = 0; i < LoadDictionary().Words[id].Translations.Count(); i++)
            {
                translations.Add(LoadDictionary().Words[id].Translations[i].TranslationText + " | " + LoadDictionary().Words[id].Translations[i].Language);
            }

            return translations.ToArray();
        }
        public string[] LoadTranslations(List<Translation> translations)
        {
            List<string> stringTranslations = new List<string>();

            for(int i = 0; i < translations.Count(); i++)
            {
                stringTranslations.Add(translations[i].TranslationText + " | " + translations[i].Language);
            }

            return stringTranslations.ToArray();
        }

        public string LoadExamples(int id)
        {
            string examples = "";

            for (int i = 0; i < LoadDictionary().Words[id].Examples.Count(); i++)
            {
                examples=examples+ LoadDictionary().Words[id].Examples[i].ExampleText + " | " + LoadDictionary().Words[id].Examples[i].ExampleTranslation + " | " + LoadDictionary().Words[id].Examples[i].Language + "\n";
            }

            return examples;
        }
        public void DisableForm(Form form)
        {
            form.Enabled = false;
        }
        public void setWordID(int id)
        {
            wordID = id;
        }
        public int getWordID()
        {
            return wordID;
        }
    }
}
