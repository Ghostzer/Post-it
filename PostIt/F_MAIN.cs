﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PostIt
{
    public partial class F_MAIN : Form
    {
        public F_MAIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // OK

            RefreshPostit();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ShowInTaskbar = false;

        }

        public void RefreshPostit()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("conf.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("//postit"))
            {
                if (node.Attributes != null)
                {
                    int id = Convert.ToInt32(node.Attributes["id"].Value);
                    //postit._titre = node.Attributes["titre"].Value;
                    string contenu = node.Attributes["contenu"].Value;
                    int posX = Convert.ToInt32(node.Attributes["posX"].Value);
                    int posY = Convert.ToInt32(node.Attributes["posY"].Value);
                    string color = node.Attributes["color"].Value;
                    Postit postit = new Postit(id, contenu, posX, posY, color);
                    postit.Init();
                }
            }
        }


        public void RefreshById(int id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("conf.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("//postit"))
            {
                if (node.Attributes["id"].Value == id.ToString())
                {
                    //postit._titre = node.Attributes["titre"].Value;
                    string contenu = node.Attributes["contenu"].Value;
                    int posX = Convert.ToInt32(node.Attributes["posX"].Value);
                    int posY = Convert.ToInt32(node.Attributes["posY"].Value);
                    string color = node.Attributes["color"].Value;
                    Postit postit = new Postit(id, contenu, posX, posY, color);
                    postit.Init();
                }
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Todo save les postit avant de quitter
            Application.Exit();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Postit postit = new Postit(0);
            postit.Init();
        }

        private void F_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                notifyIcon1.Visible = true;
                Hide();
            }
        }
    }
}