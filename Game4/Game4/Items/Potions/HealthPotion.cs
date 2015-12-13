using RPGGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.PlayersAndClasses;

/// <summary>
/// HealthPotion
/// </summary>

namespace RPGGame.Items.Potions
{
	public class HealthPotion : Item, IDrinkable
	{
		#region Constructor
		//CONSTRUCTOR
		public HealthPotion(Texture2D itemPick, string name, int amountBonus)
			: base(itemPick, name, amountBonus)
		{
			this.Name = "Health Potion";
			this.AmountBonus = 100;
		}
		#endregion



//	#region Drink Method
//
//
//	public void DrinkPotion(string Name, int AmountBonus)
//	{
//
//	}
//
//	#endregion
	}
}