using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using erTw.Twitter.Lib;

namespace erTw {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        const string ConsumerKey = "cpPeZ6vPXUPbwbiAKrvBvw";
        const string ConsumerKeySecret = "X6jWAvQPpXyfJaznRtR67mGK6AQLkp3HSMpzf1AFY";
        const string AccessToken = "51357501-ZlzXYYQNJwBrtO1mWmQGfdZxvt6OnxzVEg2g564nI";
        const string AccessTokenSecret = "fhb1CAkVSZuoeb5jjWuEWQLxYZACSUeQ1r7fPD0";

        public MainWindow() {
            InitializeComponent();

            GetTweets();
        }

        private void GetTweets() {

            var twitter = new Twitter.Lib.Twitter(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);

            var response = twitter.GetTweetsHome("rodriguezefs", 100);

            var timeline = JsonConvert.DeserializeObject(response);
            lstTweets.DataContext = timeline;
        }
    }
    
}
