using Eroge.Engine.Drawable;
using Eroge.Engine.ContentLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Eroge.Engine.ConsoleLog;
using Eroge.Engine.ContentLoader;

namespace Eroge.MainGame
{
    public class TestScene
    {
        
        private ContentMap contentMap;
        public void _Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.D))
            {
                ConsoleLog.PrintMessage("D is pressed");
                foreach(var dict in contentMap.Content)
                {
                    dict.Value.Dispose();
                    contentMap.Delete("Slav9");
                }
            }
        }

        public void _Draw(SpriteBatch spriteBatch)
        {
            foreach(var sprite in contentMap.Content.Values)
            {
                sprite.Draw(spriteBatch);
            }
        }

        public void _Initialize()
        {
            contentMap = new ContentMap();
            contentMap.Add(
                "Slav9",
                new Sprite
                {
                    Position = new Vector2(50,0),
                    ContentName = "Slav9"
                }
            );
        }

        public void _LoadContent(ContentManager content)
        {
            foreach(IContentLoader dict in contentMap.Content.Values)
            {
                dict.LoadContent(content);
            }
        }
    }
}