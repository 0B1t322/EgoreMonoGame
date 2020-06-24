using Eroge.Engine.ContentLoader;

namespace Eroge.Engine.Drawable.UI
{


    public interface IClickable : IContent
    {
        delegate void _lamdaOnClick();
        public void OnClick( _lamdaOnClick func );
    }

    
}