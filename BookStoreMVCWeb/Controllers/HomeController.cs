using BookStoreMVCWeb.Data;
using BookStoreMVCWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStoreMVCWeb.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
		private readonly BookStoreMVCWebContext _context;
		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BookStoreMVCWebContext context)
        {
            _logger = logger;
			_context = context;
        }

        public async Task< IActionResult> Index(string category)
        {
			var books = string.IsNullOrEmpty(category) ?
				await _context.Books.ToListAsync() :
				await _context.Books.Where(a => a.Category == category).ToListAsync();
			ViewBag.SelectedCategory = category;
			return View(books);

		}
		
		[HttpGet]
		public IActionResult RSS()
		{
			var feed = new SyndicationFeed("Title", "Description", new Uri("https://www.fahasa.com/"), "RSSUrl", DateTime.Now);
			feed.Copyright = new TextSyndicationContent($"{DateTime.Now.Year} Void Geeks");

			var items = new List<SyndicationItem>();
			items.Add(new SyndicationItem("First Article1", "Description1", new Uri("https://www.fahasa.com/sach-trong-nuoc/van-hoc-trong-nuoc/tieu-thuyet.html"), "1", DateTime.Now));
			items.Add(new SyndicationItem("First Article2", "Description2", new Uri("https://www.fahasa.com/foreigncategory.html?order=num_orders&limit=24&p=1"), "2", DateTime.Now));
			items.Add(new SyndicationItem("First Article3", "Description3", new Uri("https://www.fahasa.com/alpha-books?fhs_campaign=homepageicon"), "3", DateTime.Now));
			items.Add(new SyndicationItem("First Articl4", "Description4", new Uri("https://www.fahasa.com/alpha-books?fhs_campaign=homepageicon"), "4", DateTime.Now));

			feed.Items = items;
			var settings = new XmlWriterSettings
			{
				Encoding = Encoding.UTF8,
				NewLineHandling = NewLineHandling.Entitize,
				NewLineOnAttributes = true,
				Indent = true
			};
			using (var stream = new MemoryStream())
			{
				using (var xmlWriter = XmlWriter.Create(stream, settings))
				{
					var rssFormator = new Rss20FeedFormatter(feed, false);
					rssFormator.WriteTo(xmlWriter);
					xmlWriter.Flush();
				}
				return File(stream.ToArray(), "application/rss+xml;charset=utf-8");
			}
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}