using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

// Надо переделать немного свойства, чтобы они заимствовались по интерфесу, 
// потому что не любому классу от ABSSprite понадобиться _Pos и тд.
// Пока переделаю чтобы было достаточно юзать только Rect   


namespace Eroge.Engine.Drawable
{

    /// <summary>Abstarct class of the Sprite</summary>
    public abstract class ABSSprite : IDraw
    {
        /// <summary>A sprite texture</summary>
        private Texture2D _texture; // the main texture

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

        ///<summary>Sprite scale.abstract in standart equal 1, 1</summary>
        private Vector2 _scale = new Vector2(1,1);


        ///<summary>A property for get and set a scale of the sprite</summary>
        public Vector2 Scale { get => _scale; set => _scale = value; }

        ///<summary>Color of the Sprite. In standart equal White</summary>
        private Color _color = Color.White;

        public Color SpriteColor { get => _color; set => _color = value; }

        ///<summary>Method of draw</summary>
        protected abstract void _Draw(SpriteBatch spriteBatch);
        
        public void Draw(SpriteBatch spriteBatch) => _Draw(spriteBatch);
    }
}