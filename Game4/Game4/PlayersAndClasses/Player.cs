using Game4.Players;
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
        protected Texture2D pic;
        protected double life;
        protected Ability myAbility;
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
            get { return this.Pic; }
            set { this.Pic = value; }
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
        #endregion

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
        }
    	 public Player(int x, int y, Texture2D pic,double life,Ability myAbility)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Pic = pic;
	        this.MyAbility = myAbility;
        }
        #region Moving Method
        /// <summary>
        /// Method Moving
        /// </summary>
        /// <param name="playerIndex"></param>
        /// <param name="keyses"></param>
        public void Moving(PlayerIndex playerIndex, Keys[] keyses)
        {
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[0]))//left
            {
                x -= 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[1]))//right
            {
                x += 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[2]))//up
            {
                y -= 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[3]))//down
            {
                y += 10;
            }
        }
        #endregion
    }


}
