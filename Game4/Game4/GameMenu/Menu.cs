using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using Game4;
using RPGGame.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace RPGGame
{
    public class Menu : Game
    {
        public TimeSpan TargetElapsedTime { get; set; }

        #region FIELDS
        //FIELDS
        private Texture2D background;
        private Texture2D play;
        private Texture2D options;
        private Song song;
        private Texture2D quit;
        private WMPLib.WindowsMediaPlayer player;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        protected bool isExited = false;
        private int frame = 0;
        private Rectangle sourceRect;
        private int elapsed = 0;
        private MediaLibrary sampleMediaLibrary;
        
        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
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
        #endregion
        public Menu(Texture2D background, Texture2D options, Texture2D play, Texture2D Quit, SpriteBatch spriteBatch, GraphicsDeviceManager graphics, MediaLibrary sampleMediaLibrary)
        {
            this.Background = background;
            this.Options = options;
            this.Play = play;
            this.Quit = Quit;
            this.SpriteBatch = spriteBatch;
            this.Graphics = graphics;
            this.sampleMediaLibrary = sampleMediaLibrary;
            TargetElapsedTime = TimeSpan.FromSeconds(1 / 60.0);
            player = new WMPLib.WindowsMediaPlayer();
            Directory.GetCurrentDirectory();
            player.URL = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase)+@"\Content\songs\menu.mp3";
            player.settings.setMode("loop", true);
            player.controls.play();
            this.StartGame = false;
        }

        public bool StartGame { get; set; }


        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
       
        public  void Update(GameTime gameTime, Vector2 resolution)
        {
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            string da = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase);
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            IsMouseVisible = true;
            elapsed += gameTime.ElapsedGameTime.Milliseconds;
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            
            if (mouseState.LeftButton == ButtonState.Pressed &&
                (new Rectangle((Window.ClientBounds.Width / 2) - 50, (Window.ClientBounds.Height / 2) - 200, 100, 70).Contains(
                    mousePosition)))
            {
                player.controls.stop();
                this.StartGame = true;
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((Window.ClientBounds.Width / 2) - 50, (Window.ClientBounds.Height / 2) - 100, 100, 70)).Contains(mousePosition))
            {
                Options op = new Options();

                
                Mouse.SetPosition(0, 0);

            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((Window.ClientBounds.Width / 2) - 50, (Window.ClientBounds.Height / 2), 100, 70).Contains(mousePosition)))
            {

                isExited = true;
            }
            if (elapsed >= 200)
            {
                if (frame >= 2)
                {
                    frame = 1;
                }
                else
                {
                    frame++;
                }

                elapsed = 0;
            }
            sourceRect = new Rectangle(124 * frame, 0, 640, 250);
            base.Update(gameTime);
        }

        

        public  void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, graphics.PreferredBackBufferWidth , graphics.PreferredBackBufferHeight), sourceRect, Color.White);
            spriteBatch.Draw(play, new Rectangle((graphics.PreferredBackBufferWidth / 2) - 50, (graphics.PreferredBackBufferHeight / 2) - 200, 150, 70), Color.White);
            spriteBatch.Draw(options, new Rectangle((graphics.PreferredBackBufferWidth / 2) - 50, (graphics.PreferredBackBufferHeight / 2) - 100, 150, 70), Color.White);
            spriteBatch.Draw(quit, new Rectangle((graphics.PreferredBackBufferWidth / 2) - 50, (graphics.PreferredBackBufferHeight/2 ), 150, 70), Color.White);
            spriteBatch.End();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
