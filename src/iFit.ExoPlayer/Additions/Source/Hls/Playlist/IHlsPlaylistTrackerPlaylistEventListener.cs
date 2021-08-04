using System;
using Android.Runtime;

// NOTE We removed this node from Metadata because it fails to generate IHlsPlaylistTrackerPlaylistEventListenerImplementor class with some return
// TODO Add relevant issue to Xamarin/Java.Interop

namespace Google.Android.ExoPlayer2.Source.Hls.Playlist
{
    public partial interface IHlsPlaylistTrackerPlaylistEventListener
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2.source.hls.playlist']/interface[@name='HlsPlaylistTracker.PlaylistEventListener']/method[@name='onPlaylistError' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='long']]"
        [Register ("onPlaylistError", "(Landroid/net/Uri;J)Z", "GetOnPlaylistError_Landroid_net_Uri_JHandler:Google.Android.ExoPlayer2.Source.Hls.Playlist.IHlsPlaylistTrackerPlaylistEventListenerInvoker, iFit.ExoPlayer")]
        bool OnPlaylistError (global::Android.Net.Uri p0, long p1);

    }

    internal partial class IHlsPlaylistTrackerPlaylistEventListenerInvoker : global::Java.Lang.Object, IHlsPlaylistTrackerPlaylistEventListener 
    {
        static Delegate cb_onPlaylistError_Landroid_net_Uri_J;
#pragma warning disable 0169
        static Delegate GetOnPlaylistError_Landroid_net_Uri_JHandler ()
        {
            if (cb_onPlaylistError_Landroid_net_Uri_J == null)
                cb_onPlaylistError_Landroid_net_Uri_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_Z) n_OnPlaylistError_Landroid_net_Uri_J);
            return cb_onPlaylistError_Landroid_net_Uri_J;
        }

        static bool n_OnPlaylistError_Landroid_net_Uri_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Google.Android.ExoPlayer2.Source.Hls.Playlist.IHlsPlaylistTrackerPlaylistEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.OnPlaylistError (p0, p1);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_onPlaylistError_Landroid_net_Uri_J;
        public unsafe bool OnPlaylistError (global::Android.Net.Uri p0, long p1)
        {
            if (id_onPlaylistError_Landroid_net_Uri_J == IntPtr.Zero)
                id_onPlaylistError_Landroid_net_Uri_J = JNIEnv.GetMethodID (class_ref, "onPlaylistError", "(Landroid/net/Uri;J)Z");
            JValue* __args = stackalloc JValue [2];
            __args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
            __args [1] = new JValue (p1);
            var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPlaylistError_Landroid_net_Uri_J, __args);
            return __ret;
        }

    }

    internal partial class IHlsPlaylistTrackerPlaylistEventListenerImplementor
    {
        public bool OnPlaylistError (global::Android.Net.Uri p0, long p1)
        {
            return false;
        }
    }
}
