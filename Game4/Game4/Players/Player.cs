using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using RPGGame.Engine;
using RPGGame.Players;
using RPGGame.PlayersAndClasses;
using Microsoft.Win32;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.PlayersAndClasses;
using RPGGame.States;

namespace RPGGame
{

    public abstract class Player : Character
    {
        #region Constructor
        protected Player(double x, double y)
            : base(x, y)
        {

        }

        protected Player(double x, double y, Texture2D pic, double life, Ability myAbility, int damage, int speed)
            : base(x, y, pic, life, myAbility, damage, speed)
        {
        }

        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }
        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        #endregion

        #region Moving
        public void Moving(Texture2D[] playerIndex)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}
