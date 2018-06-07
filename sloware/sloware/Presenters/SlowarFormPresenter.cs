using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sloware.Views;
using sloware.Models;
using sloware.Classes;

namespace sloware.Presenters
{
    class SlowarFormPresenter
    {
        ISlowarForm slowarform;
        Model model;
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
            slowarform.WordList = model.LoadWords();
            slowarform.TranslationList = model.LoadTranslations();
        }
        public void View_VEventOnRemove(object arg1, EventArgs arg2)
        {

        }
        public void View_VEventOnAdd(object arg1, EventArgs arg2)
        {

        }
        public void View_VEventOnEdit(object arg1, EventArgs arg2)
        {

        }
        public void View_VEventOnWordSelect(object arg1, EventArgs arg2)
        {

        }
    }
}
