using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Enums;

namespace RPGGame.Items.WeaponsMain
{
    public class Dagger : Weapon
    {
        public Dagger(string weaponName, string weaponType, int price, float weight, NumOfHands hands, int attackValue, int attackModifier, int damageValue, int damageModifier, params Type[] allowableClasses)
            : base(weaponName, weaponType, price, weight, hands, attackValue, attackModifier, damageValue, damageModifier, allowableClasses)
        {
            weaponName = "Shadow Daggers";
            weaponType = "Dagger";
            price = 0;
            weight = 1.2f;
            hands = NumOfHands.One;
            attackValue = 155;
            attackModifier = 0;
            damageValue = 40;
            damageModifier = 0;
        }
    }
}
