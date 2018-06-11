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
        public void AddWordToDictionary(Word word)
        {
            this.dictionary.Words.Add(word);
        }
        public void AddWord(string wordtext, List<Translation> translations, List<Example> examples)
        {
            this.dictionary.Words.Add(new Word(wordtext, translations, examples));
            SaveDictionaryToFile(dictionary);
        }
        public void AddWord()
        {
            this.dictionary.Words.Add(new Word());
        }
        public void AddWord(string wordtext)
        {
            this.dictionary.Words.Add(new Word(wordtext));
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
            }
            return words.ToArray();
        }
        public string LoadWord(int wordID)
        {
            return dictionary.Words[wordID].WordText;
        }
        public List<Translation> GetTranslations(int wordID)
        {
            return dictionary.Words[wordID].Translations;
        }
        public List<Example> GetExamples(int wordID)
        {
            return dictionary.Words[wordID].Examples;
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
                examples=examples+ LoadDictionary().Words[id].Examples[i].ExampleText + " | " + LoadDictionary().Words[id].Examples[i].ExampleTranslation + " | " + LoadDictionary().Words[id].Examples[i].Language + "\r\n";
            }

            return examples;
        }
        public string LoadExamples(List<Example> examples)
        {
            string stringExamples = "";

            for (int i = 0; i < examples.Count(); i++)
            {
                stringExamples = stringExamples + examples[i].ExampleText + " | " + examples[i].ExampleTranslation + " | " + examples[i].Language + "\r\n";
            }

            return stringExamples;
        }
        public void DisableForm(Form form)
        {
            form.Enabled = false;
        }
        public void SetWordID(int id)
        {
            wordID = id;
        }
        public int GetWordID()
        {
            return wordID;
        }
        public int GetNumberOfLines(string text)
        {
            int counter = text.Count(f => f == '\r') - 1;
            return counter;
        }
        public string[] ListOfLines(string text)
        {
            int counter = text.Count(f => f == '\r') + 1;
            List<string> listOfLines = new List<string>();

            for(int i = 1; i < counter; i++)
            {
                listOfLines.Add((i).ToString());
            }

            return listOfLines.ToArray();
        }
        public void ShowErrorBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void RemoveTheSame()
        {
            List<Word> words = new List<Word>();
            for(int i = 0; i < dictionary.Words.Count; i++)
            {
                foreach(var wordtext in dictionary.Words)
                {

                }
            }
        }
    }
}
