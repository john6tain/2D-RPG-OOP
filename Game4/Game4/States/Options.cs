using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.States
{
    class Options : Game
    {
        #region Fields

        private bool fullscreen;
        private Vector2 resolution;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>

        #region Constuctor

        public Options()
        {
            this.fullscreen = true;
            this.resolution = new Vector2(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height);
        }

        #endregion

        #region Properties

        public Vector2 Resolution
        {
            get { return resolution; }
            set { this.resolution = value; }
        }
        public bool FullScreen
        {
            get { return fullscreen; }
            set { this.fullscreen = value; }
        }

        #endregion

    }
}
