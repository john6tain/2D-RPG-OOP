using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame
{
    public abstract class Player
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        protected double x;
        protected double y;
        public static double speed;
        private float elapsed;
        private float delay;
        private int frame;
        protected Texture2D pic;
        protected double life;
        protected Ability myAbility;
        private string pos;
        protected double oldX;
        protected double oldY;

        //TODO :  class weapon
        #endregion

        #region Properties

        /// <summary>
        /// Properties
        /// </summary>
        public double X
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

        public double Y
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
            set
            {
                if (value > 1000)
                {
                    value = 1000;
                }
                this.life = value;
            }
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

        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }
        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Player(double x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Delay = 100f;
            this.Frame = 0;
            this.Elapsed = 0;
        }
        public Player(double x, int y, Texture2D pic, double life, Ability myAbility)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Pic = pic;
            this.MyAbility = myAbility;
            this.Delay = 100f;
            this.Frame = 0;
            this.Elapsed = 0;
            this.IsMovingUp = false;
        }

        public double OldX
        {
            get { return this.oldX; }
            set { this.oldX = value; }
        }

        public double OldY
        {
            get { return this.oldY; }
            set { this.oldY = value; }
        }

        #endregion

        #region Moving Method
        /// <summary>
        /// Moving Method
        /// </summary>
        /// <param name="playerIndex"></param>
        /// <param name="keyses"></param>
        /// <param name="backgroundElapsed"></param>
        public void Moving(Texture2D[] pics)
        {

            if (IsMovingLeft) //left
            {
                if (x > 0)//TODO:Moonwalk elapsed -100
                {
                    x -= speed;
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

                    this.Elapsed = 0; //For moon walk use -100 Copyright:DCay
                }
                this.Pos = "right";
                this.pic = null;
                this.pic = pics[2]; //For moon walk use 3 Copyright:DCay
                IsMovingLeft = false;
            }
            if (IsMovingRight) //right
            {

                if (x < 3960)
                {
                    x += speed;
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
                this.pic = pics[3]; IsMovingRight = false;
            }
            if (IsMovingUp) //up
            {
                if (y > 10)
                {
                    y -= speed;
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
                IsMovingUp = false;

            }
            if (IsMovingDown) //down
            {
                if (y < 2000)
                {
                    y += speed;
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
                IsMovingDown = false;
            }
        }
        #endregion
    }
}
