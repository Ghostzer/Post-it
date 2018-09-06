using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PostIt
{
    public partial class ChangeColor : Form
    {

        public int idPostit;

        public ChangeColor()
        {
            InitializeComponent();
        }

        private void UpdateColor(int id, Panel pan)
        {
            idPostit = id;
            XmlDocument doc = new XmlDocument();
            string path = @"conf.xml";
            doc.Load(path);
            IEnumerator ie = doc.SelectNodes("/conf/postit").GetEnumerator();

            while (ie.MoveNext())
            {
                if ((ie.Current as XmlNode).Attributes["id"].Value == idPostit.ToString())
                {
                    (ie.Current as XmlNode).Attributes["color"].Value = pan.BackColor.Name;
                }
            }

            doc.Save(path);
            this.Close();
        }

        private void pan_Khaki_Click(object sender, EventArgs e)
        {
            UpdateColor(idPostit, pan_Khaki);
        }

        private void pan_LigthSkyBlue_Click(object sender, EventArgs e)
        {
            UpdateColor(idPostit, pan_LigthSkyBlue);
        }

        private void pan_GreenYellow_Click(object sender, EventArgs e)
        {
            UpdateColor(idPostit, pan_GreenYellow);
        }

        private void pan_Violet_Click(object sender, EventArgs e)
        {
            UpdateColor(idPostit, pan_Violet);
        }

    }
}
