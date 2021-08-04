// NOTE Fixing Java generic interfaces inheritance

namespace Google.Android.ExoPlayer2.Source.Hls.Playlist 
{
    public partial class HlsMediaPlaylist
    {
        public partial class SegmentBase
        {
            int global::Java.Lang.IComparable.CompareTo (global::Java.Lang.Object obj)
            {
                return CompareTo (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Long> (obj));
            }
        }
    }
}
