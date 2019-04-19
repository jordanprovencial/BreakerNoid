using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BreakernoidsGL
{
    public enum PowerUpType
    {
        BallCatch = 0,
        MultiBall,
        PaddleSize
    }

   public class PowerUp : GameObject
    {
        public PowerUpType type;

        public float speed = 400;

        public bool shouldRemove = false;

        public PowerUp(PowerUpType myType, Game myGame) :
            base(myGame)
        {
            type = myType;
            switch (type)
            {
                case (PowerUpType.BallCatch):
                    textureName = "powerup_c";
                    break;
                case (PowerUpType.MultiBall):
                    textureName = "powerup_b";
                    break;
                case (PowerUpType.PaddleSize):
                    textureName = "powerup_p";
                    break;
            }
        }

        public override void Update(float deltaTime)
        {
            position.Y += speed * deltaTime;
            if (position.Y > (1024 + Height / 2))
            {

                shouldRemove = true;

            }

            base.Update(deltaTime);
        }
    }
}
