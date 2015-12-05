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
        /// FIELDS
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
        //TODO :  class weapan
        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(int x, int y )
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Delay = 100f;
            this.Frame = 0;
            this.Elapsed = 0;
        }
    	 public Player(int x, int y, Texture2D pic,double life,Ability myAbility)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Pic = pic;
	        this.MyAbility = myAbility;
    	     this.Delay = 100f;
    	     this.Frame =0;
    	     this.Elapsed = 0;
        }

        #region Moving Method

        /// <summary>
        /// Method Moving
        /// </summary>
        /// <param name="playerIndex"></param>
        /// <param name="keyses"></param>
        /// <param name="backgroundElapsed"></param>
        public void Moving(PlayerIndex playerIndex, Keys[] keyses,ref ScrollingBackground background,GraphicsDeviceManager graphics, Texture2D[] pics)
        {
          
           
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[0]))//left
            {
                
                if (x>-400)
                {
                    x -= 2;
                    background.Update(2, 0, "x");
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
                this.Pos = "left";
                this.pic = pics[2];
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[1]))//right
            {
                if (x>=graphics.PreferredBackBufferWidth+ (graphics.PreferredBackBufferWidth/2))
                {
                    x -=2 ;
                    background.Update(2,0,"-x");
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
                x += 2;
                this.Pos = "right";
                this.pic = pics[3];
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[2]))//up
            {
             
                if (y >= graphics.PreferredBackBufferHeight )
                {
                  //  y += 2;
                    background.Update(0, 2, "y");
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
                y -= 2;
                this.Pos = "up";
                this.pic = pics[0];

            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[3]))//down
            {
               
                if (y >= graphics.PreferredBackBufferHeight)
                {
                    y --;

                    background.Update(0, 2, "-y");
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
                y += 2;
                this.Pos = "down";
                this.pic = null;
               this.pic = pics[1];
            }
        }
        #endregion
    }


}
