using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

// NOTE Explicitly declaring this because bindings generator fails with namespaces
// TODO Add related PR to Xamarin/Java.Interop

namespace Google.Android.ExoPlayer2.Source.Ads 
{
    public sealed partial class AdPlaybackState
    {
        // Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer2.source.ads']/class[@name='AdPlaybackState.AdGroup']/field[@name='uris']"
        [Register ("uris")]
        public IList<global::Android.Net.Uri> Uris 
        {
            get {
                const string __id = "uris.[Landroid/net/Uri;";

                var __v = _members.InstanceFields.GetObjectValue (__id, this);
                return global::Android.Runtime.JavaArray<global::Android.Net.Uri>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set {
                const string __id = "uris.[Landroid/net/Uri;";

                IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Net.Uri>.ToLocalJniHandle (value);
                try {
                    _members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
                } finally {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
                }
            }
        }
    }
}
