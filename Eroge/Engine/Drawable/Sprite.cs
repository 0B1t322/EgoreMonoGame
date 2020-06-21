using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Eroge.Engine.Drawable
{
    ///<summary> Main sprite class </summary>
    public class Sprite : ABSSprite
    {

        public Sprite(Texture2D texture)
        {
            this.Texture = texture;
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

        public void CreateRect()
        {
            this.Rect = new Rectangle( (int)this.Position.X, (int)this.Position.Y,Texture.Width, Texture.Height);
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
    }
}