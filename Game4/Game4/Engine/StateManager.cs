using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.Engine
{
    public class StateManager
    {
        private static StateManager instance;

        public StateManager()
        {

            Demementions = new Vector2(100, 100);/*GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height,
                                       GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width);*/

        }

        public Vector2 Demementions { get; private set; }

        public static StateManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StateManager();
                }
                return instance;
            }
        }

        public void UnloadCOntent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void LoadContent(ContentManager content)
        {
            this.Content = new ContentManager(content.ServiceProvider, "Content");

        }

        public void Draw(GameTime gameTime)
        {

        }

        public ContentManager Content { get; set; }
    }
}
