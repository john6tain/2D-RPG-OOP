using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using OpenTK;
using RPGGame.Engine;
using RPGGame.PlayersAndClasses;

namespace RPGGame.States
{
    public class GameState : State
    {
        private GraphicsDeviceManager graphics;
        private Texture2D background;
        private Player one;
        private Rectangle? sourceRect;
        private Texture2D[] allPics;
        private Rectangle sourceRectOne;
        public GameState(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
            allPics = new Texture2D[4];
            one = new ChichoMitko(100, 100);
            Initialize();
           
        }

        private void Initialize()
        {

           // this.graphics.IsFullScreen = true;
            // change these names to the names of your images
            // Create a new SpriteBatch, which can be used to draw textures.

           // myBackground = new ScrollingBackground();
             background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/firstmap");

            //myBackground.Load(GraphicsDevice, background);
            //allPics = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/pr");
           

            string[] imageNames = { "images/up", "images/down", "images/left", "images/pr" };
            
            for (int i = 0; i < imageNames.Length; i++)
            {
                allPics[i] =Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[i]);
            }
             one.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
           // Pic2 = Content.Load<Texture2D>(imageNames[0]);*/
        }
        public override void Update(GameTime gameTime)
        {
            // one.Moving(PlayerIndex.One, new Keys[] { Keys.A, Keys.D, Keys.W, Keys.S }, ref myBackground, this.graphics, allPics);

         //   one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
           // sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 52);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background,new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height), sourceRect, Color.White);
           
            spriteBatch.Draw(one.Pic, new Rectangle((int)one.X, (int)one.Y, 60, 60), Color.White);
        }

        
        public override bool IsExited()
        {
            return false;
        }

    }
}

///BlackWidow 
/// IBM Model M
/// Cherry GN