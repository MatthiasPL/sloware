using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sloware.Views;

namespace sloware.Classes.Windows
{
    public partial class EditForm : Form, IEditForm
    {
        public EditForm()
        {
            InitializeComponent();
        }

        public string Example
        {
            get
            {
                return textBoxExample.Text;
            }
        }

        public string Examples
        {
            set
            {
                textBoxExamples.Text = value;
            }
        }

        public string ExampleTranslation
        {
            get
            {
                return textBoxExampleTranslation.Text;
            }
        }

        public string Language1
        {
            get
            {
                return comboBoxLanguage1.Text;
            }
        }

        public string Language2
        {
            get
            {
                return comboBoxLanguage2.Text;
            }
        }

        public string[] Translations
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

        public string TranslationText
        {
            get
            {
                return textBoxTranslation.Text;
            }
        }

        public string WordText
        {
            get
            {
                return textBoxWord.Text;
            }
        }

        public event Action<object, EventArgs> VEventOnAddExample;
        public event Action<object, EventArgs> VEventOnAddTranslation;
        public event Action<object, EventArgs> VEventOnCancel;
        public event Action<object, EventArgs> VEventOnLoad;
        public event Action<object, EventArgs> VEventOnRemoveExample;
        public event Action<object, EventArgs> VEventOnRemoveTranslation;
        public event Action<object, EventArgs> VEventOnSubmit;

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (VEventOnLoad != null)
            {
                VEventOnLoad(sender, e);
            }
        }

        private void buttonRemoveTranslation_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveExample_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddExample_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTranslation_Click(object sender, EventArgs e)
        {
            if (VEventOnAddTranslation != null)
            {
                VEventOnAddTranslation(sender, e);
            }
        }
    }
}
