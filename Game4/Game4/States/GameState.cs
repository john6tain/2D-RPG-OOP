using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
        private ScrollingBackground myBackground;
        private InputHandler input;
        private Camera camera;
        public GameState(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
            allPics = new Texture2D[4];
            one = new ChichoMitko(100, 100);
            Initialize();
            input = new InputHandler(graphics);
           
        }

        private void Initialize()
        {
           // camera = new Camera(GraphicsDevice.Viewport, Vector2.Zero);
           // this.graphics.IsFullScreen = true;
            // change these names to the names of your images
            // Create a new SpriteBatch, which can be used to draw textures.

            myBackground = new ScrollingBackground();
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
             input.PlayerMovement(one);
             
            one.Moving(this.graphics, allPics);

            one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 52);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background,new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height), sourceRect, Color.White);
           
            spriteBatch.Draw(one.Pic, new Rectangle((int)one.X, (int)one.Y, 30, 30), sourceRectOne,Color.White);
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