namespace RPGGame.States
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
