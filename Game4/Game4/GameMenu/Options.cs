using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using WMPLib;

namespace Game4
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
        public Options()
        {
            this.fullscreen = true;
            this.resolution = new Vector2(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height);
        }

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
