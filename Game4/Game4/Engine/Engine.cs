using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.PlayersAndClasses;
using RPGGame.States;

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
        private int elapsed;
        private WMPLib.WindowsMediaPlayer mplayer;
        public static bool exit;
        private GameState game;
        public Engine()
        {
          
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            ContentLoader = new ContentLoader(this.Content);
            input = new InputHandler(graphics);
            this.graphics.PreferredBackBufferWidth = 1440;
            this.graphics.PreferredBackBufferHeight = 900;
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


        }


        protected override void Update(GameTime gameTime)
        {

            this.stateManager.CurrentState.Update(gameTime);
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||Keyboard.GetState().IsKeyDown(Keys.Escape) || MenuState.stopMenu)
            {
                 Exit();
            }
            input.MouseMovement();
            input.CheckForKeyboardInput(stateManager, GraphicsDevice.Viewport);
            if (Keyboard.GetState().IsKeyDown(Keys.B))
            {
                
               // camera.View = new Viewport(700, 100, 30, 30);
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
            GraphicsDevice.Clear(Color.LightBlue);
         //   spriteBatch.Begin();
            this.stateManager.CurrentState.Draw(this.spriteBatch);
         //   spriteBatch.End();

            base.Draw(gameTime);
        }
    }


}
