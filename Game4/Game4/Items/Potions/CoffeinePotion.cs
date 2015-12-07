using Game4.Interfaces;
using Game4.PlayersAndClasses;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.Items.Potions
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