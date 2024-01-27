using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        public ActionResult Index()
        {
            var posts = _postService.GetAllPosts();
            var postVms = new List<PostViewModel>();

            foreach (var post in posts)
            {
                postVms.Add(new PostViewModel()
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    ShortDescription = post.ShortDescription,
                    DatePublished = post.DatePublished,
                    ViewCount = post.ViewCount,
                    RateCount = post.RateCount,
                    UrlSlug = post.UrlSlug,
                });
            }

            return View(postVms);
        }

        public ActionResult Details(int id)
        {
            try
            {
                var post = _postService.FindPost(id);

                if(post != null)
                {
                    var postVm = new PostViewModel()
                    {
                        PostId = post.PostId,
                        Title = post.Title,
                        ShortDescription = post.ShortDescription,
                        DatePublished = post.DatePublished,
                        PostContent = post.PostContent,
                        ViewCount = post.ViewCount,
                        RateCount = post.RateCount,
                        UrlSlug = post.UrlSlug,
                    };

                    return View(postVm);
                }
            }

            catch
            {

            }

            return RedirectToAction("Index");
        }

        public ActionResult Create() { return View(); }

        [HttpPost]
        public IActionResult Create(string title, string urlSlug, string shortDescription, string PostContent, int categoryId)
        {
            _postService.AddPost(new Post { Title = title, UrlSlug = urlSlug, ShortDescription = shortDescription, PostContent = PostContent, DatePublished = DateTime.Now, CategoryId = categoryId });
            return RedirectToAction("Index");
        }

    public ActionResult Edit(int id)
        {
            try
            {
                var post = _postService.FindPost(id);

                if (post != null)
                {
                    var postVm = new PostViewModel() { Title = post.Title, ShortDescription = post.ShortDescription, PostContent = post.PostContent };
                    return View(postVm);
                }
            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string title)
        {
            try
            {
                var post = _postService.FindPost(id);
                if (post != null)
                {
                    post.PostId = id;
                    post.Title = title;

                    _postService.UpdatePost(post);
                }

                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var post = _postService.FindPost(id);
                if (post != null)
                    _postService.DeletePost(post);
            }

            catch
            {

            }

            return RedirectToAction("Index");
        }

        public IActionResult Category(string name)
        {
            var posts = _postService.GetPostsByCategory(name);
            return View(posts);
        }
    }
}
