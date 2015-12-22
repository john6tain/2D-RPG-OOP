using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.Engine;
using RPGGame.PlayersAndClasses;

namespace RPGGame.States
{
    public class Options : State
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
        public Options()
        {
            Initialize();

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
            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                GameState.playerNow = new ChichoMitko(100, 100);
                isExited = true;

            }
            if (Keyboard.GetState().IsKeyDown(Keys.X))
            {
                GameState.playerNow = new Programmer(100, 100);
                isExited = true;


            }
            if (Keyboard.GetState().IsKeyDown(Keys.C))
            {
                GameState.playerNow = new Alexsination(100, 100);

            isExited = true;
            }


            #endregion

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to Load
        /// game-specific content.
        /// </summary>
        private void Initialize()
        {
            this.background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/Select");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height), Color.White);
            spriteBatch.End();
        }
    }

}
