using RPGGame.Interfaces;
using RPGGame.PlayersAndClasses;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.Items.Potions
{
	public class CoffeinePotion : Item, IDrinkable
	{
		#region Constructor
		public CoffeinePotion(Texture2D itemPick, string name, int amountBonus)
			: base(itemPick, name, amountBonus)
		{
			this.Name = "Coffeine Potion";
			this.AmountBonus = 20;
		}
		#endregion

//	#region Drink Method
//
//	public void DrinkPotion(string Name, int AmountBonus)
//	{
//
//	}
//
//	#endregion

	}
}