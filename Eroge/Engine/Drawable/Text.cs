using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Eroge.Engine.ConsoleLog;

namespace Eroge.Engine.Drawable
{
    public class Text : ABSText
    {
        public Text()
        {

        }

        public Text(string contentName)
        {
            ContentName = contentName;
        }

        protected override void _LoadContent(ContentManager content)
        {
            Font = content.Load<SpriteFont>(ContentName);
            
        }

        protected override void _Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(
                Font,
                this.Text,
                Position,
                this.Color
            );
        }

        ~Text()
        {
            Dispose(false);
        }
    }
}