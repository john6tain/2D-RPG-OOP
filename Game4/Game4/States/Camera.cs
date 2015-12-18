using Microsoft.Xna.Framework;

namespace RPGGame.States
{
    public class Camera
    {
        /*private static float cameraX { get; set; }
        private static float cameraY { get; set; }*/
        public static Matrix CameraMoving(float x,float y,float divider)//1.5f
        {
            return Matrix.CreateTranslation(-(x/divider), -(y / divider), 0);
        }
            
    }
}