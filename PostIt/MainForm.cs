using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostitDemo
{
    public partial class MainForm : Form
    {
        private Postit currentPostit = null;  // represents the currently selected postit
        private List<Postit> postitList = new List<Postit>();

        private Point ptStartPosition; // the start position of the postit when moving
        private Point ptEndPosition; // the end position of the postit when moving

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            this.currentPostit = sender as Postit;
            this.ptStartPosition = this.PointToScreen(e.Location);            
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor.Current = Cursors.SizeAll;
                this.ptEndPosition = this.currentPostit.PointToScreen(e.Location);                
                ptEndPosition.Offset(-ptStartPosition.X, -ptStartPosition.Y);                
                this.currentPostit.Location = ptEndPosition;
                this.Invalidate();
            }
        }

        private void btnCreatePostit_Click(object sender, EventArgs e)
        {
            Postit postit = new Postit(this.txtMessage.Text, new Font("Comic", 20), 
                Brushes.Green, PostitColor.FlatYellow, this.chkUrgent.Checked);
            postit.Location = new Point(5, 100);
            postit.MouseDown += new MouseEventHandler(this.OnMouseDown);
            postit.MouseMove += new MouseEventHandler(this.OnMouseMove);
            postit.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            this.Controls.Add(postit);

            this.currentPostit = postit;
            this.postitList.Add(postit);
        }
    }
}
