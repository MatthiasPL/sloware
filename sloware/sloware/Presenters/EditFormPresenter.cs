using sloware.Classes;
using sloware.Classes.Windows;
using sloware.Models;
using sloware.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sloware.Presenters
{
    public class EditFormPresenter
    {
        IEditForm editform;
        Model model;
        Word tempWord;
        List<Translation> tempTranslations= new List<Translation>();
        List<Example> tempExamples = new List<Example>();
        public EditFormPresenter(Model model, EditForm editform)
        {
            this.model = model;
            this.editform = editform;

            editform.VEventOnAddExample += View_VEventOnAddExample;
            editform.VEventOnAddTranslation += View_VEventOnAddTranslation;
            editform.VEventOnLoad += View_VEventOnLoad;
            editform.VEventOnRemoveExample += View_VEventOnRemoveExample;
            editform.VEventOnRemoveTranslation += View_VEventOnRemoveTranslation;
            editform.VEventOnSubmit += View_VEventOnSubmit;
        }
        public void View_VEventOnLoad(object arg1, EventArgs arg2)
        {
            if (model.GetWordID()!=-1)
            {
                editform.WordText = model.LoadWord(model.GetWordID());

                editform.Translations = model.LoadTranslations(model.GetWordID());
                tempTranslations = model.GetTranslations(model.GetWordID());

                editform.Examples = model.LoadExamples(model.GetWordID());
                tempExamples = model.GetExamples(model.GetWordID());

                editform.LineNumbers = model.ListOfLines(model.LoadExamples(model.GetWordID()));
                Load();
            }
        }
        public void View_VEventOnAddTranslation(object arg1, EventArgs arg2)
        {
            if (editform.TranslationText != "" && editform.Language1 != "")
            {
                Translation tempTranslation = new Translation(editform.TranslationText, editform.Language1);
                tempTranslations.Add(tempTranslation);
                Load();
            }
        }
        public void View_VEventOnRemoveTranslation(object arg1, EventArgs arg2)
        {
            if (editform.SelectedID != -1)
            {
                tempTranslations.RemoveAt(editform.SelectedID);
                Load();
            }
        }
        public void View_VEventOnAddExample(object arg1, EventArgs arg2)
        {
            if (editform.Example != "" && editform.ExampleTranslation != "" && editform.Language2 != "")
            {
                Example tempExample = new Example(editform.Example, editform.ExampleTranslation, editform.Language2);
                if (editform.Examples.Contains(editform.ExampleTranslation) == false)
                {
                    tempExamples.Add(tempExample);
                    Load();
                }
            }
        }
        public void View_VEventOnRemoveExample(object arg1, EventArgs arg2)
        {
            try{
                string newexamples = "";
                List<string> examples = new List<string>(editform.Examples.Split('\r'));

                for (int i = 0; i < examples.Count -1; i++)
                {
                    if(i!=editform.LineNumber-1)
                        newexamples += examples[i] + '\n';
                }

                List<Example> temporaryexamples = new List<Example>();
                for(int i = 0; i < tempExamples.Count; i++)
                {
                    if (i != editform.LineNumber - 1)
                        temporaryexamples.Add(tempExamples[i]);
                }

                tempExamples.Clear();
                tempExamples = temporaryexamples;

                Load();
            }
            catch
            {

            }
        }
        public void View_VEventOnSubmit(object arg1, EventArgs arg2)
        {
            if (editform.WordText != "")
            {
                Button tempButton = editform.ButtonSubmit;
                tempButton.DialogResult = DialogResult.OK;
                editform.ButtonSubmit = tempButton;
                tempWord = new Word(editform.WordText,tempTranslations,tempExamples);
                //if(!model.LoadDictionary().Words.Contains(tempWord))
                if(model.GetWordID()==-1)
                    model.AddWordToDictionary(tempWord);
            }
            else
            {
                model.ShowErrorBox("Please type the word.", "Error");
            }
        }
        private void Load()
        {
            editform.Translations = model.LoadTranslations(tempTranslations);
            editform.Examples = model.LoadExamples(tempExamples);
            editform.LineNumbers = model.ListOfLines(editform.Examples);
        }
    }
}
