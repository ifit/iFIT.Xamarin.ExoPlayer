using System.Linq;

// NOTE No way to override base methods with new types in C#

namespace Google.Android.ExoPlayer2
{
    public partial class PlayerEvents
    {
        public bool Contains (PlayerEventFlags eventFlag)
        {
            return base.Contains ((int) eventFlag);
        }

        public bool ContainsAny (params PlayerEventFlags [] eventFlags)
        {
            return base.ContainsAny (eventFlags.Cast<int> ().ToArray ());
        }

        public new PlayerEventFlags Get (int index)
        {
            return (PlayerEventFlags) base.Get (index);
        }
    }
}
