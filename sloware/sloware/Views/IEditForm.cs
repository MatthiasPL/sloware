using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sloware.Views
{
    interface IEditForm
    {
        event Action<object, EventArgs> VEventOnLoad;
        event Action<object, EventArgs> VEventOnAddTranslation;
        event Action<object, EventArgs> VEventOnRemoveTranslation;
        event Action<object, EventArgs> VEventOnAddExample;
        event Action<object, EventArgs> VEventOnRemoveExample;
        event Action<object, EventArgs> VEventOnSubmit;
        event Action<object, EventArgs> VEventOnCancel;

        string WordText { get; set; }
        string[] Translations { set; }
        int SelectedID { get; }
        string Examples { get; set; }
        string TranslationText { get; }
        string Language1 { get; }
        string Language2 { get; }
        string Example { get; }
        string ExampleTranslation { get; }
        int LineNumber { get; }
        string[] LineNumbers { set; }
        Button ButtonSubmit { get; set; }
    }
}
