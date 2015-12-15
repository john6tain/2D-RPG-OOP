using System;
using System.IO;
using System.Reflection;
using Game4;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame;
using RPGGame.Engine;

namespace RpgGame
{
    public class MenuState : State
    {
        private Texture2D background;
        private Texture2D play;
        private Texture2D options;
        private Texture2D quit;
        private int elapsed = 0;
        private int frame = 0;
        private Rectangle sourceRect;
        private bool isExited = false;
        private WMPLib.WindowsMediaPlayer mplayer;
        public MenuState()
        {
            Initialize();
            string da = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase);
            mplayer = new WMPLib.WindowsMediaPlayer();
            Directory.GetCurrentDirectory();
            mplayer.URL = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase) + @"\Content\songs\menu.mp3";
            mplayer.settings.setMode("loop", true);
            mplayer.controls.play();
        }

        public override bool IsExited()
        {
            return isExited;
        }
        public override void Update(GameTime gameTime)
        {
            elapsed += gameTime.ElapsedGameTime.Milliseconds;
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);


            if (mouseState.LeftButton == ButtonState.Pressed 
                &&(new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50,(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 200, 100, 70)
               .Contains(mousePosition)))
            {
                /* player.controls.stop();
                 this.StartGame = true;*/
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 100, 100, 70)).Contains(mousePosition))
            {
                /// Options op = new Options();


                Mouse.SetPosition(0, 0);

            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2), 100, 70).Contains(mousePosition)))
            {

                isExited = true;
                // throw new ArgumentException("exit");
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
            sourceRect = new Rectangle(100 * frame, 0, 640, 250);

        }
        #region Initialize
        /// <summary>
        /// LoadContent will be called once per game and is the place to Load
        /// game-specific content.
        /// </summary>
        private void Initialize()
        {
            this.background = Engine.ContentLoader.Content.Load<Texture2D>("images/fire");
            this.play = Engine.ContentLoader.Content.Load<Texture2D>("images/play");
            this.options = Engine.ContentLoader.Content.Load<Texture2D>("images/options");
            this.quit = Engine.ContentLoader.Content.Load<Texture2D>("images/exit");
        }

        #endregion
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height), sourceRect, Color.White);
            spriteBatch.Draw(play, new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 200, 150, 70), Color.White);
            spriteBatch.Draw(options, new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 100, 150, 70), Color.White);
            spriteBatch.Draw(quit, new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2), 150, 70), Color.White);
        }
    }

}
