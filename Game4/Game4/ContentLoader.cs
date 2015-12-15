using Microsoft.Xna.Framework.Content;

namespace RPGGame
{
    public class ContentLoader
    {
        public ContentLoader(ContentManager content)
        {
            Content = content;
        }
        public ContentManager Content { get; set; }
    }
}