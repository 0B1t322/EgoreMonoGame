using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Eroge.Engine.Drawable
{
    ///<summary> Main sprite class </summary>
    public class Sprite : ABSSprite
    {

        public Sprite(string contentName)
        {
            this.ContentName = contentName;
        }
        public Sprite(Texture2D texture, Vector2 pos)
        {
            this.Texture = texture;
            this.Position = pos;
        }

        public void CreateRect(int width, int height)
        {
            this.Rect = new Rectangle( (int)this.Position.X, (int)this.Position.Y,width, height);
        }


        public Sprite()
        {
            
        }
        protected override void _Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture: Texture,
                Rect, // Rectangle
                null,
                color: SpriteColor,
                Rotation,
                origin: Origin,
                SpriteEffects.None // Sprite effects
                ,0.0f // Layer Depth
                ); // Draw end
        }


        ~Sprite()
        {
            Dispose(false);
        }
    }
}