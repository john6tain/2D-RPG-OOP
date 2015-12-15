using Microsoft.Xna.Framework.Content;
using RpgGame;

namespace RPGGame.Engine
{
    public class StateManager
    {
        private State currentState;
      

        public StateManager()
        {
               currentState = new RPG();
        }

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }
    }
}
