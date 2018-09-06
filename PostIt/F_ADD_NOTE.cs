using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostIt
{
    public partial class F_ADD_NOTE : Form
    {
        public F_ADD_NOTE()
        {
            InitializeComponent();
        }

        private void Btn_addPostit_Click(object sender, EventArgs e)
        {
            //Postit postit = new Postit(0, txt_contenu.Text);
            //postit.Init();
            //this.Close();
        }

        private void F_ADD_NOTE_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("tt");
        }

        private void F_ADD_NOTE_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("tt");
        }
    }
}
