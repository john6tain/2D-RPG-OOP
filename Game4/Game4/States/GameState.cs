using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Enemies;
using RPGGame.Engine;
using RPGGame.Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using WMPLib;

namespace RPGGame.States
{
    public class GameState : State
    {

        #region Fields
        private GraphicsDeviceManager graphics;
        private Texture2D background;
        public Character one;
        public Enemy boss;
        private Rectangle? sourceRect;
        private Rectangle sourceRectOne;
        private Rectangle oneRect;
        private Rectangle sourceRectBoss;
        private Rectangle bossRect;
        private InputHandler input;
        public static int zoom = 3;
        private SpriteFont Font1;
        private List<Mob> enemies;
        private List<Rectangle> enemiesRect;
        private List<Rectangle> enemiesSourceRect;
        private Random rand;
        private int theRand;
        private int oldRand;
        private WindowsMediaPlayer mplayer;

        #endregion

        #region Constructor
        public GameState(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
            mplayer = new WMPLib.WindowsMediaPlayer();
            Directory.GetCurrentDirectory();
            mplayer.URL = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase) + @"\Content\songs\mele.mp3";
            mplayer.settings.setMode("loop", true);
            mplayer.controls.stop();
            rand = new Random();
            one = GameState.playerNow;

            enemies = new List<Mob>();
            one.MaxWidth = 4000;
            one.MaxHeight = 2500;
            one.Pics = new Texture2D[4];
            boss = new Boss(2000, 2000);
            one.Speed += 5;
            boss.Speed = (float)2.41;
            Initialize();
            input = new InputHandler(graphics);
            enemiesRect = new List<Rectangle>();
            enemiesSourceRect = new List<Rectangle>();


            for (int i = 0; i < enemies.Count; i++)
            {

                enemiesSourceRect.Add(new Rectangle(270 * enemies[i].Frame, 0, 270, 165));
                enemiesRect.Add(new Rectangle((int)enemies[i].X, (int)enemies[i].Y, 270, 165));
            }
        }

        #endregion

        public static Character playerNow { get; set; }

        #region Methods

        private void Initialize()
        {

            Font1 = Engine.Engine.ContentLoader.Content.Load<SpriteFont>("MyFont");
            background = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/firstmap");

            string[] imageNames = { "images/up", "images/down", "images/left", "images/right" };
            for (int i = 0; i < rand.Next(5, 15); i++)
            {
                enemies.Add(new Mob(rand.Next(1, 300) * rand.Next(1, 10) * rand.Next(5, 10), rand.Next(50, 300) + 200 * rand.Next(5, 10)));
                enemies[i].Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/lizer");
                enemies[i].Speed = rand.Next(2, 3);
            }
            for (int i = 0; i < imageNames.Length; i++)
            {

                one.Pics[i] = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[i]);

            }
            one.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>(imageNames[0]);
            boss.Pic = Engine.Engine.ContentLoader.Content.Load<Texture2D>("images/boss");


        }
        public override void Update(GameTime gameTime)
        {

            input.PlayerMovement(one, true);

            one.Moving();
            one.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            boss.Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].Elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            }

            sourceRectOne = new Rectangle(30 * one.Frame, 0, 30, 60);
            oneRect = new Rectangle((int)one.X, (int)one.Y, 60, 60);

            if (one.Y >= 2100)
            {


                if (boss.X > one.X)
                {

                    boss.X -= boss.Speed;
                } //555 1260
                if (boss.X < one.X)
                {

                    boss.X += boss.Speed;
                }
                if (boss.Y <= one.Y && boss.Y < 2300)
                {

                    boss.Y += boss.Speed;
                }
                if (boss.Y >= one.Y)
                {

                    boss.Y -= boss.Speed;
                }

            }
            sourceRectBoss = new Rectangle(221 * boss.Frame, 0, 221, 226);
            bossRect = new Rectangle((int)boss.X, (int)boss.Y, 221, 226);
            for (int i = 0; i < enemies.Count; i++)
            {
                if (one.Y > 200)
                {
                    if (enemies[i].X > one.X)
                    {
                        enemies[i].X -= enemies[i].Speed;
                    } //555 1260
                    if (boss.X < one.X)
                    {
                        enemies[i].X += enemies[i].Speed;
                    }
                    if (enemies[i].Y <= one.Y && enemies[i].Y < 2300)
                    {
                        enemies[i].Y += enemies[i].Speed;
                    }
                    if (boss.Y >= one.Y)
                    {
                        enemies[i].Y -= enemies[i].Speed;
                    }
                }
            }
            for (int i = 0; i < enemies.Count; i++)
            {
                enemiesSourceRect[i] = new Rectangle(270 * enemies[i].Frame, 0, 270, 165);
                enemiesRect[i] = new Rectangle((int)enemies[i].X, (int)enemies[i].Y, 270, 165);
                if (oneRect.Intersects(enemiesRect[i]))
                {
                    mplayer.controls.play();
                    if (!one.Dead || !enemies[i].Dead)
                    {

                        if (enemies[i].Elapsed >= enemies[i].Delay)
                        {
                            if (enemies[i].Frame >= 2)
                            {
                                enemies[i].Frame = 0;
                            }
                            else
                            {
                                enemies[i].Frame++;
                            }

                            enemies[i].Elapsed = -100;
                        }
                        one.Attack(enemies[i]);
                        one.Life -= enemies[i].Damage;
                        enemies[i].Life -= one.Damage;
                    }
                    if (enemies[i].Dead)
                    {
                        enemies.RemoveAt(i);
                    }
                    else
                    {
                        one.OldX = one.X;
                        one.OldY = one.Y;

                    }
                }
            }
            if (oneRect.Intersects(bossRect))
            {
                if (!one.Dead)
                {


                    if (boss.Elapsed >= boss.Delay)
                    {
                        if (boss.Frame >= 5)
                        {
                            boss.Frame = 0;
                        }
                        else
                        {
                            boss.Frame++;
                        }

                        boss.Elapsed = -100;
                    }
                    one.Attack(boss);
                    one.Life -= boss.Damage;
                    boss.Life -= one.Damage;
                }
                if (boss.Dead)
                {
                    boss.X = -10000000000000;
                }
                /*  one.X = one.OldX;
                one.Y = one.OldY;*/

            }
            else
            {
                one.OldX = one.X;
                one.OldY = one.Y;
            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!one.Dead)
            {
                spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, Camera.CameraMoving((float)one.X, (float)one.Y, 1.5f));

                spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width * zoom, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height * zoom), sourceRect, Color.White);
                spriteBatch.Draw(one.Pic, oneRect, sourceRectOne, Color.White);
                spriteBatch.Draw(boss.Pic, bossRect, sourceRectBoss, Color.White);
                for (int i = 0; i < enemies.Count; i++)
                {
                    spriteBatch.Draw(enemies[i].Pic, enemiesRect[i], enemiesSourceRect[i], Color.White);

                }
                spriteBatch.End();

            }
            else
            {
                spriteBatch.Begin();
                spriteBatch.Draw(background, new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width * zoom, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height * zoom), sourceRect, Color.Black);
                spriteBatch.DrawString(Font1, "You are Dead", new Microsoft.Xna.Framework.Vector2(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2 - 50, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2 - 100), Color.DarkRed);
                spriteBatch.End();
            }

            spriteBatch.Begin();
            spriteBatch.DrawString(Font1, one.ToString(), new Microsoft.Xna.Framework.Vector2(20, 0), Color.DarkRed);
            spriteBatch.DrawString(Font1, enemies.Count.ToString(), new Microsoft.Xna.Framework.Vector2(1000, 0), Color.DarkRed);
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