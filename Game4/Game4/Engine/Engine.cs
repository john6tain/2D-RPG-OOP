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
        private Texture2D background;
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
        private Texture2D Pic2;

        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            Content.RootDirectory = "Content";
            allPics = new Texture2D[4];
            // Set devallPicsice frame rate to 30 fps.
            TargetElapsedTime = TimeSpan.FromSeconds(1 / 30.0);
            this.nextContent = false;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            if (nextContent)
            {
                this.graphics.IsFullScreen = true;
                // change these names to the names of your images
                // Create a new SpriteBatch, which can be used to draw textures.
                spriteBatch = new SpriteBatch(GraphicsDevice);
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
            {
                this.graphics.PreferredBackBufferWidth  = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
                this.graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
                this.graphics.IsFullScreen = true;


                background = Content.Load<Texture2D>("images/fire");

                spriteBatch = new SpriteBatch(GraphicsDevice);
                play = Content.Load<Texture2D>("images/play");
                options = Content.Load<Texture2D>("images/options");
                quit = Content.Load<Texture2D>("images/exit");
                main = new Menu(background, options, play, quit, this.spriteBatch, this.graphics,
                    new Microsoft.Xna.Framework.Media.MediaLibrary());
            }
    }
        protected override void UnloadContent()
        {
           Content.Unload();
            
        }

        public bool nextContent { get; set; }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            IsMouseVisible = true;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            this.main.Update(gameTime,new Vector2(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height,
                                                  GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width));
            if (main.StartGame)
            {
                Content.Unload();
                 this.nextContent = true;
                 //this.rpg.Update(gameTime);
                //   UnloadContent();
                 this.LoadContent();
            }
            if (main.IsExited)
            {
                Exit();
            }
            
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
            GraphicsDevice.Clear(Color.Black);
            if (nextContent)
            {
                rpg.Draw(gameTime);
            }
            else
            {
                main.Draw(gameTime);
            }



            base.Draw(gameTime);
        }
    }


}
