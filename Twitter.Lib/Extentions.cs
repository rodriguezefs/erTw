using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erTw
{
    public static class Extensions
    {
        public static string ToWebString(this SortedDictionary<string, string> source)
        {
            var body = new StringBuilder();

            foreach (var requestParameter in source)
            {
                body.Append(requestParameter.Key);
                body.Append("=");
                body.Append(Uri.EscapeDataString(requestParameter.Value));
                body.Append("&");
            }
            //remove trailing '&'
            body.Remove(body.Length - 1, 1);

            return body.ToString();
        }

        public static string ReplaceUrl(string tweetText, 
                                        string oldUrl,
                                        string expandedUrl,
                                        string displayUrl)
        {
            string lxReplaceStrUrl = $"<a href='{expandedUrl}' target='_blank'>{displayUrl}</a>";
            string lxUrl = oldUrl;

            return tweetText.Replace(lxUrl, lxReplaceStrUrl);
        }
    }
}
