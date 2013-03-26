using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class NamePlayerUserControl : UserControl
    {
        // Delegates
        public delegate void ValidButtonClickHandler(object sender, EventArgs e);
        public delegate void CancelButtonClickHandler(object sender, EventArgs e);

        // Déclaration des évènements qui utilisent ces délégués
        [Category("Configuration"), Browsable(true), Description("valid button event")]
        public event ValidButtonClickHandler BoutonValidClick;

        [Category("Configuration"), Browsable(true), Description("cancel button event")]
        public event CancelButtonClickHandler BoutonCancelClick;

        public NamePlayerUserControl()
        {
            InitializeComponent();
            
        }


        [Category("Configuration"), Browsable(true), Description("Text to display for th name")]
        public String LoginText
        {
            get
            {
                return this.nameLabel.Text;
            }
            set
            {
                this.nameLabel.Text = value;
            }
        }

        protected virtual void OnValidButtonClick(EventArgs e)
        {
            if (BoutonValidClick != null)
            {
                BoutonValidClick(this, e);
            }
        }

        protected virtual void OnCancelButtonClick(EventArgs e)
        {
            if (BoutonCancelClick != null)
            {
                BoutonCancelClick(this, e);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            OnValidButtonClick(e);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            OnCancelButtonClick(e);
        }

        public TextBox getTB() { return this.textBoxName; }
    }
}
