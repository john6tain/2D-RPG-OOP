namespace RPGGame.States
{
    public class StateManager
    {
        #region Fields
        private State currentState;
        #endregion

        #region Constructor

        public StateManager()
        {
            currentState = new MenuState();
        }

        #endregion

        #region Properties

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }

        #endregion
    }
}
