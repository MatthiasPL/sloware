using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sloware.Views;
using sloware.Models;
using sloware.Classes;
using sloware.Classes.Windows;

namespace sloware.Presenters
{
    class SlowarFormPresenter
    {
        ISlowarForm slowarform;
        Model model;
        EditForm editform = new EditForm();
        public SlowarFormPresenter(Model model, SlowarForm slowarform)
        {
            this.model = model;
            this.slowarform = slowarform;

            slowarform.VEventOnWordSelect += View_VEventOnWordSelect;
            slowarform.VEventOnLoad += View_VEventOnLoad;
            slowarform.VEventOnRemove += View_VEventOnRemove;
            slowarform.VEventOnAdd += View_VEventOnAdd;
            slowarform.VEventOnEdit += View_VEventOnEdit;
        }

        public void View_VEventOnLoad(object arg1, EventArgs arg2)
        {
            model.LoadDictionaryFromFile();
            slowarform.WordList = model.LoadWords();
        }
        public void View_VEventOnRemove(object arg1, EventArgs arg2)
        {
            if (slowarform.SelectedID != -1)
            {
                model.RemoveWord(slowarform.SelectedID);
                slowarform.WordList = model.LoadWords();
            }
        }
        public void View_VEventOnAdd(object arg1, EventArgs arg2)
        {
            slowarform.SelectedID = -1;
            model.setWordID(slowarform.SelectedID);
            EditForm editform = new EditForm();
            EditFormPresenter editformpresenter = new EditFormPresenter(model, editform);
            editform.Show();
        }
        public void View_VEventOnEdit(object arg1, EventArgs arg2)
        {
            if (slowarform.SelectedID != -1)
            {
                model.setWordID(slowarform.SelectedID);
                EditForm editform = new EditForm();
                EditFormPresenter editformpresenter = new EditFormPresenter(model, editform);
                editform.Show();
            }
        }
        public void View_VEventOnWordSelect(object arg1, EventArgs arg2)
        {
            if (slowarform.SelectedID != -1)
            {
                slowarform.TranslationList = model.LoadTranslations(slowarform.SelectedID);
                slowarform.Examples = model.LoadExamples(slowarform.SelectedID);
            }
        }
    }
}
