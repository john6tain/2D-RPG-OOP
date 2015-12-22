﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Engine;
using RPGGame.Players;
using RPGGame.PlayersAndClasses;

namespace RPGGame.States
{
    public class GameState : State
    {

        #region Fields
        private GraphicsDeviceManager graphics;
        private Texture2D background;
        public Character one;
        public Character two;
        private Rectangle? sourceRect;
        private Texture2D[] allPics;
        private Rectangle sourceRectOne;
        private Rectangle oneRect;
        private Rectangle sourceRectTwo;
        private Rectangle twoRect;
        private InputHandler input;
        public static int zoom = 3;
        private SpriteFont Font1;

        #endregion

        #region Constructor
        public GameState(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
            allPics = new Texture2D[4];
            one = new ChichoMitko(100, 100);
            two = new ChichoMitko(555, 1260);
            one.Speed = 5;
            Initialize();
            input = new InputHandler(graphics);
        }

        #endregion

        #region Methods

        private void Initialize()
        {

            Font1 = Engine.Engine.ContentLoader.Content.Load<SpriteFont>("MyFont");

            background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/firstmap");

            string[] imageNames = { "images/up", "images/down", "images/left", "images/right" };

            for (int i = 0; i < imageNames.Length; i++)
            {

                allPics[i] = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[i]);
            }
            one.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
            two.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
        }
        public override void Update(GameTime gameTime)
        {
            input.PlayerMovement(one, true);

            one.Moving(allPics);
            one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            two.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 60);
            oneRect = new Rectangle((int)one.X, (int)one.Y, 60, 60);
            if (one.Y >= 700)
            {
                if (two.X > one.X)
                {
                    two.X -= 2;
                } //555 1260
                if (two.X < one.X)
                {
                    two.X += 2;
                }
                if (two.Y <= one.Y)
                {
                    two.Y++;
                }
                if (two.Y >= one.Y)
                {
                    two.Y--;
                }
            }
            sourceRectTwo = new Rectangle(30 * 1, 0, 30, 80);
            twoRect = new Rectangle((int)two.X, (int)two.Y, 60, 80);
            if (oneRect.Intersects(twoRect))
            {
                one.X = one.OldX;
                one.Y = one.OldY;
            }
            else
            {
                one.OldX = one.X;
                one.OldY = one.Y;
            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.CameraMoving((float)one.X, (float)one.Y, 1.5f));
            spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width * zoom, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height * zoom), sourceRect, Color.White);

            spriteBatch.Draw(one.Pic, oneRect, sourceRectOne, Color.White);
            spriteBatch.Draw(one.Pic, twoRect, sourceRectTwo, Color.White);
            spriteBatch.End();
            spriteBatch.Begin();
            spriteBatch.DrawString(Font1, one.X.ToString() + "   " + one.Y.ToString(), new Microsoft.Xna.Framework.Vector2(0, 0), Color.DarkRed);
            spriteBatch.End();
        }
        public override bool IsExited()
        {
            return false;
        }

        #endregion

    }
}

///BlackWidow 
/// IBM Model M
/// Cherry G80