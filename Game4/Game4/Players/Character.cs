using System.Runtime.Remoting.Messaging;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.Interfaces;

namespace RPGGame.Players
{
    public abstract class Character : ICharacter,IAttack
    {

        #region Fields

        protected double x;
        protected double y;
        private float elapsed;
        private float delay;
        private int frame;
        protected Texture2D pic;
        protected Texture2D[] pics;
        private double life;
        protected Ability myAbility;
        protected string pos;
        private int damage;
        private int coffeine;
        private int energy;
        private int focus;
        private float speed;
        protected double oldX;
        protected double oldY;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>

        protected Character(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        protected Character(double x, double y, Texture2D[] pics, double life, Ability myAbility, int damage,
            float speed)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Pics = pics;
            this.MyAbility = myAbility;
            this.Delay = 100f;
            this.Frame = 0;
            this.Elapsed = 0;
            this.Damage = damage;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Properties
        /// </summary>

        public int Coffeine
        {
            get { return this.coffeine; }
            set
            {
                if (value >= 100)
                {
                    value = 100;
                }
                this.coffeine = value;
            }
        }

        public float Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public int Focus
        {
            get { return this.focus; }
            set
            {
                if (value >= 150)
                {
                    value = 150;
                }
                this.focus = value;
            }
        }

        public int Energy
        {
            get { return this.energy; }
            set
            {
                if (value >= 100)
                {
                    value = 100;
                }
                this.energy = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public double X
        {
            get { return this.x; }

            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }

            set { this.y = value; }
        }

        public Texture2D Pic
        {
            get { return this.pic; }
            set { this.pic = value; }
        }

        public Texture2D[] Pics
        {
            get { return this.pics; }
            set { this.pics = value; }
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

                if (value <= 0)
                {
                    Dead = true;
                    this.life = 0;
                }
                else
                {
                    this.life = value;
                }

            }
        }

        public bool Dead { get; set; }

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

        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }
        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }

        #endregion

        #region Moving method

        public void Moving()
        {

            if (IsMovingLeft) //left
            {
                if (x > 0) //TODO:Moonwalk elapsed -100
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

                    this.Elapsed = -100; //For moon walk use -100 Copyright:DCay
                }
                this.Pos = "right";
                this.pic = null;
                this.pic = pics[2]; //For moon walk use 3 Copyright:DCay
                IsMovingLeft = false;
            }
            if (IsMovingRight) //right
            {

                if (x < MaxWidth)
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

                    elapsed = -100;
                }
                this.Pos = "right";
                this.pic = null;
                this.pic = pics[3];
                IsMovingRight = false;
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

                    elapsed = -100;
                }
                this.Pos = "up";
                this.pic = null;
                this.pic = pics[0];
                IsMovingUp = false;

            }
            if (IsMovingDown) //down
            {
                if (y < MaxHeight)
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

                    elapsed = -100;
                }
                this.Pos = "down";
                this.pic = null;
                this.pic = pics[1];
                IsMovingDown = false;
            }
        }

        public double MaxHeight { get; set; }

        public double MaxWidth { get; set; }

        #endregion

        #region Action Methods

        public void Attack(Character character)
        {
            character.Life -= this.Damage;
        }

        public  void Defence(Character character) { }

        #endregion

    }
}
