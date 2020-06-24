using Microsoft.Xna.Framework.Content;
using Eroge.Engine.Drawable;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Eroge.Engine.ContentLoader
{
    public interface IContent : 
    IContentLoader, IDisposable
    {
        ///<summary>This method draw into spriteBatch in main game class</summary>
        ///<param name="spriteBatch">Is a spriteBatch in which we draw</param>
        void Draw(SpriteBatch spriteBatch); // method to draw

        
        
    }
    
}