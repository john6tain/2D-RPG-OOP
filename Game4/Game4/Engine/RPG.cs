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
   //http://www.deviantart.com/tag/rpgsprite
    public class RPG : Game
    {

        private Rectangle destRect;
        private Rectangle sourceRect;
        private ScrollingBackground myBackground;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D[] allPics;
        Player one = new Alexsination(0, 0);
        Player two = new Alexsination(500, 0);
        public RPG()
        {
            graphics = new GraphicsDeviceManager(this);
             Content.RootDirectory = "Content";
            allPics = new Texture2D[4];
            // Set devallPicsice frame rate to 30 fps.
              TargetElapsedTime = TimeSpan.FromSeconds(1 / 60.0);

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
            one.Pic = Content.Load<Texture2D>(imageNames[0]);
                two.Pic= Content.Load<Texture2D>(imageNames[0]);
            
           
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
            one.Moving(PlayerIndex.One, new Keys[] { Keys.A, Keys.D, Keys.W, Keys.S }, ref myBackground,this.graphics,allPics);
            two.Moving(PlayerIndex.Two, new Keys[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down },ref  myBackground,this.graphics, allPics);
          one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            sourceRect = new Rectangle(31 * one.Frame, 0, 31, 52);
           
          //  myBackground.Update(one.Frame*2);

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
            myBackground.Draw(spriteBatch);
            switch (one.Pos)
            {
                case "up":
                    spriteBatch.Draw(one.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;
                case "down":
                    spriteBatch.Draw(one.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;
                case "left":
                    spriteBatch.Draw(one.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;
                case "right":
                    spriteBatch.Draw(one.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;
            }
            switch (two.Pos)
            {
                case "up":
                    spriteBatch.Draw(two.Pic, new Rectangle(two.X, two.Y, 60, 60), Color.White);
                    break;
                case "down":
                    spriteBatch.Draw(two.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;
                case "left":
                    spriteBatch.Draw(two.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;
                case "right":
                    spriteBatch.Draw(two.Pic, new Rectangle(one.X, one.Y, 60, 60), sourceRect, Color.White);
                    break;

            }
           

            spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}