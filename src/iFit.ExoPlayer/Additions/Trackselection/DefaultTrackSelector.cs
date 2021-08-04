using System;
using Android.Runtime;
using Java.Interop;

// NOTE Java bindings generator doesn't know how to insert new keyword, that's why we're adding these properties in code

namespace Google.Android.ExoPlayer2.TrackSelection
{
	public partial class DefaultTrackSelector 
	{
		public partial class Parameters 
		{
				[Register ("CREATOR")]
				public new static global::Android.OS.IParcelableCreator Creator {
					get {
						const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";
						
						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				[Register ("DEFAULT_WITHOUT_CONTEXT")]
				public new static global::Google.Android.ExoPlayer2.TrackSelection.DefaultTrackSelector.Parameters DefaultWithoutContext {
					get {
						const string __id = "DEFAULT_WITHOUT_CONTEXT.Lcom/google/android/exoplayer2/trackselection/DefaultTrackSelector$Parameters;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Google.Android.ExoPlayer2.TrackSelection.DefaultTrackSelector.Parameters> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				[Register ("getDefaults", "(Landroid/content/Context;)Lcom/google/android/exoplayer2/trackselection/DefaultTrackSelector$Parameters;", "")]
				public new static unsafe global::Google.Android.ExoPlayer2.TrackSelection.DefaultTrackSelector.Parameters GetDefaults (global::Android.Content.Context context)
				{
					const string __id = "getDefaults.(Landroid/content/Context;)Lcom/google/android/exoplayer2/trackselection/DefaultTrackSelector$Parameters;";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
						return global::Java.Lang.Object.GetObject<global::Google.Android.ExoPlayer2.TrackSelection.DefaultTrackSelector.Parameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
		}
	}
}