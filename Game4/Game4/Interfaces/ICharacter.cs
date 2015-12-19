using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.Players;

namespace RPGGame.Interfaces
{
    public interface ICharacter : IAttack, IDefense
    {
        #region PROPERTIES

        double X { get; }
        double Y { get; }
        Texture2D Pic { get; }
        double Life { get; }
        Ability MyAbility { get; }
        float Elapsed { get; }
        int Frame { get; }
        float Delay { get; }
        string Pos { get; }
        int Damage { get; }
        int Speed { get; }
        int Focus { get; }
        int Energy { get; }
        int Coffeine { get; }

        #endregion
    }
}
