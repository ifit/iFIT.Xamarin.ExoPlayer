using Android.Runtime;
using Java.Interop;

// NOTE Java bindings generator doesn't know that he can create static properties in interfaces, it still creates Clock companion class

namespace Google.Android.ExoPlayer2.Util
{
    public partial interface IClock 
	{
		private static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/android/exoplayer2/util/Clock", typeof (IClock));

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer2.util']/interface[@name='Clock']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Google.Android.ExoPlayer2.Util.IClock Default {
			get {
				const string __id = "DEFAULT.Lcom/google/android/exoplayer2/util/Clock;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Google.Android.ExoPlayer2.Util.IClock> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
	}
}
