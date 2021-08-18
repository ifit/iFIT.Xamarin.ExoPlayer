using System.Linq;

// NOTE No way to override base methods with new types in C#

namespace Google.Android.ExoPlayer2.Analytics
{
    public partial class AnalyticsListenerEvents
    {
        public bool Contains (AnalyticsEventFlags eventFlag)
        {
            return base.Contains ((int) eventFlag);
        }

        public bool ContainsAny (params AnalyticsEventFlags [] eventFlags)
        {
            return base.ContainsAny (eventFlags.Cast<int> ().ToArray ());
        }

        public new AnalyticsEventFlags Get (int index)
        {
            return (AnalyticsEventFlags) base.Get (index);
        }
    }
}