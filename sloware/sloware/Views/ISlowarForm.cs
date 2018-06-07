using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sloware.Views
{
    interface ISlowarForm
    {
        event Action<object, EventArgs> VEventOnLoad;
        event Action<object, EventArgs> VEventOnRemove;
        event Action<object, EventArgs> VEventOnEdit;
        event Action<object, EventArgs> VEventOnAdd;
        event Action<object, EventArgs> VEventOnWordSelect;

        string[] WordList { set; }
        string[] TranslationList { set; }
        string Examples { set; }
    }
}
