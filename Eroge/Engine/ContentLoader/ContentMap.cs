using System.Collections.Generic;
using Eroge.Engine.Drawable;
using System.Threading.Tasks;


namespace Eroge.Engine.ContentLoader
{
    public class ContentMap
    {
        
        private Dictionary<string, Sprite> content;
        

        public Dictionary<string, Sprite>  Content { get => content; }

        public ContentMap()
        {
            
            content = new Dictionary<string, Sprite>();
        }

        public void Add(string contentName, Sprite sprite)
        {
            content.Add(contentName, sprite);
        }

        public void Delete(string contentName)
        {
            content.Remove(contentName);
        }

        public Sprite FindContent(string contentName)
        {
            Sprite sprite = null;
            if(content.TryGetValue(contentName,out sprite) == false)
            {
                ConsoleLog.ConsoleLog.PrintErrorMessage(contentName + " is not find");
            }
            else
            {
                ConsoleLog.ConsoleLog.PrintMessage(contentName + " is find");
            }
            
            return sprite;
        }
    }
}