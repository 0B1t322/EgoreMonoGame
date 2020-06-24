using System.Collections.Generic;


namespace Eroge.Engine.ContentLoader
{
    public class ContentMap
    {
        
        private Dictionary<string, List<object> > contentMap;
        

        public Dictionary<string, List<object> >  Content { get => contentMap; }

        public ContentMap()
        {
            
            contentMap = new Dictionary<string, List<object> >();
        }

        public void Add(string contentName, object content)
        {
            var Obj = FindContent(contentName);
            if (Obj == default)
            {
                var list = new List<object>();
                list.Add(content);

                contentMap.Add(contentName, list);
            }
            else
            {
                Obj.Add(content);
            }
        }

        public void Delete(string contentName)
        {
            contentMap.Remove(contentName);
        }

        public List<object> FindContent(string contentName)
        {
            List<object> content = default;
            
            if(contentMap.TryGetValue(contentName,out content) == false)
            {
                ConsoleLog.ConsoleLog.PrintErrorMessage(contentName + " is not find");
            }
            else
            {
                ConsoleLog.ConsoleLog.PrintMessage(contentName + " is find");
            }
            
            return content;
        }
    }
}