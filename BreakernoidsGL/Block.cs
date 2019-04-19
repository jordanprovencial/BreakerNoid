using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//This a public Block class that inherits from GameObject, similar to the Ball class

namespace BreakernoidsGL
{
   public class Block : GameObject
    {
        public Block(Game myGame) :
            base(myGame)
        {
            textureName = "block_red";
        }
        
    }
}
