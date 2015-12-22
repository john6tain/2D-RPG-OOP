using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.States;

namespace RPGGame.Engine
{
    class Engine : Game
    {

        #region Fields

        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private StateManager stateManager;
        public static ContentLoader ContentLoader;
        private InputHandler input;
        #endregion

        #region Constructor
        public Engine()
        {

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            ContentLoader = new ContentLoader(this.Content);
            input = new InputHandler(graphics);
            this.graphics.PreferredBackBufferWidth =  GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            this.graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            this.graphics.ApplyChanges();

        }
        #endregion

        #region Initialize Method

        protected override void Initialize()
        {
            this.IsMouseVisible = true;
            this.graphics.IsFullScreen = true;//make it full
            this.stateManager = new StateManager();
            graphics.ApplyChanges();

            base.Initialize();

        }

        #endregion

        #region Loading content

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
        }

        #endregion

        #region Update method

        protected override void Update(GameTime gameTime)
        {

            this.stateManager.CurrentState.Update(gameTime);
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape) || MenuState.stopMenu)
            {
                Exit();
            }
            input.MouseMovement();
            input.CheckForKeyboardInput(stateManager, GraphicsDevice.Viewport);
            base.Update(gameTime);

        }

        #endregion


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightBlue);
            this.stateManager.CurrentState.Draw(this.spriteBatch);

            base.Draw(gameTime);
        }
    }


}
