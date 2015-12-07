using System.Security.Cryptography.X509Certificates;
using Game4.Interfaces;
using Game4.PlayersAndClasses;
using Microsoft.Xna.Framework.Graphics;

namespace Game4.Items.Potions
{
	public class DamagePotion : Item, IDrinkable
	{

		#region Constructor

		public DamagePotion(Texture2D itemPick, string name, int amountBonus)
			: base(itemPick, name, amountBonus)
		{
			this.Name = "Damage Potion";
			this.AmountBonus = amountBonus;
		}
		#endregion


//	#region Drink Method
//
//	public void DrinkPotion(string Name, int AmountBonus)
//	{
//
//	}
//
//
//	#endregion


	}
}
