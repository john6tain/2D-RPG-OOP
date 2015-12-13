using RPGGame.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using RPGGame.PlayersAndClasses;

namespace RPGGame.Items.Potions
{
	public class FocusPotion : Item,IDrinkable
	{
		#region Constructor
		public FocusPotion(Texture2D itemPick,string name,int amountBonus)
			:base(itemPick,name,amountBonus)
		{
			this.Name = "Focus Potion";
			this.AmountBonus = 20;
		}
		#endregion


	//	#region Drink Method

//	public void DrinkPotion(string Name, int AmountBonus)
//	{
//
//	}
//
//
//	#endregion
	}
}