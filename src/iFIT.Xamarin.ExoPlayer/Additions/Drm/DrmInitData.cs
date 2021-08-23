// NOTE Fixing Java generic interfaces inheritance

namespace Google.Android.ExoPlayer2.Drm 
{
    public sealed partial class DrmInitData
    {
        int global::Java.Util.IComparator.Compare (global::Java.Lang.Object first, global::Java.Lang.Object second)
        {
            return Compare(global::Java.Interop.JavaObjectExtensions.JavaCast<global::Google.Android.ExoPlayer2.Drm.DrmInitData.SchemeData> (first),
                           global::Java.Interop.JavaObjectExtensions.JavaCast<global::Google.Android.ExoPlayer2.Drm.DrmInitData.SchemeData> (second));
        }
    }
}
