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
    public partial class F_CHANGE_COLOR : Form
    {

        public int idPostit;
        private Form nomForm;
        private Panel panelPostit;
        private double nOpacity;
        private Color nomColor;

        public F_CHANGE_COLOR()
        {
            InitializeComponent();
        }

        public F_CHANGE_COLOR(Form nomDeLaForm, double opacity) 
        {
            nomForm = nomDeLaForm;
            nOpacity = opacity;
            InitializeComponent();
        }

        public F_CHANGE_COLOR(Form nomDeLaForm, Color color, double opacity)
        {
            nomForm = nomDeLaForm;
            nOpacity = opacity;
            nomColor = color;
            InitializeComponent();
        }

        private void UpdateColor(int id, Panel pan)
        {
            idPostit = id;
            panelPostit = pan;
            XmlDocument doc = new XmlDocument();
            string path = @"conf.xml";
            doc.Load(path);
            IEnumerator ie = doc.SelectNodes("/conf/postit").GetEnumerator();

            while (ie.MoveNext())
            {
                if ((ie.Current as XmlNode).Attributes["id"].Value == idPostit.ToString())
                {
                    (ie.Current as XmlNode).Attributes["color"].Value = pan.BackColor.Name;
                    (ie.Current as XmlNode).Attributes["opacity"].Value = nomForm.Opacity.ToString();
                }
            }

            doc.Save(path);

            //this.Close();
        }

        private void pan_Khaki_Click(object sender, EventArgs e)
        {
            ActionClicPanel(sender);
        }

        private void pan_LigthSkyBlue_Click(object sender, EventArgs e)
        {
            ActionClicPanel(sender);
        }

        private void pan_LightGreen_Click(object sender, EventArgs e)
        {
            ActionClicPanel(sender);
        }

        private void pan_Thistle_Click(object sender, EventArgs e)
        {
            ActionClicPanel(sender);
        }

        private void trackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            nomForm.Opacity = ((double)(Tb_opacity.Value) / 10.0);
            Lbl_opacity.Text = "Opacity : " + nomForm.Opacity.ToString();
        }

        private void F_CHANGE_COLOR_Load(object sender, EventArgs e)
        {
            Lbl_opacity.Text = "Opacity : " + nOpacity;
            Tb_opacity.Value = Convert.ToInt32(nOpacity * 10);

            SelectPanel(nomColor);

        }

        private void Btn_closeChangeColor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectPanel(Color c)
        {

            //Todo refactoring, sans "écrit en dur"

            switch (c.Name)
            {
                case "Khaki":
                    pan_Khaki.BorderStyle = BorderStyle.FixedSingle;
                    pan_LigthSkyBlue.BorderStyle = BorderStyle.None;
                    pan_LightGreen.BorderStyle = BorderStyle.None;
                    pan_Thistle.BorderStyle = BorderStyle.None;
                    break;
                case "LightSkyBlue":
                    pan_LigthSkyBlue.BorderStyle = BorderStyle.FixedSingle;
                    pan_Khaki.BorderStyle = BorderStyle.None;
                    pan_LightGreen.BorderStyle = BorderStyle.None;
                    pan_Thistle.BorderStyle = BorderStyle.None;
                    break;
                case "LightGreen":
                    pan_LightGreen.BorderStyle = BorderStyle.FixedSingle;
                    pan_Khaki.BorderStyle = BorderStyle.None;
                    pan_LigthSkyBlue.BorderStyle = BorderStyle.None;
                    pan_Thistle.BorderStyle = BorderStyle.None;
                    break;
                case "Thistle":
                    pan_Thistle.BorderStyle = BorderStyle.FixedSingle;
                    pan_Khaki.BorderStyle = BorderStyle.None;
                    pan_LigthSkyBlue.BorderStyle = BorderStyle.None;
                    pan_LightGreen.BorderStyle = BorderStyle.None;
                    break;
            }
        }

        // Methode qui update la couleur dans le xml et séléctionne le bon panel
        // en envoyant directement le bon panel en paramètre.
        private void ActionClicPanel(object sender)
        {
            Panel panelSender = (Panel)sender;
            UpdateColor(idPostit, panelSender);
            SelectPanel(Color.FromName(panelSender.BackColor.Name));
        }
    }
}
