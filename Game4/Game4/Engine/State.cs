using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.Engine
{
    public abstract class State
    {
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime spriteBatch);
        public abstract bool IsExited();
        protected State()
        {
            
        }

    }
}