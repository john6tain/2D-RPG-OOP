using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.PlayersAndClasses;

namespace RPGGame.Engine
{
    class Engine : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private StateManager stateManager;
        public static ContentLoader ContentLoader;
        /*   private Texture2D background;
           private Texture2D options;
           private Texture2D play;
           private Texture2D quit;
           private SpriteBatch spriteBatch;
           private GraphicsDeviceManager graphics;
           private Texture2D[] allPics;
           private ScrollingBackground myBackground;
           private Menu main;
           private RPG rpg;
           private Texture2D Pic;
           private Texture2D Pic2;*/
        public  static GraphicsDeviceManager Graphics { private get; set; }
        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //  allPics = new Texture2D[4];
            // Set devallPicsice frame rate to 30 fps.
            TargetElapsedTime = TimeSpan.FromSeconds(1 / 30.0);
            ContentLoader = new ContentLoader(this.Content);
            //  

        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            this.graphics.IsFullScreen = true;
            this.stateManager = new StateManager();
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
            /*
            if (nextContent)
            {
                this.graphics.IsFullScreen = true;
                // change these names to the names of your images
                // Create a new SpriteBatch, which can be used to draw textures.
              
                myBackground = new ScrollingBackground();
                Texture2D background = Content.Load<Texture2D>("images/firstmap");

                myBackground.Load(GraphicsDevice, background);
                string[] imageNames = { "images/up", "images/down", "images/left", "images/pr" };

                for (int i = 0; i < imageNames.Length; i++)
                {
                    allPics[i] = Content.Load<Texture2D>(imageNames[i]);
                }
                Pic = Content.Load<Texture2D>(imageNames[0]);
                Pic2 = Content.Load<Texture2D>(imageNames[0]); 
                rpg = new RPG(myBackground, graphics, spriteBatch, allPics, Pic, Pic2);
                
            }
            else
            {*/


        }
        protected override void UnloadContent()
        {

        }
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // StateManager.Instance.Update(gameTime);
           /* IsMouseVisible = true;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape)||this.stateManager.CurrentState.IsExited())
                Exit();*/

            this.stateManager.CurrentState.Update(gameTime);


             /*one.Moving(PlayerIndex.One, new Keys[] { Keys.A, Keys.D, Keys.W, Keys.S }, ref myBackground, this.graphics, allPics);
             two.Moving(PlayerIndex.Two, new Keys[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down }, ref myBackground, this.graphics, allPics);
             one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
             two.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
             sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 52);
             sourceRectTwo = new Rectangle(30 * two.Frame, 0, 30, 52);

             //  myBackground.Update(one.Frame*2);*/

            base.Update(gameTime);

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightBlue);
            spriteBatch.Begin();
            this.stateManager.CurrentState.Draw(this.spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }


}
