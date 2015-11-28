using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game4
{
    public class Player
    {
        private int x;
        private int y;
       private Texture2D pic;

        public void Moveing(PlayerIndex playerIndex,Keys[] keyses)
        {
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[0]))//left
            {
                x -= 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[1]))//right
            {
                x += 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[2]))//up
            {
                y -= 10;
            }
            if (Keyboard.GetState(playerIndex).IsKeyDown(keyses[3]))//down
            {
                y += 10;
            }
        }
        public Texture2D Pic
        {
            get { return this.pic; }
            set { this.pic = value; }
        }
        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }
}
