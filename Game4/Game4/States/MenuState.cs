using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Engine;

namespace RPGGame.States
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
        public static InputHandler inputHandler;
        private bool isExited = false;
        private bool isNext;
        private WMPLib.WindowsMediaPlayer mplayer;
        public static bool Next;

        public static bool stopMenu;
        public MenuState()
        {
            Initialize();
            string da = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase);
            mplayer = new WMPLib.WindowsMediaPlayer();
            Directory.GetCurrentDirectory();
            mplayer.URL = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase) + @"\Content\songs\menu.mp3";
            mplayer.settings.setMode("loop", false);
            mplayer.controls.play();
            stopMenu = false;
        }

        public override bool IsExited()
        {
            return isExited;
        }

        public override void Update(GameTime gameTime)
        {
            
            elapsed += gameTime.ElapsedGameTime.Milliseconds;
           // inputHandler.MouseMovement();
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
            this.background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/fire");
            this.play = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/play");
            this.options = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/options");
            this.quit = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/exit");
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
