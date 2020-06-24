using Eroge.Engine.Drawable;
using Eroge.Engine.ContentLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Eroge.Engine.ConsoleLog;

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
                foreach(var list in contentMap.Content.Values)
                {
                    foreach(IContent content in list)
                    {
                        string contentName = "Slav9";
                    if(content.ContentName == contentName)
                    {
                        content.Dispose();
                        this.contentMap.Delete(contentName);
                    }
                    }
                    
                    
                }
            }
        }

        public void _Draw(SpriteBatch spriteBatch)
        {
            foreach(var list in contentMap.Content.Values)
            {
                foreach(IContent content in list)
                {
                    content.Draw(spriteBatch);
                }
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
                    ContentName = "Slav9",
                }
            );
            contentMap.Add(
                "Message",
                new Text
                {
                    Position = new Vector2(100, 0),
                    ContentName = "Font",
                    Text = "Hello world"
                }
            );
        }

        public void _LoadContent(ContentManager contentManager)
        {
            foreach(var list in contentMap.Content.Values)
            {
                foreach(IContent content in list)
                {
                    content.LoadContent(contentManager);
                }
            }
        }


        
    }
}


/*delegate( object obj ) 
                    {
                        IContent tmp = obj as IContent;
                        tmp.LoadContent(content); 
                    } */