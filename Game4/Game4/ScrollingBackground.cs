using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPGGame.PlayersAndClasses
{
    public class ScrollingBackground
    {
        private Vector2 screenpos, origin, textureSize;
        private Texture2D mytexture;
        private int screenHeight;

        public Vector2 Screenpos
        {
            get { return this.screenpos; }
            set { this.screenpos = value; }
        }

        public void Load(GraphicsDevice device, Texture2D backgroundTexture)
        {
            mytexture = backgroundTexture;
            screenHeight = device.Viewport.Height;
            int screenwidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            // Set the origin so that we're drawing from the 
            // center of the top edge.
            origin = new Vector2(mytexture.Width / 2, 0);
            // Set the screen position to the center of the screen.
            screenpos = new Vector2(screenwidth, screenHeight);
            // Offset to draw the second texture, when necessary.
            textureSize = new Vector2(80, 720);
        }
        public void Update(float deltaX,float deltaY,string isX, GraphicsDeviceManager graphics)
        {
           
                if (isX == "x") //left
                {
                    screenpos.X += deltaX;
                    screenpos.X = screenpos.X%mytexture.Width;
                }
            if (isX=="-x")//right 
            {
                    screenpos.X -= deltaX;
                screenpos.X = screenpos.X%mytexture.Width;
            }
           
            if (isX == "y")//down
            {
                screenpos.Y += deltaY;
                screenpos.Y = screenpos.Y % mytexture.Height;
            }
            if (isX == "-y")//up
            {
                screenpos.Y -= deltaY;
                screenpos.Y = screenpos.Y % mytexture.Height;
            }
        }

        public void Draw(SpriteBatch batch)
        {
            // Draw the texture, if it is still onscreen.
            if (screenpos.X < screenHeight)
            {
                batch.Draw(mytexture, screenpos, null,
                     Color.White, 0, origin, 1, SpriteEffects.None, 0f);
            }

            // Draw the texture a second time, behind the first,
            // to create the scrolling illusion.
            batch.Draw(mytexture, screenpos - textureSize, null,
                 Color.White, 0, origin, 1, SpriteEffects.None, 0f);
        }
    }
}
