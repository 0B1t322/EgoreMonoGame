using Eroge.Engine.ContentLoader;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
namespace Eroge.Engine.Drawable
{
    public abstract class ABSText:
    IContent
    {
        
        private Vector2 _pos;
        public Vector2 Position { get => _pos; set => _pos = value; }


        private SpriteFont _font;
        public SpriteFont Font { get => _font; set => _font = value; }


        private string _text;
        public string Text { get => _text; set => _text = value; }

        private string _contentName;
        public string ContentName {get => _contentName; set => _contentName = value; }

        private Color _color = Color.White;
        public Color Color {get => _color; set => _color = value; }

        protected abstract void _LoadContent(ContentManager content);
        public void LoadContent(ContentManager content) => _LoadContent(content);

        protected abstract void _Draw(SpriteBatch spriteBatch);
        public void Draw(SpriteBatch spriteBatch) => _Draw(spriteBatch);

        // Dispose Object

        private bool disposed = false;

        ///<summary>Delere Sprite</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _pos.Deconstruct(out _pos.X,out _pos.Y);
                    _text = null;
                    byte r = _color.R;
                    byte g = _color.G;
                    byte b = _color.B;

                    _color.Deconstruct( out r, out g, out b);

                    _font = null;
                }

                disposed = true;
            }
        }

        ~ABSText()
        {
            Dispose(false);
        }



    }
}