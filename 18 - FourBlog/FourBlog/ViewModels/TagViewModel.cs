using FourBlog.Models;

namespace FourBlog.ViewModels
{
    public class TagViewModel
    {
        public Tag Tag { get; set; }

        public IList<Tag> Tags { get; set; }
    }
}
