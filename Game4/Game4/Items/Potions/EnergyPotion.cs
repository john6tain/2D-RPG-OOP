using RPGGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.PlayersAndClasses;

namespace RPGGame.Items.Potions
{
	public class EnergyPotion : Item, IDrinkable
	{
		#region Constructor

		public EnergyPotion(Texture2D itemPick, string name, int amountBonus)
			: base(itemPick, name, amountBonus)
		{
			this.Name = "Energy Potion";
			this.AmountBonus = 20;
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