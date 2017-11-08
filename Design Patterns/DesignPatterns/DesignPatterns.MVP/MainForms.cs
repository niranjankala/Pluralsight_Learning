using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.MVP
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void btnSetTextValue_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadSimpleMVPExample_Click(object sender, EventArgs e)
        {
            SimpleMVPExample.SimpleMVPExampleForm frm = new SimpleMVPExample.SimpleMVPExampleForm(new SimpleMVPExample.Entities.Model());
            frm.ShowDialog(this);
        }
    }
}
