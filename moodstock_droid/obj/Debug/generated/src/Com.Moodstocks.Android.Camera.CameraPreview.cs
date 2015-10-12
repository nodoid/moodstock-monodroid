using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']"
	[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraPreview", DoNotGenerateAcw=true)]
	public partial class CameraPreview : global::Java.Lang.Object, global::Android.Views.ISurfaceHolderCallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraPreview.Listener']"
		[Register ("com/moodstocks/android/camera/CameraPreview$Listener", "", "Com.Moodstocks.Android.Camera.CameraPreview/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraPreview.Listener']/method[@name='onPreviewStarts' and count(parameter)=2 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='com.moodstocks.android.camera.Size']]"
			[Register ("onPreviewStarts", "(Landroid/view/SurfaceHolder;Lcom/moodstocks/android/camera/Size;)V", "GetOnPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_Handler:Com.Moodstocks.Android.Camera.CameraPreview/IListenerInvoker, moodstock_droid")]
			void OnPreviewStarts (global::Android.Views.ISurfaceHolder p0, global::Com.Moodstocks.Android.Camera.Size p1);

		}

		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraPreview$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/moodstocks/android/camera/CameraPreview$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.moodstocks.android.camera.CameraPreview.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_;
#pragma warning disable 0169
			static Delegate GetOnPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_Handler ()
			{
				if (cb_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ == null)
					cb_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_);
				return cb_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_;
			}

			static void n_OnPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Moodstocks.Android.Camera.CameraPreview.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraPreview.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Moodstocks.Android.Camera.Size p1 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPreviewStarts (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_;
			public unsafe void OnPreviewStarts (global::Android.Views.ISurfaceHolder p0, global::Com.Moodstocks.Android.Camera.Size p1)
			{
				if (id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ == IntPtr.Zero)
					id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ = JNIEnv.GetMethodID (class_ref, "onPreviewStarts", "(Landroid/view/SurfaceHolder;Lcom/moodstocks/android/camera/Size;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_, __args);
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (global::Android.Views.ISurfaceHolder p0, global::Com.Moodstocks.Android.Camera.Size p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Views.ISurfaceHolder p0;
			public global::Android.Views.ISurfaceHolder P0 {
				get { return p0; }
			}

			global::Com.Moodstocks.Android.Camera.Size p1;
			public global::Com.Moodstocks.Android.Camera.Size P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/moodstocks/android/camera/CameraPreview_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/moodstocks/android/camera/CameraPreview_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnPreviewStarts (global::Android.Views.ISurfaceHolder p0, global::Com.Moodstocks.Android.Camera.Size p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/camera/CameraPreview", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraPreview); }
		}

		protected CameraPreview (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_SurfaceView_Lcom_moodstocks_android_camera_CameraPreview_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']/constructor[@name='CameraPreview' and count(parameter)=2 and parameter[1][@type='android.view.SurfaceView'] and parameter[2][@type='com.moodstocks.android.camera.CameraPreview.Listener']]"
		[Register (".ctor", "(Landroid/view/SurfaceView;Lcom/moodstocks/android/camera/CameraPreview$Listener;)V", "")]
		protected unsafe CameraPreview (global::Android.Views.SurfaceView p0, global::Com.Moodstocks.Android.Camera.CameraPreview.IListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CameraPreview)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/SurfaceView;Lcom/moodstocks/android/camera/CameraPreview$Listener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/SurfaceView;Lcom/moodstocks/android/camera/CameraPreview$Listener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_SurfaceView_Lcom_moodstocks_android_camera_CameraPreview_Listener_ == IntPtr.Zero)
					id_ctor_Landroid_view_SurfaceView_Lcom_moodstocks_android_camera_CameraPreview_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/SurfaceView;Lcom/moodstocks/android/camera/CameraPreview$Listener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_SurfaceView_Lcom_moodstocks_android_camera_CameraPreview_Listener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_SurfaceView_Lcom_moodstocks_android_camera_CameraPreview_Listener_, __args);
			} finally {
			}
		}

		static Delegate cb_startAsync;
#pragma warning disable 0169
		static Delegate GetStartAsyncHandler ()
		{
			if (cb_startAsync == null)
				cb_startAsync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartAsync);
			return cb_startAsync;
		}

		static void n_StartAsync (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAsync ();
		}
#pragma warning restore 0169

		static IntPtr id_startAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']/method[@name='startAsync' and count(parameter)=0]"
		[Register ("startAsync", "()V", "GetStartAsyncHandler")]
		protected virtual unsafe void StartAsync ()
		{
			if (id_startAsync == IntPtr.Zero)
				id_startAsync = JNIEnv.GetMethodID (class_ref, "startAsync", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startAsync);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAsync", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		protected virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::Com.Moodstocks.Android.Camera.CameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format p1, int p2, int p3)
		{
			if (id_surfaceChanged_Landroid_view_SurfaceHolder_III == IntPtr.Zero)
				id_surfaceChanged_Landroid_view_SurfaceHolder_III = JNIEnv.GetMethodID (class_ref, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceChanged_Landroid_view_SurfaceHolder_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Camera.CameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceCreated_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceCreated_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceCreated_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Camera.CameraPreview __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraPreview> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraPreview']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceDestroyed_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

	}
}
