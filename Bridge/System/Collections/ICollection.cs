using Bridge;

namespace System.Collections 
{
    [Ignore]
    [Namespace("Bridge")]
    public interface ICollection : IEnumerable
    {
        int Count 
        {
            get;
        }
    }
}