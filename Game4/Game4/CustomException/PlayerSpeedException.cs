using System;

namespace RPGGame.CustomException
{
    partial class PlayerSpeedException : Exception
    {
        #region SpeedException
        public PlayerSpeedException(string message)
            : base(message)
        {

        }
        #endregion
    }
}
