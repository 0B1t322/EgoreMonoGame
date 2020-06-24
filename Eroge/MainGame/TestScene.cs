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
                foreach(IContent dict in contentMap.Content.Values)
                {
                    string contentName = "Slav9";
                    if(dict.ContentName == contentName)
                    {
                        dict.Dispose();
                        this.contentMap.Delete(contentName);
                    }
                }
            }
        }

        public void _Draw(SpriteBatch spriteBatch)
        {
            foreach(IContent content in contentMap.Content.Values)
            {
                content.Draw(spriteBatch);
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

        public void _LoadContent(ContentManager content)
        {
            foreach(var dict in contentMap.Content.Values)
            {
                
            }
        }


        private object _GetContent( object obj )
        {
            return obj;
        }
    }
}


/*delegate( object obj ) 
                    {
                        IContent tmp = obj as IContent;
                        tmp.LoadContent(content); 
                    } */