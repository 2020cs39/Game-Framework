using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Objects
{ 
    class Game:Form
    {

        // Code To Make class singleton starts
        public Game()
        {

        }
        private static Game game_;
        public static Game gameInstance()
        {
            if (game_ == null)
            {
                game_ = new Game();
            }
            return game_;
        }
        // Code to make class singleton ends


        public int speed;
        public Game(int speed)
        {
            this.speed = speed;
        }


        public static ArrayList totalObjects = new ArrayList();
        

  
        public void addObjects(GameObject obj)
        {
            totalObjects.Add(obj);

        }
        public void update()
        {
            GameObject gObject = new GameObject();
            for (int i=0; i<totalObjects.Count; i++)
            {
                GameObject obj = (GameObject)totalObjects[i];
                PictureBox picture;
                picture =  obj.getPictureBox();
                gObject.update(speed , picture);
            }
        }
    }
}
