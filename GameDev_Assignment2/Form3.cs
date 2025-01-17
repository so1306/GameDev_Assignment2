﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDev_Assignment2
{
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }

        private void objectbackButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Form1 a2 = new Form1();
            a2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bodyButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            BodyParts bodyParts = new BodyParts();
            bodyParts.Show();
            Visible = false;
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            AnimalForm a2 = new AnimalForm();
            a2.Show();
            this.Hide();
        }

        private void coloursButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Colors c3 = new Colors();
            c3.Show();
            Visible = false;
        }

        private void colourss_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            Numbers n3 = new Numbers();
            n3.Show();
            Visible = false;
        }

        private void fruitsButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            FruitForm a2 = new FruitForm();
            a2.Show();
            this.Hide();
        }

        private void objectsButton_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(Properties.Resources.MouseClick);
            splayer.Play();
            ObjectForm a2 = new ObjectForm();
            a2.Show();
            this.Hide();
        }
    }
}
