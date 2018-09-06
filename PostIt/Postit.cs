using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace PostIt
{
    class Postit
    {

        public int _id { get; set; }
        public string _contenu { get; set; }
        public int _posX { get; set; }
        public int _posY { get; set; }
        private string _color { get; set; }
        private bool newPostit;

        //Const pour load les post-it déjà existant
        public Postit(int id, string contenu, int posX, int posY, string color)
        {
            this._id = id;
            this._contenu = contenu;
            this._posX = posX;
            this._posY = posY;
            this._color = color;
        }
        //Const pour nouveau postit
        public Postit(int id)
        {
            this._id = id;
        }

        public void Init()
        {

            if (_id == 0)
            {
                newPostit = true;
            }


            //Generate Form
            Form genForm = new Form();
            genForm.Size = new Size(240, 240);
            genForm.ShowInTaskbar = false;

            //Add contenu
            RichTextBox TxtContenu = new RichTextBox();
            TxtContenu.BorderStyle = BorderStyle.None;
            TxtContenu.Text = this._contenu;
            TxtContenu.Dock = DockStyle.Fill;
           // TxtContenu.ReadOnly = true;
            TxtContenu.Font = new Font("Tahoma", TxtContenu.Font.Size);
            TxtContenu.Font = new Font(TxtContenu.Font.FontFamily, 16);
            if (_color == "" || _color == null)
            {
                TxtContenu.BackColor = Color.FromName("Khaki");
                //On colore aussi le genform pour le padding setter plus bas
                genForm.BackColor = Color.FromName("Khaki");
                _color = "Khaki";
            } else
            {
                TxtContenu.BackColor = Color.FromName(_color);
                genForm.BackColor = Color.FromName(_color);
            }

            //Afficher / Cacher la scrollbar quand la souris passe dessus le post-it
            //Set le scroll à None :
            TxtContenu.ScrollBars = RichTextBoxScrollBars.None;
            //Ajout des events :
            TxtContenu.MouseHover += AfficherScroll;
            TxtContenu.MouseLeave += CacherScroll;

            void AfficherScroll(object sender, EventArgs e)
            {
                TxtContenu.ScrollBars = RichTextBoxScrollBars.Vertical;
            }

            void CacherScroll(object sender, EventArgs e)
            {
                TxtContenu.ScrollBars = RichTextBoxScrollBars.None;
            }

            //Sert à cacher la barre de scroll...
            //Si j'active ça, il faudrai ajouter des events scrollUp, scrollDown pour défiler le texte...
            //test fonction, bof... à revoir
            //TxtContenu.ScrollBars = RichTextBoxScrollBars.None;
            //TxtContenu.MouseWheel += new MouseEventHandler(richTextBox1_MouseWheel);
            //void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
            //{
            //    if (e.Delta > 0)
            //    {
            //        //Handle mouse move upwards
            //        if (TxtContenu.SelectionStart > 10)
            //        {
            //            TxtContenu.SelectionStart -= 10;
            //            TxtContenu.ScrollToCaret();
            //        }
            //    }
            //    else
            //    {
            //        //Mouse move downwards.
            //        TxtContenu.SelectionStart += 10;
            //        TxtContenu.ScrollToCaret();
            //    }
            //}

            //Ajoute un padding de 10
            genForm.Padding = new Padding(10);
            genForm.Controls.Add(TxtContenu);

            //Cache les fenêtres quand on fait un alt+tab
            genForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            genForm.ShowInTaskbar = false;


            // BLOC EDITION
            TxtContenu.KeyPress += new KeyPressEventHandler(KeyPress);

            void KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Escape))
                {
                    TxtContenu.Enabled = false;
                    UpdateXml(_id, TxtContenu.Text);

                }

                // Fonctionne : si shift appuyé, rentre dans la condition
                //if (Control.ModifierKeys == Keys.Shift)
                //{
                //    // Si enter est appuyé après shift...
                //    if (e.KeyChar == Convert.ToChar(Keys.Escape))
                //    {
                //        TxtContenu.Enabled = false;

                //    }
                //}
            }

            // FIN BLOC EDITION

            genForm.Deactivate += (sender, e) => UpdateXml(_id, TxtContenu.Text);


            //Click menu
            ContextMenuStrip clickMenu = new ContextMenuStrip();

            // Ajout d'un item "Fermer"
            ToolStripItem itemFermer = clickMenu.Items.Add("Fermer (sans la supprimer)");
            itemFermer.Click += (_, args) =>
            {
                genForm.Close();
            };

            // Supprimer postit
            ToolStripItem itemSupprimer = clickMenu.Items.Add("Supprimer");
            itemSupprimer.Click += (_, args) =>
            {
                DialogResult result = MessageBox.Show("Etes-vous certain de vouloir supprimer ce post-it ?", "Suppression...", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SupprimerPostit(_id.ToString());
                    genForm.Close();
                }
               
                
            };

            //Ajout bouton SAVE
            //ToolStripItem itemSave = clickMenu.Items.Add("Save");
            //itemSave.Click += (_, args) =>
            //{
            //    UpdatePos(_id, genForm.Location.X, genForm.Location.Y);
            //};

            ToolStripItem itemChangecolor = clickMenu.Items.Add("Changer la couleur");
            itemChangecolor.Click += (_, args) =>
            {

                UpdateXml(_id, TxtContenu.Text);
                ChangeColor color = new ChangeColor();
                color.idPostit = _id;
                color.ShowDialog();
                genForm.BackColor = UpdateColorForm(_id);
                TxtContenu.BackColor = UpdateColorForm(_id);

            };

            

            //Ajout d'un event "ResizeEnd" permettant l'update de la position dans le fichier xml
            // Dés qu'on déplace la fenêtre. Bizarrement ça fonctionne sur cet event.
            genForm.ResizeEnd += (sender, eventArgs) => {
                UpdatePos(_id, genForm.Location.X, genForm.Location.Y);
            };

            TxtContenu.ContextMenuStrip = clickMenu;
            
            genForm.Show();

            //Location (à faire aprés le Show, sinon marche pas)
            genForm.Location = new Point(_posX, _posY);

            //Generate ID
            if (newPostit)
            {

                generateId();
                AjouterXml();
                genForm.StartPosition = FormStartPosition.CenterParent;

            }
        }







        

        public void generateId()
        {

            Random rnd = new Random();
            int genId = rnd.Next(1, 9999);

            //TODO : Check si ID existe déjà
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("conf.xml");
            List<int> listId = new List<int>();

            //Remplissage de tous les ID existants dans une liste
            foreach (XmlNode node in xmlDoc.SelectNodes("//postit"))
            {
                if (node.Attributes != null)
                {
                    listId.Add(Convert.ToInt32(node.Attributes["id"].Value));
                }
            }

            //TODO Si l'id généré existe, en re-générer un... et re-check... à voir.

            this._id = genId;
        }






            private Color UpdateColorForm(int id)
        {
            _id = id;
            string recup = "";
            XmlDocument doc = new XmlDocument();
            string path = @"conf.xml";
            doc.Load(path);
            IEnumerator ie = doc.SelectNodes("/conf/postit").GetEnumerator();

            while (ie.MoveNext())
            {
                if ((ie.Current as XmlNode).Attributes["id"].Value == _id.ToString())
                {
                    recup = (ie.Current as XmlNode).Attributes["color"].Value; 
                }
            }
                    return Color.FromName(recup);


        }




        public void SupprimerPostit(string id)
        {
            XDocument doc = XDocument.Load(@"conf.xml");
            var q = from node in doc.Descendants("postit")
                    let attr = node.Attribute("id")
                    where attr != null && attr.Value == id
                    select node;
            q.ToList().ForEach(x => x.Remove());
            doc.Save(@"conf.xml");
        }








        public void UpdateXml(int id, string contenu)
        {
            XmlDocument doc = new XmlDocument();
            string path = @"conf.xml";
            doc.Load(path);
            IEnumerator ie = doc.SelectNodes("/conf/postit").GetEnumerator();

            while (ie.MoveNext())
            {
                if ((ie.Current as XmlNode).Attributes["id"].Value == id.ToString())
                {
                    (ie.Current as XmlNode).Attributes["contenu"].Value = contenu;
                }
            }

            doc.Save(path);
        }









        public void UpdatePos(int id, int posX, int posY)
        {
            XmlDocument doc = new XmlDocument();
            string path = @"conf.xml";
            doc.Load(path);
            IEnumerator ie = doc.SelectNodes("/conf/postit").GetEnumerator();

            while (ie.MoveNext())
            {
                if ((ie.Current as XmlNode).Attributes["id"].Value == id.ToString())
                {
                    (ie.Current as XmlNode).Attributes["posX"].Value = posX.ToString();
                    (ie.Current as XmlNode).Attributes["posY"].Value = posY.ToString();
                }
            }

            doc.Save(path);
        }










        public void AjouterXml()
        {
            string filename = @"conf.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            //XmlElement root = doc.CreateElement("postit");
            XmlElement id = doc.CreateElement("postit");
            id.SetAttribute("id", _id.ToString());
            id.SetAttribute("contenu", _contenu);
            id.SetAttribute("posX", _posX.ToString());
            id.SetAttribute("posY", _posY.ToString());
            id.SetAttribute("color", _color.ToString());

            //XmlNode node = doc.CreateNode(XmlNodeType.Element, "postit", null);
            //XmlElement id = doc.CreateElement("id");
            //id.SetAttribute("userName", "Tushar");
            //XmlNode nodeUrl = doc.CreateElement("contenu");
            //nodeUrl.InnerText = _contenu;

            //root.AppendChild(id);
            //root.AppendChild(nodeTitle);
            //root.AppendChild(nodeUrl);
            doc.DocumentElement.AppendChild(id);
            doc.Save(filename);
        }

        //public int checkIfIdExist(int targetId)
        //{

        //    if (File.Exists(@"test.json"))
        //    {
        //        StreamReader r = new StreamReader(@"test.json");

        //        string json = r.ReadToEnd();
        //        List<Postit> items = JsonConvert.DeserializeObject<List<Postit>>(json);

        //        for (int i = 0; i < items.Count; i++)
        //        {
        //            if (items[i]._id == targetId)
        //            {
        //                //A voir car il ne faut pas qu'il génère un ID à chaque fois
        //            }
        //        }
        //    }
        //}

    }
}
