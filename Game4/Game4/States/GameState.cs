using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Engine;
using RPGGame.PlayersAndClasses;

namespace RPGGame.States
{
    public class GameState : State
    {

        Player one = new ChichoMitko(0, 0);
        public GameState()
        {
            Initialize();
            
        }

        private void Initialize()
        {
            
           
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            Main.inputHandler.PlayerMovement(one);
         //  Player.Move();
        }

        public override bool IsExited()
        {
            throw new System.NotImplementedException();
        }
    }
}

///BlackWidow 
/// IBM Model M
/// Cherry 