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
        public  static GraphicsDeviceManager Graphics { private get; set; }
        private InputHandler input;
        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            ContentLoader = new ContentLoader(this.Content);
            input = new InputHandler(graphics);
            this.graphics.PreferredBackBufferWidth = 1920;
            this.graphics.PreferredBackBufferHeight = 1080;
            this.graphics.ApplyChanges();

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


        protected override void Update(GameTime gameTime)
        {

            this.stateManager.CurrentState.Update(gameTime);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||Keyboard.GetState().IsKeyDown(Keys.Escape) || this.stateManager.CurrentState.IsExited())
            {
                 Exit();
            }
            input.CheckForKeyboardInput(stateManager);


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
