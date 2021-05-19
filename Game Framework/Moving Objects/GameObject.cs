using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Objects
{
    class GameObject:Form
    {


        public PictureBox pictureBox;
        public GameObject()
        {

        }
        public GameObject(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }


        public void update(int speed , PictureBox picture)
        {
            picture.Top += speed;
        }

        public PictureBox getPictureBox()
        {
            return this.pictureBox;
        }


    }
}
