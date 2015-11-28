﻿using Game4.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace Game4
{
    public class Menu:Game

    {
        protected Texture2D background;
        protected Texture2D play;
        protected Texture2D options;
        protected Song song;
        protected Texture2D quit;
        protected WMPLib.WindowsMediaPlayer player;
        protected GraphicsDeviceManager graphics;
        protected SpriteBatch spriteBatch;
        protected bool isExited = false;
        private int height;
        private int width;
        private bool full;
        public bool IsExited
        {
            get { return this.isExited; }
            set { this.isExited = value; }
        }
        public Texture2D Background
        {
            get { return this.background; }
            set { this.background = value; }
        }

        public Menu()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            this.height = 500;
            this.width = 500;
            this.full = false;
        }
        public Menu(Texture2D background, Texture2D options, Texture2D play, Texture2D Quit, SpriteBatch spriteBatch, GraphicsDeviceManager graphics)
        {
            this.Background = background;
            this.Options = options;
            this.Play = play;
            this.Quit = Quit;
            this.SpriteBatch = spriteBatch;
            this.Graphics = graphics;
        }

        public GraphicsDeviceManager Graphics
        {
            get { return this.graphics; }
            set { this.graphics = value; }

        }

        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
            set { this.spriteBatch = value; }

        }

        public Texture2D Options
        {
            get { return this.options; }
            set { this.options = value; }

        }

        public Texture2D Play
        {
            get { return this.play; }
            set { this.play = value; }
        }

        public Texture2D Quit
        {
            get { return this.quit; }
            set { this.quit = value; }

        }
        public void UpdateDisplayMode(bool fullscreen, Vector2 resolution)
        {
            Width = (int) resolution.X;
            Height=(int)resolution.Y;
            Full = fullscreen;
            graphics.PreferredBackBufferWidth = Width;
            graphics.PreferredBackBufferHeight = Height;
            graphics.IsFullScreen = Full;
            graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            this.graphics.PreferredBackBufferWidth = Width ;
            this.graphics.PreferredBackBufferHeight = Height;
            this.graphics.IsFullScreen = false;
            player = new WMPLib.WindowsMediaPlayer();
            player.URL = @"C:\Users\John\Documents\Visual Studio 2015\Projects\Game4\Game4\Content\songs\menu.mp3";
            player.settings.setMode("loop",true);
            player.controls.play();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            play = Content.Load<Texture2D>("images/play");
            options = Content.Load<Texture2D>("images/options");
            quit = Content.Load<Texture2D>("images/exit");
            // TODO: use this.Content to load your game content here
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public bool Full
        {
            get { return full; }
            set { full = value; }
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
          
            IsMouseVisible = true;
            if (mouseState.LeftButton == ButtonState.Pressed &&
                (new Rectangle((Width/2) - (full ? 450 : 50), (Height/2)- (full ? 320 : 200), 100, 70).Contains(
                    mousePosition)))
            {
                player.controls.stop();
                using (RPG game = new RPG())
                {
                    game.Run();
                }
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((Width / 2) - (full ? 450 : 50),(Height / 2) - (full ? 250 : 100) , 100, 70).Contains(mousePosition)))
            {
                Options op = new Options();

                UpdateDisplayMode(true,op.Resolution);
                Mouse.SetPosition(0,0);


            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((Width / 4)-60/* - (full ? 450 : 50)*/, (Height / 3)-20/*-(full?150:0)*/, 100, 70).Contains(mousePosition)))
            {

                Exit();
            }

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Wheat);
            spriteBatch.Begin();
            spriteBatch.Draw(play, new Rectangle((Window.ClientBounds.Width/2)-50,( Window.ClientBounds.Height / 2)-200, 100, 70), Color.Black);
            spriteBatch.Draw(options, new Rectangle((Window.ClientBounds.Width / 2) - 50, (Window.ClientBounds.Height / 2)-100,100, 70), Color.Black);
            spriteBatch.Draw(quit, new Rectangle((Window.ClientBounds.Width / 2) - 50, (Window.ClientBounds.Height / 2) , 100, 70), Color.Black);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}