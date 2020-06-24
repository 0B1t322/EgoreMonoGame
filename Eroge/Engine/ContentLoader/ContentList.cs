using System.Collections.Generic;
using Eroge.Engine.Drawable;


namespace Eroge.Engine.ContentLoader
{
    public class ContentList
    {
        private List<Sprite> contentList;

        public ContentList()
        {
            contentList = new List<Sprite>();
        }

        public void Add(Sprite sprite)
        {
            contentList.Add(sprite);
        }

        public void Delete(Sprite sprite)
        {
            contentList.Remove(sprite);
        }
    }
}