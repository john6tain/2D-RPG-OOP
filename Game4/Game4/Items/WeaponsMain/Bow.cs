using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Enums;

namespace RPGGame.Items.WeaponsMain
{
    public class Bow : Weapon
    {
        public Bow(string weaponName, string weaponType, int price, float weight, NumOfHands hands, int attackValue, int attackModifier, int damageValue, int damageModifier, params Type[] allowableClasses)
            : base(weaponName, weaponType, price, weight, hands, attackValue, attackModifier, damageValue, damageModifier, allowableClasses)
        {
            weaponName = "Thori'dal, the Stars' Fury";
            weaponType = "Bow";
            price = 2500;
            weight = 5.6f;
            hands = NumOfHands.Two;
            attackValue = 160;
            attackModifier = 0;
            damageValue = 45;
            damageModifier = 0;
            // allowableClasses = ChichoMitko; // allowableClasses na vseki weap trqa da e samo za klasa za koito stava weapona, how to?!?
        }
    }
}
