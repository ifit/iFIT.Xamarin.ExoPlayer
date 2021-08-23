using System;
using Android.Runtime;

// NOTE This code was copied from generated bindings.
// We removed the related node because it was causing issues.
// BaseRenderer class implements both RendererCapabilities and Renderer interfaces.
// Both of them has getName method. And BaseRenderer doesn't override this method (java allows to inherits interfaces without their implementation for abstract classes).
// Bindings generator doesn't handle such case and it fails to compile it properly by default.

namespace Google.Android.ExoPlayer2
{
    public partial interface IRendererCapabilities
    {
        string Name {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer2']/interface[@name='RendererCapabilities']/method[@name='getName' and count(parameter)=0]"
            [Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Google.Android.ExoPlayer2.IRendererCapabilitiesInvoker, iFIT.Xamarin.ExoPlayer")]
            get; 
        }

    }

    internal partial class IRendererCapabilitiesInvoker
    {
        static Delegate cb_getName;
#pragma warning disable 0169
        static Delegate GetGetNameHandler ()
        {
            if (cb_getName == null)
                cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
            return cb_getName;
        }

        static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Google.Android.ExoPlayer2.IRendererCapabilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.NewString (__this.Name);
        }
#pragma warning restore 0169

        IntPtr id_getName;
        public unsafe string Name {
            get {
                if (id_getName == IntPtr.Zero)
                    id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
                return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
            }
        }
    }
}
