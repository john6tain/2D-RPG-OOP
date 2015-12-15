using RPGGame.States;
using Microsoft.Xna.Framework.Content;
using RpgGame;

namespace RPGGame.Engine
{
    public class StateManager
    {
        private State currentState;
      

        public StateManager()
        {
              currentState = new MenuState();
        }

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }
    }
}
