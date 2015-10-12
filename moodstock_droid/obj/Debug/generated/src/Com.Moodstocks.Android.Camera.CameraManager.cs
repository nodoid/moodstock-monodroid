using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']"
	[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraManager", DoNotGenerateAcw=true)]
	public partial class CameraManager : global::Android.OS.Handler, global::Com.Moodstocks.Android.Camera.CameraFrame.IReleaseListener, global::Com.Moodstocks.Android.Camera.CameraInstance.IListener, global::Com.Moodstocks.Android.Camera.CameraPreview.IListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager.BackgroundThread']"
		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraManager$BackgroundThread", DoNotGenerateAcw=true)]
		public partial class BackgroundThread : global::Java.Lang.Thread {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager.BackgroundThread.BackgroundThreadHandler']"
			[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraManager$BackgroundThread$BackgroundThreadHandler", DoNotGenerateAcw=true)]
			public partial class BackgroundThreadHandler : global::Android.OS.Handler {

				protected BackgroundThreadHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager.BackgroundThread.MsgCode']"
			[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraManager$BackgroundThread$MsgCode", DoNotGenerateAcw=true)]
			public sealed partial class MsgCode : global::Java.Lang.Object {

				internal MsgCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			protected BackgroundThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager.InitStatus']"
		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraManager$InitStatus", DoNotGenerateAcw=true)]
		public sealed partial class InitStatus : global::Java.Lang.Object {

			internal InitStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraManager.Listener']"
		[Register ("com/moodstocks/android/camera/CameraManager$Listener", "", "Com.Moodstocks.Android.Camera.CameraManager/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			bool IsListening {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraManager.Listener']/method[@name='isListening' and count(parameter)=0]"
				[Register ("isListening", "()Z", "GetIsListeningHandler:Com.Moodstocks.Android.Camera.CameraManager/IListenerInvoker, moodstock_droid")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraManager.Listener']/method[@name='onCameraOpenException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onCameraOpenException", "(Ljava/lang/Exception;)V", "GetOnCameraOpenException_Ljava_lang_Exception_Handler:Com.Moodstocks.Android.Camera.CameraManager/IListenerInvoker, moodstock_droid")]
			void OnCameraOpenException (global::Java.Lang.Exception p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraManager.Listener']/method[@name='onNewFrameInBackground' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.camera.CameraFrame']]"
			[Register ("onNewFrameInBackground", "(Lcom/moodstocks/android/camera/CameraFrame;)V", "GetOnNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_Handler:Com.Moodstocks.Android.Camera.CameraManager/IListenerInvoker, moodstock_droid")]
			void OnNewFrameInBackground (global::Com.Moodstocks.Android.Camera.CameraFrame p0);

		}

		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraManager$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/moodstocks/android/camera/CameraManager$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.moodstocks.android.camera.CameraManager.Listener"));
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

			static Delegate cb_isListening;
#pragma warning disable 0169
			static Delegate GetIsListeningHandler ()
			{
				if (cb_isListening == null)
					cb_isListening = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsListening);
				return cb_isListening;
			}

			static bool n_IsListening (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.Camera.CameraManager.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsListening;
			}
#pragma warning restore 0169

			IntPtr id_isListening;
			public unsafe bool IsListening {
				get {
					if (id_isListening == IntPtr.Zero)
						id_isListening = JNIEnv.GetMethodID (class_ref, "isListening", "()Z");
					return JNIEnv.CallBooleanMethod (Handle, id_isListening);
				}
			}

			static Delegate cb_onCameraOpenException_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnCameraOpenException_Ljava_lang_Exception_Handler ()
			{
				if (cb_onCameraOpenException_Ljava_lang_Exception_ == null)
					cb_onCameraOpenException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraOpenException_Ljava_lang_Exception_);
				return cb_onCameraOpenException_Ljava_lang_Exception_;
			}

			static void n_OnCameraOpenException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.Camera.CameraManager.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpenException (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraOpenException_Ljava_lang_Exception_;
			public unsafe void OnCameraOpenException (global::Java.Lang.Exception p0)
			{
				if (id_onCameraOpenException_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onCameraOpenException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCameraOpenException", "(Ljava/lang/Exception;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onCameraOpenException_Ljava_lang_Exception_, __args);
			}

			static Delegate cb_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_;
#pragma warning disable 0169
			static Delegate GetOnNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_Handler ()
			{
				if (cb_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ == null)
					cb_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_);
				return cb_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_;
			}

			static void n_OnNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.Camera.CameraManager.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Moodstocks.Android.Camera.CameraFrame p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNewFrameInBackground (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_;
			public unsafe void OnNewFrameInBackground (global::Com.Moodstocks.Android.Camera.CameraFrame p0)
			{
				if (id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ == IntPtr.Zero)
					id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ = JNIEnv.GetMethodID (class_ref, "onNewFrameInBackground", "(Lcom/moodstocks/android/camera/CameraFrame;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/camera/CameraManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraManager); }
		}

		protected CameraManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_camera_CameraManager_Listener_Landroid_view_SurfaceView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/constructor[@name='CameraManager' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.moodstocks.android.camera.CameraManager.Listener'] and parameter[3][@type='android.view.SurfaceView']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/moodstocks/android/camera/CameraManager$Listener;Landroid/view/SurfaceView;)V", "")]
		public unsafe CameraManager (global::Android.App.Activity p0, global::Com.Moodstocks.Android.Camera.CameraManager.IListener p1, global::Android.Views.SurfaceView p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (CameraManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Lcom/moodstocks/android/camera/CameraManager$Listener;Landroid/view/SurfaceView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;Lcom/moodstocks/android/camera/CameraManager$Listener;Landroid/view/SurfaceView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_camera_CameraManager_Listener_Landroid_view_SurfaceView_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_camera_CameraManager_Listener_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/moodstocks/android/camera/CameraManager$Listener;Landroid/view/SurfaceView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_camera_CameraManager_Listener_Landroid_view_SurfaceView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_camera_CameraManager_Listener_Landroid_view_SurfaceView_, __args);
			} finally {
			}
		}

		static Delegate cb_onCameraOpenException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnCameraOpenException_Ljava_lang_Exception_Handler ()
		{
			if (cb_onCameraOpenException_Ljava_lang_Exception_ == null)
				cb_onCameraOpenException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraOpenException_Ljava_lang_Exception_);
			return cb_onCameraOpenException_Ljava_lang_Exception_;
		}

		static void n_OnCameraOpenException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraOpenException (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCameraOpenException_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='onCameraOpenException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onCameraOpenException", "(Ljava/lang/Exception;)V", "GetOnCameraOpenException_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnCameraOpenException (global::Java.Lang.Exception p0)
		{
			if (id_onCameraOpenException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onCameraOpenException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCameraOpenException", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraOpenException_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraOpenException", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCameraOpenSuccess;
#pragma warning disable 0169
		static Delegate GetOnCameraOpenSuccessHandler ()
		{
			if (cb_onCameraOpenSuccess == null)
				cb_onCameraOpenSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraOpenSuccess);
			return cb_onCameraOpenSuccess;
		}

		static void n_OnCameraOpenSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraOpenSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_onCameraOpenSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='onCameraOpenSuccess' and count(parameter)=0]"
		[Register ("onCameraOpenSuccess", "()V", "GetOnCameraOpenSuccessHandler")]
		public virtual unsafe void OnCameraOpenSuccess ()
		{
			if (id_onCameraOpenSuccess == IntPtr.Zero)
				id_onCameraOpenSuccess = JNIEnv.GetMethodID (class_ref, "onCameraOpenSuccess", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCameraOpenSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraOpenSuccess", "()V"));
			} finally {
			}
		}

		static Delegate cb_onFrameReleased;
#pragma warning disable 0169
		static Delegate GetOnFrameReleasedHandler ()
		{
			if (cb_onFrameReleased == null)
				cb_onFrameReleased = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFrameReleased);
			return cb_onFrameReleased;
		}

		static void n_OnFrameReleased (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameReleased ();
		}
#pragma warning restore 0169

		static IntPtr id_onFrameReleased;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='onFrameReleased' and count(parameter)=0]"
		[Register ("onFrameReleased", "()V", "GetOnFrameReleasedHandler")]
		public virtual unsafe void OnFrameReleased ()
		{
			if (id_onFrameReleased == IntPtr.Zero)
				id_onFrameReleased = JNIEnv.GetMethodID (class_ref, "onFrameReleased", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFrameReleased);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFrameReleased", "()V"));
			} finally {
			}
		}

		static Delegate cb_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I;
#pragma warning disable 0169
		static Delegate GetOnNewFrame_arrayBLcom_moodstocks_android_camera_Size_IHandler ()
		{
			if (cb_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I == null)
				cb_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnNewFrame_arrayBLcom_moodstocks_android_camera_Size_I);
			return cb_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I;
		}

		static void n_OnNewFrame_arrayBLcom_moodstocks_android_camera_Size_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Moodstocks.Android.Camera.Size p1 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNewFrame (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='onNewFrame' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.moodstocks.android.camera.Size'] and parameter[3][@type='int']]"
		[Register ("onNewFrame", "([BLcom/moodstocks/android/camera/Size;I)V", "GetOnNewFrame_arrayBLcom_moodstocks_android_camera_Size_IHandler")]
		public virtual unsafe void OnNewFrame (byte[] p0, global::Com.Moodstocks.Android.Camera.Size p1, int p2)
		{
			if (id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I == IntPtr.Zero)
				id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I = JNIEnv.GetMethodID (class_ref, "onNewFrame", "([BLcom/moodstocks/android/camera/Size;I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewFrame", "([BLcom/moodstocks/android/camera/Size;I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
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
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Moodstocks.Android.Camera.Size p1 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewStarts (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='onPreviewStarts' and count(parameter)=2 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='com.moodstocks.android.camera.Size']]"
		[Register ("onPreviewStarts", "(Landroid/view/SurfaceHolder;Lcom/moodstocks/android/camera/Size;)V", "GetOnPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_Handler")]
		public virtual unsafe void OnPreviewStarts (global::Android.Views.ISurfaceHolder p0, global::Com.Moodstocks.Android.Camera.Size p1)
		{
			if (id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ == IntPtr.Zero)
				id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_ = JNIEnv.GetMethodID (class_ref, "onPreviewStarts", "(Landroid/view/SurfaceHolder;Lcom/moodstocks/android/camera/Size;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPreviewStarts_Landroid_view_SurfaceHolder_Lcom_moodstocks_android_camera_Size_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreviewStarts", "(Landroid/view/SurfaceHolder;Lcom/moodstocks/android/camera/Size;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start_ZZ;
#pragma warning disable 0169
		static Delegate GetStart_ZZHandler ()
		{
			if (cb_start_ZZ == null)
				cb_start_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_Start_ZZ);
			return cb_start_ZZ;
		}

		static void n_Start_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_start_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='start' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("start", "(ZZ)V", "GetStart_ZZHandler")]
		public virtual unsafe void Start (bool p0, bool p1)
		{
			if (id_start_ZZ == IntPtr.Zero)
				id_start_ZZ = JNIEnv.GetMethodID (class_ref, "start", "(ZZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(ZZ)V"), __args);
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
			global::Com.Moodstocks.Android.Camera.CameraManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraManager']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
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

	}
}
