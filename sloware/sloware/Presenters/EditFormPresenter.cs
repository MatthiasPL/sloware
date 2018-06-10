using sloware.Classes;
using sloware.Classes.Windows;
using sloware.Models;
using sloware.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //submit- directory add word
            //cancel- drop word

            //editform.VEventOnAddExample;
            editform.VEventOnAddTranslation+= View_VEventOnAddTranslation;
            //editform.VEventOnCancel;
            editform.VEventOnLoad+=View_VEventOnLoad;
            //editform.VEventOnRemoveExample;
            //editform.VEventOnRemoveTranslation;
            //editform.VEventOnSubmit;
        }
        public void View_VEventOnLoad(object arg1, EventArgs arg2)
        {
            if (model.getWordID()!=-1)
            {
                editform.Translations = model.LoadTranslations(model.getWordID());
            }
        }
        public void View_VEventOnAddTranslation(object arg1, EventArgs arg2)
        {
            Translation tempTranslation = new Translation(editform.TranslationText, editform.Language1);
            tempTranslations.Add(tempTranslation);
            editform.Translations = model.LoadTranslations(tempTranslations);
        }
    }
}
