using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Google.Android.ExoPlayer2;
using Google.Android.ExoPlayer2.Additions.Analytics;
using Google.Android.ExoPlayer2.Analytics;
using Google.Android.ExoPlayer2.Source.Hls;
using Google.Android.ExoPlayer2.UI;
using Google.Android.ExoPlayer2.Upstream;

namespace ExoPlayerSample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        const string UriSource = "https://multiplatform-f.akamaihd.net/i/multi/will/bunny/big_buck_bunny_,640x360_400,640x360_700,640x360_1000,950x540_1500,.f4v.csmil/master.m3u8";
        PlayerView playerView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var bandwidthMeter = new DefaultBandwidthMeter.Builder(this).Build();
            
            playerView = FindViewById<PlayerView>(Resource.Id.playerView);
            var player = new SimpleExoPlayer.Builder(this)
                .SetBandwidthMeter(bandwidthMeter)
                .Build();

            var dataSourceFactory = BuildDataSourceFactory(bandwidthMeter, null);
            var mediaSourceFactory = new HlsMediaSource.Factory(dataSourceFactory);
            var mediaItem = MediaItem.FromUri(UriSource);
            var mediaSource = mediaSourceFactory.CreateMediaSource(mediaItem);
            player.SetMediaSource(mediaSource, 0);
            player.Prepare();
            var playbackStatsListener = new PlaybackStatsListener(false, null);
            player.AddAnalyticsListener(playbackStatsListener);

            playerView.Player = player;
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        IDataSourceFactory BuildDataSourceFactory(DefaultBandwidthMeter bandwidthMeter, string userAgent)
        {
            return new DefaultDataSourceFactory(this, bandwidthMeter, BuildStreamingDataSourceFactory(bandwidthMeter, userAgent));
        }

        IDataSourceFactory BuildStreamingDataSourceFactory(DefaultBandwidthMeter bandwidthMeter, string userAgent)
        {
            var dataSource = new DefaultHttpDataSource.Factory();
            dataSource.SetUserAgent(userAgent);
            dataSource.SetTransferListener(bandwidthMeter);
            return dataSource;
        }
    }
}
