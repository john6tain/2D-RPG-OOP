using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Engine;
using System.IO;
using System.Reflection;

namespace RPGGame.States
{
    public class MenuState : State
    {

        #region Fields
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
        public static WMPLib.WindowsMediaPlayer mplayer;
        public static bool Next;
        public static bool stopMenu;

        #endregion

        #region Constructor
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

        #endregion

        #region Methods
        public override bool IsExited()
        {
            return isExited;
        }

        public override void Update(GameTime gameTime)
        {

            elapsed += gameTime.ElapsedGameTime.Milliseconds;
            // inputHandler.MouseMovement();

            #endregion

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to Load
        /// game-specific content.
        /// </summary>
        private void Initialize()
        {
            this.background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/menu");
            this.play = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/play");
            this.options = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/options");
            this.quit = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/exit");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height), Color.White);
            spriteBatch.Draw(play, new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 200, 150, 70), Color.White);
            spriteBatch.Draw(options, new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 100, 150, 70), Color.White);
            spriteBatch.Draw(quit, new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2), 150, 70), Color.White);
            spriteBatch.End();
        }
    }

}
