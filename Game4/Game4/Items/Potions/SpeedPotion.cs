using System;
using RPGGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.PlayersAndClasses;

namespace RPGGame.Items.Potions
{
	public class SpeedPotion : Item, IDrinkable
	{


		#region Constructor

		public SpeedPotion(Texture2D itemPick, string name, int amountBonus)
			: base(itemPick, name, amountBonus)
		{
			this.Name = "Potion of Swiftness";
			this.AmountBonus = amountBonus;
		}


		#endregion

//		#region Drink Method

//	public void DrinkPotion(string Name, int AmountBonus)
//	{
//
//	}
//
//
//	#endregion


	}
}