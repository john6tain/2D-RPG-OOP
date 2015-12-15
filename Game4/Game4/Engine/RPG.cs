using System;
using RPGGame.PlayersAndClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.Engine;

namespace RPGGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 
   //http://www.deviantart.com/tag/rpgsprite
    public class RPG : State
    {

        private Rectangle sourceRectOne;
        private Rectangle sourceRectTwo;
        private ScrollingBackground myBackground;
        private Texture2D[] allPics;
        Player one;
        Player two;
        public RPG()
        {
            Initialize();
            one = new Programmer(0, 0);
            two = new Alexsination(1000, 0);

        }



        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>


        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        private void Initialize()
        {
            //myBackground = new ScrollingBackground();
            //Texture2D background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/firstmap");

         //   myBackground.Load(Engine.Engine.Graphics, background);
            string[] imageNames = { "images/up", "images/down", "images/left", "images/pr" };

          /*  for (int i = 0; i < imageNames.Length; i++)
            {
                allPics[i] = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[i]);
            }*/
       /*     one.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
            two.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
            */

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {

       /*    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            one.Moving(PlayerIndex.One, new Keys[] { Keys.A, Keys.D, Keys.W, Keys.S }, ref myBackground, this.graphics, allPics);
            two.Moving(PlayerIndex.Two, new Keys[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down }, ref myBackground, this.graphics, allPics);
            one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            two.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 52);
            sourceRectTwo = new Rectangle(30 * two.Frame, 0, 30, 52);*/

            //  myBackground.Update(one.Frame*2);

         //   base.Update(gameTime);

        }

        public override bool IsExited()
        {
            return false;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Draw(SpriteBatch spriteBatch)
        {
           // myBackground.Draw(spriteBatch);
           // spriteBatch.Draw(one.Pic, new Rectangle((int)one.X, (int)one.Y, 60, 60), sourceRectOne, Color.White);
            //spriteBatch.Draw(two.Pic, new Rectangle((int)two.X, (int)two.Y, 60, 60), sourceRectTwo, Color.White);
        }

    }
}