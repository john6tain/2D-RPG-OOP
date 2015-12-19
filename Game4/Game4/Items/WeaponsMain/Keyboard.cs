using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Enums;

namespace RPGGame.Items.WeaponsMain
{
    public class Keyboard : Weapon
    {
        public Keyboard(string weaponName, string weaponType, int price, float weight, NumOfHands hands, int attackValue, int attackModifier, int damageValue, int damageModifier, params Type[] allowableClasses)
            : base(weaponName, weaponType, price, weight, hands, attackValue, attackModifier, damageValue, damageModifier, allowableClasses)
        {
            weaponName = "";
            weaponType = "Keyboard";
            price = 0;
            weight = 0;
            hands = NumOfHands.Three;
            attackValue = 250;
            attackModifier = 0;
            damageValue = 110;
            damageModifier = 0;

        }
    }
}
