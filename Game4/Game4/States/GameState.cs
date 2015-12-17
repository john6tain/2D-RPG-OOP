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
        public Player one;
        private Rectangle? sourceRect;
        private Texture2D[] allPics;
        private Rectangle sourceRectOne;
        private InputHandler input;
        public static int zoom =3;
        private SpriteFont Font1;

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

            //  myBackground = new ScrollingBackground();
            Font1 = Engine.Engine.ContentLoader.Content.Load<SpriteFont>("MyFont");

            background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/firstmap");

            //myBackground.Load(GraphicsDevice, background);
            //allPics = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/pr");


            string[] imageNames = { "images/up", "images/down", "images/left", "images/pr" };

            for (int i = 0; i < imageNames.Length; i++)
            {

                allPics[i] = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[i]);
            }
            one.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
            // Pic2 = Content.Load<Texture2D>(imageNames[0]);*/
        }
        public override void Update(GameTime gameTime)
        {
            input.PlayerMovement(one);

            one.Moving( allPics);

            one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 52);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null,Matrix.CreateTranslation(-((float)one.X)/1.5f, -((float)one.Y)/1.5f, 0));
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width*zoom, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height* zoom), sourceRect, Color.White);

            spriteBatch.Draw(one.Pic, new Rectangle((int)one.X, (int)one.Y, 60, 80), sourceRectOne, Color.White);
            spriteBatch.End();
            spriteBatch.Begin();
            spriteBatch.DrawString(Font1, "Health", new Microsoft.Xna.Framework.Vector2 (0,0),Color.DarkRed);
            spriteBatch.End();
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