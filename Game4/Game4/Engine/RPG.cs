using System;
using Game4.PlayersAndClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game4.Engine
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 
   
    public class RPG : Game
    {
      
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player one = new Alexsination(0, 0);
        Player two = new Alexsination(500, 0);
        public RPG()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
           
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            
            // change these names to the names of your images
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

                one.Pic = Content.Load<Texture2D>("images/hero");
            two.Pic = Content.Load<Texture2D>("images/hero");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            one.Moving(PlayerIndex.One,new Keys[] {Keys.A, Keys.D,Keys.W,Keys.S});
           two.Moving(PlayerIndex.Two, new Keys[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down });

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Wheat);
            spriteBatch.Begin();
           spriteBatch.Draw(one.Pic, new Rectangle(one.X, one.Y, 100, 100),Color.Black);
            spriteBatch.Draw(two.Pic, new Rectangle(two.X, two.Y, 100, 100), Color.Black);
            spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}