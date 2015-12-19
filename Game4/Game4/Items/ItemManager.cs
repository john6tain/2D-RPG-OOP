using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPGGame.Items.ArmorMain;
using RPGGame.Items.WeaponsMain;
using RPGGame.Items.ShieldsMain;

namespace RPGGame.Items
{
    public class ItemManager
    {
        #region Fields Region

        Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>();
        Dictionary<string, Armor> armors = new Dictionary<string, Armor>();
        Dictionary<string, Shields> shields = new Dictionary<string, Shields>();

        #endregion

        #region Keys Property Region

        public Dictionary<string, Weapon>.KeyCollection WeaponKeys
        {
            get { return weapons.Keys; }
        }

        public Dictionary<string, Armor>.KeyCollection ArmorKeys
        {
            get { return armors.Keys; }
        }

        public Dictionary<string, Shields>.KeyCollection ShieldKeys
        {
            get { return shields.Keys; }
        }

        #endregion

        #region Constructor Region

        public ItemManager()
        {

        }

        #endregion

        #region Weapon Methods

        public void AddWeapon(Weapon weapon)
        {
            if (!weapons.ContainsKey(weapon.Name))
            {
                weapons.Add(weapon.Name, weapon);
            }
        }

        public Weapon GetWeapon(string name)
        {
            if (weapons.ContainsKey(name))
            {
                return (Weapon)weapons[name].Clone();
            }

            return null;
        }

        public bool ContainsWeapon(string name)
        {
            return weapons.ContainsKey(name);
        }

        #endregion

        #region Armor Methods

        public void AddArmor(Armor armor)
        {
            if (!armors.ContainsKey(armor.Name))
            {
                armors.Add(armor.Name, armor);
            }
        }

        public Armor GetArmor(string name)
        {
            if (armors.ContainsKey(name))
            {
                return (Armor)armors[name].Clone();
            }

            return null;
        }

        public bool ContainsArmor(string name)
        {
            return armors.ContainsKey(name);
        }

        #endregion

        #region Shields Methods

        public void AddShield(Shields shield)
        {
            if (!shields.ContainsKey(shield.Name))
            {
                shields.Add(shield.Name, shield);
            }
        }

        public Shields GetShield(string name)
        {
            if (shields.ContainsKey(name))
            {
                return (Shields)shields[name].Clone();
            }

            return null;
        }

        public bool ContainsShield(string name)
        {
            return shields.ContainsKey(name);
        }

        #endregion
    }
}
