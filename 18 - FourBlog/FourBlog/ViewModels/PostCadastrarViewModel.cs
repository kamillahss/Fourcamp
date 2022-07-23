using FourBlog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FourBlog.ViewModels
{
    public class PostCadastrarViewModel
    {
        public Postagem Postagem { get; set; }

        public SelectList TagsSelect { get; set; }

    }
}
