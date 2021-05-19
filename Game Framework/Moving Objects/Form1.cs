using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Objects
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(10);
            GameObject firstEnemy = new GameObject(pictureBox1);
            GameObject secondEnemy = new GameObject(pictureBox2);
            game.addObjects(firstEnemy);
            game.addObjects(secondEnemy);
        }
    }
}
