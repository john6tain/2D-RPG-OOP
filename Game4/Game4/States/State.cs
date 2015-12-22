using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.States
{
    public abstract class State
    {

        #region Methods

        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime spriteBatch);
        public abstract bool IsExited();
        protected State()
        {

        }

        #endregion

    }
}