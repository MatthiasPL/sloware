using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sloware.Classes;
using sloware.Views;

namespace sloware
{
    public partial class SlowarForm : Form, ISlowarForm
    {
        public SlowarForm()
        {
            InitializeComponent();
        }

        #region interface
        public string Examples
        {
            set
            {
                if (value != null)
                {
                    textBoxExamples.Clear();
                    textBoxExamples.Text = value;
                }
            }
        }

        public string[] TranslationList
        {
            set
            {
                if (value != null)
                {
                    listBoxTranslations.Items.Clear();
                    listBoxTranslations.Items.AddRange(value);
                }
            }
        }

        public string[] WordList
        {
            set
            {
                if(value != null)
                {
                    listBoxWords.Items.Clear();
                    listBoxWords.Items.AddRange(value);
                }
            }
        }

        public event Action<object, EventArgs> VEventOnAdd;
        public event Action<object, EventArgs> VEventOnEdit;
        public event Action<object, EventArgs> VEventOnLoad;
        public event Action<object, EventArgs> VEventOnRemove;
        public event Action<object, EventArgs> VEventOnWordSelect;

        #endregion
        private void listBoxWords_Click(object sender, EventArgs e)
        {
            if (VEventOnWordSelect != null)
            {
                VEventOnWordSelect(sender, e);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (VEventOnRemove != null)
            {
                VEventOnRemove(sender, e);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (VEventOnEdit != null)
            {
                VEventOnEdit(sender, e);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (VEventOnAdd != null)
            {
                VEventOnAdd(sender, e);
            }
        }

        private void SlowarForm_Load(object sender, EventArgs e)
        {
            if (VEventOnLoad != null)
            {
                VEventOnLoad(sender, e);
            }
        }
    }
}
