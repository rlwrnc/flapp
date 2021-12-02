using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace flapp
{
    public class Player
    {
        static Texture2D Texture;
        Vector2 Position;
        float gravity, verticalSpeed;

        public Player(Vector2 initialPosition)
        {
            Position = initialPosition;
            verticalSpeed = 0;
        }


        public void LoadContent(ContentManager content)
        {
            Texture = content.Load<Texture2D>("ball");
        }

        public void Update(GameTime gameTime)
        {
            var deltat = (float) gameTime.ElapsedGameTime.TotalSeconds;     // time since last update
            var jumpPressed = Keyboard.GetState().IsKeyDown(Keys.Space);    // jump key = space

            if(jumpPressed)                                                 // if space pressed, jump in the air
                verticalSpeed = -700;
            else                                                            // otherwise, accelerate downward to terminal velocity
            {
                if(verticalSpeed < 500)
                    gravity = 2000;
                else 
                    gravity = 0;
            }

            verticalSpeed += gravity * deltat;                              // calculate new speed
            Position.Y += verticalSpeed * deltat + (gravity / 2) * (float) Math.Pow(deltat, 2); // calculate new position
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                Texture,
                Position,
                null,
                Color.White,
                0f,
                new Vector2(Texture.Width / 2, Texture.Height / 2),
                Vector2.One,
                SpriteEffects.None,
                0f
            );
        }

    }
}