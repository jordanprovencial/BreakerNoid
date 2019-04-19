using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

//This is a public Ball class that inherits from GameObject 
namespace BreakernoidsGL
{
   public class Ball : GameObject
    {
        public float speed = 375;

        public Vector2 direction = new Vector2(0.707f, -0.707f);

        public bool caught = false;

        public int withPaddle = 0;

        public Ball(Game myGame) :
            base(myGame)
        {
            textureName = "ball";
        }

        public virtual void Update(float deltaTime)
        {
            if (!caught)
            {
                position += direction * speed * deltaTime;
                if (withPaddle > 0)
                {
                    withPaddle--;
                }
            }
            else
            {
                KeyboardState keyState = Keyboard.GetState();
                if (keyState.IsKeyDown(Keys.Space))
                {
                    caught = false;
                }
            }

            base.Update(deltaTime);
        }
    }
}
