using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace flapp
{
    public class Pipe
    {
        Texture2D Texture;
        Vector2 Position;
        public Pipe(Vector2 initialPosition)
        {
            Position = initialPosition;
        }

        public void LoadContent(ContentManager content)
        {
            Texture = content.Load<Texture2D>("rectangle");
        }

        public void Update(GameTime gameTime)
        {
            Position.X -= 100 * (float) gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}