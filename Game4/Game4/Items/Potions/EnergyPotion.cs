using Game4.Interfaces;
using Game4.PlayersAndClasses;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.Items.Potions
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