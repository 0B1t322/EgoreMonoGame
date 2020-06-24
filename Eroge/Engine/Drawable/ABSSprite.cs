using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Eroge.Engine.ContentLoader;
using Microsoft.Xna.Framework.Content;

// Надо переделать немного свойства, чтобы они заимствовались по интерфесу, 
// потому что не любому классу от ABSSprite понадобиться _Pos и тд.
// Пока переделаю чтобы было достаточно юзать только Rect   


namespace Eroge.Engine.Drawable
{

    /// <summary>Abstarct class of the Sprite</summary>
    public abstract class ABSSprite : 
    IContent
    {
        /// <summary>A sprite texture</summary>
        private Texture2D _texture = null; // the main texture
        

        ///<summary>A property for get and set texture of the sprite</summary>
        public Texture2D Texture { get => _texture; set => _texture = value; }

        /// <summary>A position of the sprite</summary>
        private Vector2 _pos; // position of the sprite

        ///<summary>A property for get and set position of the sprite</summary>
        public Vector2 Position { get => _pos; set => _pos = value; } // property of the position

         private Vector2 _origin = Vector2.Zero; // origin of the sprite

        ///<summary>A property for get and set origin of the sprite</summary>
        public Vector2 Origin { get => _origin; set => _origin = value; }


        /// <summary>A rotation of the sprite.abstract in standart equal 0</summary>
        private float _rotation = 0;

        ///<summary>A property for get and set rotation of the sprite</summary>
        public float Rotation { get => _rotation; set => _rotation = value; }


        ///<summary>Sprite rectangle</summary>
        private Rectangle _rect;


        ///<summary>A property for get and set a react of the sprite</summary>
        public Rectangle Rect { get => _rect; set => _rect = value; }

        ///<summary>Method of create Rect with texture width and texture height</summary>
        public void CreateRect()
        {
            if(Texture != null)
            {
                this.Rect = new Rectangle( (int)this.Position.X, (int)this.Position.Y,Texture.Width, Texture.Height);
            }
            else ConsoleLog.ConsoleLog.PrintErrorMessage("Cant create a Rect, because texture undefind");
        }

        // Я пока не знаю как это впихнуть и надо ли
        /*
        ///<summary>Sprite scale.abstract in standart equal 1, 1</summary>
        private Vector2 _scale = new Vector2(1,1);


        ///<summary>A property for get and set a scale of the sprite</summary>
        public Vector2 Scale { get => _scale; set => _scale = value; }
        */

        ///<summary>Color of the Sprite. In standart equal White</summary>
        private Color _color = Color.White;

        public Color SpriteColor { get => _color; set => _color = value; }

        ///<summary>Method of draw</summary>
        protected abstract void _Draw(SpriteBatch spriteBatch);
        
        public void Draw(SpriteBatch spriteBatch) => _Draw(spriteBatch);

        protected string _content;
        public string ContentName {get => _content; set=> _content = value;}

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>(_content);
            this.CreateRect();
        }



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
                    _texture.Dispose();
                    _rect.Deconstruct(out _rect.X,out _rect.Y,out _rect.Width, out _rect.Height);
                    _pos.Deconstruct(out _pos.X,out _pos.Y);
                    _origin.Deconstruct(out _origin.X, out _origin.Y);

                    byte r = _color.R;
                    byte g = _color.G;
                    byte b = _color.B;

                    _color.Deconstruct( out r, out g, out b);

                    _content = null;

                    
                }

                disposed = true;
            }
        }


        ~ABSSprite()
        {
            Dispose(false);
        }
    }
}