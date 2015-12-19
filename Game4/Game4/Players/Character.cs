using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.CustomException;
using RPGGame.Interfaces;
using RPGGame.PlayersAndClasses;

namespace RPGGame.Players
{
    public abstract class Character : ICharacter
    {
        #region Fields Region

        protected double x;
        protected double y;
        private float elapsed;
        private float delay;
        private int frame;
        protected Texture2D pic;
        private double life;
        protected Ability myAbility;
        protected string pos;
        private int damage;
        private int coffeine;
        private int energy;
        private int focus;
        private int speed;

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

        protected Character(double x, double y, Texture2D pic, double life, Ability myAbility, int damage, int speed)
        {
            this.X = x;
            this.Y = y;
            this.Life = 1000;
            this.Pic = pic;
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

        public int Speed
        {
            get { return this.speed; }
            set
            {
                if (speed <= 0)
                {
                    throw new PlayerSpeedException("The speed cannot be negative", "speed limit");
                }
                this.speed = value;
            }
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

        #endregion

        #region Moving Method
        /// <summary>
        /// Moving Method
        /// </summary>
        public void Moving(PlayerIndex playerIndex, Keys[] keyses, ref ScrollingBackground background, GraphicsDeviceManager graphics, Texture2D[] pics)
        {


            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[0])) //left
            {

                if (background.Screenpos.X < (graphics.PreferredBackBufferWidth - 80))
                {
                    background.Update(2, 0, "x", graphics);
                }
                else if (x > 0)
                {

                    x -= 2;
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
                if (background.Screenpos.X > -228)
                {

                    background.Update(2f, 0, "-x", graphics);
                }
                else if (x < 1300)
                {
                    x += 2;
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
                if (background.Screenpos.Y < 490)
                {
                    y -= 0.5;
                    background.Update(0, 2, "y", graphics);
                }
                else if (y > 10)
                {
                    y -= 2;
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
                if (background.Screenpos.Y > -1120)
                {
                    y += 0.5;
                    background.Update(0, 2, "-y", graphics);

                }
                else if (y < 700)
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

        #region Action Methods

        public abstract void Attack(Character character);

        public abstract void Defense(Character character);

        #endregion




    }
}
