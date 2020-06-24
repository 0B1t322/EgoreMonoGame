using Microsoft.Xna.Framework.Content;

namespace Eroge.Engine.ContentLoader
{
    public interface IContentLoader
    {
        void LoadContent(ContentManager content);


        string ContentName {get; set;}
    }
}