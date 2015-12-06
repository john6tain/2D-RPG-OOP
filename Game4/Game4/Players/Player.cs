using System.Runtime.CompilerServices;
using Game4.Engine;
using Game4.Players;
using Game4.PlayersAndClasses;
using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game4
{
    public abstract class Player
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        protected int x;
        protected int y;
        private float elapsed;
        private float delay;
        private int frame;
        protected Texture2D pic;
        protected double life;
        protected Ability myAbility;
        private string pos;
        //TODO :  class weapon
        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }
        public Texture2D Pic
        {
            get { return this.pic; }
            set { this.pic = value; }
        }

        public double Life
        {
            get { return this.life; }
            set { this.life = value; }
        }

        public Ability MyAbility
        {
            get { return this.myAbility; }
            set { this.myAbility = value; }
        }

        public float Elapsed
        {
            get { return this.elapsed; }
            set { this.elapsed = value; }

        }

        public int Frame
        {
            get { return this.frame; }
            set { this.frame = value; }

        }

        public float Delay
        {
            get { return this.delay; }
            set { this.delay = value; }

        }
        public string Pos
        {
            get { return this.pos; }
            set { this.pos = value; }

        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Delay = 100f;
            this.Frame = 0;
            this.Elapsed = 0;
        }
        public Player(int x, int y, Texture2D pic, double life, Ability myAbility)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Pic = pic;
            this.MyAbility = myAbility;
            this.Delay = 100f;
            this.Frame = 0;
            this.Elapsed = 0;
        }

        #endregion

        #region Moving Method
        /// <summary>
        /// Moving Method
        /// </summary>
        /// <param name="playerIndex"></param>
        /// <param name="keyses"></param>
        /// <param name="backgroundElapsed"></param>
        public void Moving(PlayerIndex playerIndex, Keys[] keyses, ref ScrollingBackground background, GraphicsDeviceManager graphics, Texture2D[] pics)
        {


            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[0])) //left
            {

                if (background.Screenpos.X < (graphics.PreferredBackBufferWidth - 80))
                {
                    background.Update(2, 0, "x", graphics);
                }
                else
                {
                    x-=2;
                }
                if (this.Elapsed >= this.Delay)
                {
                    if (this.Frame >= 1)
                    {
                        this.Frame = 0;
                    }
                    else
                    {
                        this.Frame++;
                    }

                    this.Elapsed = 0;
                }
                this.Pos = "left";
                this.pic = null;
                this.pic = pics[2];
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[1])) //right
            {
                if (background.Screenpos.X <150)
                {
                    background.Update(2f,0,"-x", graphics);
                }
                else
                {
                    x += 2;
                }
                if (x >= graphics.PreferredBackBufferWidth + (graphics.PreferredBackBufferWidth / 2))
                {
                    x -= 2;
                    background.Update(2, 0, "-x", graphics);
                }
                if (elapsed >= delay)
                {
                    if (this.frame >= 1)
                    {
                        frame = 0;
                    }
                    else
                    {
                        frame++;
                    }

                    elapsed = 0;
                }
                this.Pos = "right";
                this.pic = null;
                this.pic = pics[3];
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[2])) //up
            {

                    background.Update(0, 2, "y", graphics);

                if (background.Screenpos.Y >= graphics.PreferredBackBufferHeight)
                {
                    //  y += 2;
                    background.Update(0, 2, "y", graphics);
                }
                if (elapsed >= delay)
                {
                    if (this.frame >= 1)
                    {
                        frame = 0;
                    }
                    else
                    {
                        frame++;
                    }

                    elapsed = 0;
                }
                this.Pos = "up";
                this.pic = null;
                this.pic = pics[0];

            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[3])) //down
            {
                if (background.Screenpos.Y > 400)
                {
                    background.Update(0, 2, "-y", graphics);
                }
                else
                {
                    y += 2;
                }
                if (elapsed >= delay)
                {
                    if (this.frame >= 1)
                    {
                        frame = 0;
                    }
                    else
                    {
                        frame++;
                    }

                    elapsed = 0;
                }
                this.Pos = "down";
                this.pic = null;
                this.pic = pics[1];
            }
        }
        #endregion
    }
}
