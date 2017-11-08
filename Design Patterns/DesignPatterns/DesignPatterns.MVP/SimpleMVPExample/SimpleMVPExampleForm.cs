using DesignPatterns.MVP.SimpleMVPExample.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.MVP.SimpleMVPExample
{
    public partial class SimpleMVPExampleForm : Form, DesignPatterns.MVP.SimpleMVPExample.Entities.IView
    {
        SimpleMVPExamplePresenter presenter = null;
        Model model = null;    
        public SimpleMVPExampleForm(Model simpleMVPModel)
        {
            this.model = simpleMVPModel;
            InitializeComponent();
            presenter = new SimpleMVPExamplePresenter(this, model);
            SubscribeToModelEvents();
        }

        public string TextValue
        {
            get
            {
                return txtTextValue.Text;
            }
            set
            {
                txtTextValue.Text = value;
            }
        }

        private void SimpleExampleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSetTextValue_Click(object sender, EventArgs e)
        {
            presenter.SetTextValue();
        }

        private void btnReverseText_Click(object sender, EventArgs e)
        {
            presenter.ReverseTextValue();
        }
        private void SubscribeToModelEvents()
        {

            model.TextSet += model_TextSet;
        }

        void model_TextSet(object sender, ValueChangeArgs e)
        {
            txtTextValue.Text = e.NewValue;
            lblResult.Text = string.Format("Text changed from {0} to {1}", e.PreviousValue, e.NewValue);
        }
        
    }
}
