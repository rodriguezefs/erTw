using erTw.Twitter.Lib;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace erTw.Blazor.Pages
{
    public partial class Index: ComponentBase
    {
        const string ConsumerKey = "cpPeZ6vPXUPbwbiAKrvBvw";
        const string ConsumerKeySecret = "X6jWAvQPpXyfJaznRtR67mGK6AQLkp3HSMpzf1AFY";
        const string AccessToken = "51357501-ZlzXYYQNJwBrtO1mWmQGfdZxvt6OnxzVEg2g564nI";
        const string AccessTokenSecret = "fhb1CAkVSZuoeb5jjWuEWQLxYZACSUeQ1r7fPD0";

        public dynamic TimeLine { get; set; }

        protected override void OnInitialized()
        { 
            var twitter = new Twitter.Lib.Twitter(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            var response = twitter.GetTweetsHome("rodriguezefs", 100);
            TimeLine = JsonConvert.DeserializeObject(response);

        }
    }
}
