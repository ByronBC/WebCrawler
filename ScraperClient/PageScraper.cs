

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrapySharp.Core;
using ScrapySharp.Html.Parsing;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;

namespace ScraperClient
{
    public static class PageScraper
    {
        public static List<Item> GetItems()
        {
            List<Item> Items = new List<Item>();

            try
            {
                ScrapingBrowser Browser = new ScrapingBrowser();
                Browser.AllowAutoRedirect = true;
                Browser.AllowMetaRedirect = true;

                WebPage PageResult = Browser.NavigateToPage(new Uri("https://news.ycombinator.com/"));

                var Table = PageResult.Html.CssSelect(".itemlist").First();
                var rows = Table.SelectNodes("tr");
                int limit = (rows.Count() < 90 ? rows.Count() / 30 : 30) * 3;
                for (int i = 0; i < limit; i += 3)
                {
                    Item item = Item.Instance();
                    item.Id = int.Parse(rows[i].SelectNodes("td[1]").First().InnerText.Replace(".", "").Trim());
                    item.Title = rows[i].CssSelect(".storylink").First().InnerText;
                    item.Points = int.Parse(rows[i + 1].SelectNodes("td[2]").First().SelectNodes("span[1]").First().InnerText.Split(' ')[0]);
                    if (rows[i + 1].SelectNodes("td[2]").First().InnerText.Contains("comments"))
                        item.Comments = int.Parse(rows[i + 1].SelectNodes("td[2]").First().SelectNodes("a[3]").First().InnerText.Split('&')[0]);
                    Items.Add(item.Clone());
                }
            }
            catch { }
            return Items;
        }
    }
}
