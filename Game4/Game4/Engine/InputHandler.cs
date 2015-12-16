using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using RpgGame;
using RPGGame.Engine;
using RPGGame.Engine;
using RPGGame.States;

namespace RPGGame.Engine
{
    public class InputHandler
    {
        private GraphicsDeviceManager graphics;
        private MenuState menu;
        public InputHandler(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
        }

        public void CheckForKeyboardInput(StateManager stateManager)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.RightShift))
            {
                this.graphics.PreferredBackBufferWidth = 1280;
                this.graphics.PreferredBackBufferHeight = 720;
                this.graphics.ToggleFullScreen();
                this.graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Enter)||MenuState.Next)
            {
                stateManager.CurrentState = new GameState(graphics);
            }
            
        }

        public void PlayerMovement(Player player)//TODO: this shit
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                player.IsMovingUp = true;
                Console.Beep();

            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                player.IsMovingDown = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                player.IsMovingLeft = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
               player.IsMovingRight = true;
            }

        }
    }
}
