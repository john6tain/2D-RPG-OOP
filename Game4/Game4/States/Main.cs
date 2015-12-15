using System;
using RPGGame.PlayersAndClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame;
using RPGGame.Engine;
using RPGGame.PlayersAndClasses;
using RPGGame.States;

namespace RPGGame.Engine
{
        /// <summary>
        /// This is the main type for your game.
        /// </summary>
        public class Main : State
        {
            GraphicsDeviceManager graphics;
            SpriteBatch spriteBatch;

            public static InputHandler inputHandler;
            private StateManager stateManager;

            public static ContentLoader ContentLoader;
            private Texture2D background;

            public Main()
            {

                Initialize();
            }

            /// <summary>
            /// Allows the game to perform any initialization it needs to before starting to run.
            /// This is where it can query for any required services and load any non-graphic
            /// related content.  Calling base.Initialize will enumerate through any components
            /// and initialize them as well.
            /// </summary>
            public  void Initialize()
            {
            this.background = Engine.ContentLoader.Content.Load<Texture2D>("images/fire");
            /*ContentLoader = new ContentLoader(this.Content);

            this.stateManager = new StateManager();

            inputHandler = new InputHandler(this.graphics);

            base.Initialize();*/
        }

            /// <summary>
            /// LoadContent will be called once per game and is the place to load
            /// all of your content.
            /// </summary>
             void LoadContent()
            {
                // Create a new SpriteBatch, which can be used to draw textures.
               

            }

            /// <summary>
            /// UnloadContent will be called once per game and is the place to unload
            /// game-specific content.
            /// </summary>


            public override void Draw(SpriteBatch spriteBatch)
            {
         //   myBackground.Draw(spriteBatch);
            spriteBatch.Draw(background, new Rectangle(0, 0, 60, 60), Color.White);
           // spriteBatch.Draw(two.Pic, new Rectangle((int)two.X, (int)two.Y, 60, 60), sourceRectTwo, Color.White);
          
        }

            /// <summary>
            /// Allows the game to run logic such as updating the world,
            /// 
            /// checking for collisions, gathering input, and playing audio.
            /// </summary>
            /// <param name="gameTime">Provides a snapshot of timing values.</param>
            public override void Update(GameTime gameTime)
            {
                // this.scale = (float) this.graphics.GraphicsDevice.Viewport.Width/Constants.MaxWidth;

                // this.scaleMatrix = Matrix.CreateScale(this.scale, this.scale, 1f);

                //       inputHandler.CheckForKeyboardInput(this.stateManager);

                //    if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                //    {
                //       // Exit();
                //    }

                //    if (this.stateManager.CurrentState is GameState)
                //    {
                //       // this.IsMouseVisible = false;
                //    }
                //    else
                //    {
                //     //   this.IsMouseVisible = true;
                //        inputHandler.CheckForMouseInput(this.stateManager);
                //    }

                //    this.stateManager.CurrentState.Update(gameTime);
                //   // base.Update(gameTime);*/
                //}
            }

            public override bool IsExited()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// This is called when the game should draw itself.
            /// </summary>
            /// <param name="gameTime">Provides a snapshot of timing values.</param>
            public  void Draw(GameTime gameTime)
            {
                
            

                this.stateManager.CurrentState.Draw(this.spriteBatch);
            }
        }
    }


/// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 

/* public class RPG : State
 {

     private Rectangle sourceRectOne;
     private Rectangle sourceRectTwo;
     private ScrollingBackground myBackground;
/*      GraphicsDeviceManager graphics;
     SpriteBatch spriteBatch;*/
/*    private Texture2D[] allPics;
    Player one;
    Player two;
    public RPG()
    {

        one = new Alexsination(graphics.PreferredBackBufferWidth-80 , graphics.PreferredBackBufferHeight-50);
        two = new Alexsination(0, 50);
    }*/

/// <summary>
/// Allows the game to perform any initialization it needs to before starting to run.
/// This is where it can query for any required services and load any non-graphic
/// related content.  Calling base.Initialize will enumerate through any components
/// and initialize them as well.
/// </summary>
/*     protected override void Initialize()
     {
        +
     }

     /// <summary>
     /// LoadContent will be called once per game and is the place to load
     /// all of your content.
     /// </summary>
     /// <summary>
     /// UnloadContent will be called once per game and is the place to unload
     /// game-specific content.
     /// </summary>


  /*   public override void Draw(SpriteBatch spriteBatch)
     {
         myBackground.Draw(spriteBatch);
         spriteBatch.Draw(one.Pic, new Rectangle((int)one.X, (int)one.Y, 60, 60), sourceRectOne, Color.White);
         spriteBatch.Draw(two.Pic, new Rectangle((int)two.X, (int)two.Y, 60, 60), sourceRectTwo, Color.White);
     }

     public override void Update(GameTime spriteBatch)
     {
         throw new NotImplementedException();
     }

     /// <summary>
     /// Allows the game to run logic such as updating the world,
     /// checking for collisions, gathering input, and playing audio.
     /// </summary>
     /// <param name="gameTime">Provides a snapshot of timing values.</param>
   /*  protected override void Update(GameTime gameTime)
     {

         if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
             Keyboard.GetState().IsKeyDown(Keys.Escape))
             Exit();
         one.Moving(PlayerIndex.One, new Keys[] { Keys.A, Keys.D, Keys.W, Keys.S }, ref myBackground, this.graphics, allPics);
         two.Moving(PlayerIndex.Two, new Keys[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down }, ref myBackground, this.graphics, allPics);
         one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
         two.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
         sourceRectOne   = new Rectangle(30 * one.Frame, 0, 30, 52);
         sourceRectTwo = new Rectangle(30 * two.Frame, 0, 30, 52);

         //  myBackground.Update(one.Frame*2);

         base.Update(gameTime);

     }*/

/*       public override bool IsExited()
       {
           throw new NotImplementedException();
       }

       /// <summary>
       /// This is called when the game should draw itself.
       /// </summary>
       /// <param name="gameTime">Provides a snapshot of timing values.</param>
       public override void Draw(SpriteBatch spriteBatch)
       {
          // GraphicsDevice.Clear(Color.Wheat);
           spriteBatch.Begin();
           myBackground.Draw(spriteBatch);
           spriteBatch.Draw(one.Pic, new Rectangle((int)one.X, (int)one.Y, 60, 60), sourceRectOne, Color.White);
           spriteBatch.Draw(two.Pic, new Rectangle((int)two.X, (int)two.Y, 60, 60), sourceRectTwo, Color.White);
           spriteBatch.End();
        //   base.Draw(gameTime);
       }

   }
}*/
   