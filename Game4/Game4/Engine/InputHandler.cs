using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPGGame.Players;
using RPGGame.States;

namespace RPGGame.Engine
{
    public class InputHandler
    {
        #region Fields

        private GraphicsDeviceManager graphics;
        private MenuState menu;
        private StateManager stateManager;
        private Viewport viewport;

        #endregion

        #region Constructor

        public InputHandler(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
        }

        public void CheckForKeyboardInput(StateManager stateManager, Viewport viewport)
        {
            this.stateManager = stateManager;
            this.viewport = viewport;
            if (Keyboard.GetState().IsKeyDown(Keys.RightShift))
            {
                this.graphics.IsFullScreen = false;
                this.graphics.ApplyChanges();
            }
        }

        #endregion

        #region Movement

        public void PlayerMovement(Character player, bool test)//TODO: this shit
        {
            if (test)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.W))
                {
                    player.IsMovingUp = true;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.S))
                {
                    player.IsMovingDown = true;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.A))
                {
                    player.IsMovingLeft = true;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.D))
                {
                    player.IsMovingRight = true;
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Z))
                {
                    GameState.zoom++;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.X))
                {
                    GameState.zoom--;

                }
            }
            else
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    player.IsMovingUp = true;
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
                if (Keyboard.GetState().IsKeyDown(Keys.Z))
                {
                    GameState.zoom++;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.X))
                {
                    GameState.zoom--;

                }
            }

        }
        #endregion

        #region Mouse Move

        public void MouseMovement()
        {


            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);
            if (Keyboard.GetState().IsKeyDown(Keys.Enter) || mouseState.LeftButton == ButtonState.Pressed
                && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 200, 100, 70).Contains(mousePosition)))
            {

                MenuState.mplayer.controls.stop();
                this.stateManager.CurrentState = new GameState(graphics);
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - 100, 100, 70)).Contains(mousePosition))
            {
                Mouse.SetPosition(0, 0);
            }
            if (mouseState.LeftButton == ButtonState.Pressed && (new Rectangle((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - 50, (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2), 100, 70).Contains(mousePosition)))
            {
                MenuState.stopMenu = true;
            }

        }
        #endregion
    }
}
