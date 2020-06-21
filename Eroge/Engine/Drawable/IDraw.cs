using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Eroge.Engine.Drawable
{

    ///<summary>It's interface for interactions between drawable object and mainGameClass</summary>
    interface IDraw
    {
        ///<summary>This method draw into spriteBatch in main game class</summary>
        ///<param name="spriteBatch">Is a spriteBatch in which we draw</param>
        void Draw(SpriteBatch spriteBatch); // method to draw
    }
}
