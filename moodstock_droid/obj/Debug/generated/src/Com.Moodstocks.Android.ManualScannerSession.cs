using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']"
	[global::Android.Runtime.Register ("com/moodstocks/android/ManualScannerSession", DoNotGenerateAcw=true)]
	public partial class ManualScannerSession : global::Android.OS.Handler, global::Com.Moodstocks.Android.Camera.CameraManager.IListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='ManualScannerSession.Listener']"
		[Register ("com/moodstocks/android/ManualScannerSession$Listener", "", "Com.Moodstocks.Android.ManualScannerSession/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='ManualScannerSession.Listener']/method[@name='onCameraOpenFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onCameraOpenFailed", "(Ljava/lang/Exception;)V", "GetOnCameraOpenFailed_Ljava_lang_Exception_Handler:Com.Moodstocks.Android.ManualScannerSession/IListenerInvoker, moodstock_droid")]
			void OnCameraOpenFailed (global::Java.Lang.Exception p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='ManualScannerSession.Listener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.MoodstocksError']]"
			[Register ("onError", "(Lcom/moodstocks/android/MoodstocksError;)V", "GetOnError_Lcom_moodstocks_android_MoodstocksError_Handler:Com.Moodstocks.Android.ManualScannerSession/IListenerInvoker, moodstock_droid")]
			void OnError (global::Com.Moodstocks.Android.MoodstocksError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='ManualScannerSession.Listener']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='com.moodstocks.android.Result'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register ("onResult", "(Lcom/moodstocks/android/Result;Landroid/graphics/Bitmap;)V", "GetOnResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_Handler:Com.Moodstocks.Android.ManualScannerSession/IListenerInvoker, moodstock_droid")]
			void OnResult (global::Com.Moodstocks.Android.Result p0, global::Android.Graphics.Bitmap p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='ManualScannerSession.Listener']/method[@name='onServerSearchStart' and count(parameter)=0]"
			[Register ("onServerSearchStart", "()V", "GetOnServerSearchStartHandler:Com.Moodstocks.Android.ManualScannerSession/IListenerInvoker, moodstock_droid")]
			void OnServerSearchStart ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='ManualScannerSession.Listener']/method[@name='onWarning' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onWarning", "(Ljava/lang/String;)V", "GetOnWarning_Ljava_lang_String_Handler:Com.Moodstocks.Android.ManualScannerSession/IListenerInvoker, moodstock_droid")]
			void OnWarning (string p0);

		}

		[global::Android.Runtime.Register ("com/moodstocks/android/ManualScannerSession$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/moodstocks/android/ManualScannerSession$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.moodstocks.android.ManualScannerSession.Listener"));
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

			static Delegate cb_onCameraOpenFailed_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnCameraOpenFailed_Ljava_lang_Exception_Handler ()
			{
				if (cb_onCameraOpenFailed_Ljava_lang_Exception_ == null)
					cb_onCameraOpenFailed_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraOpenFailed_Ljava_lang_Exception_);
				return cb_onCameraOpenFailed_Ljava_lang_Exception_;
			}

			static void n_OnCameraOpenFailed_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.ManualScannerSession.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpenFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraOpenFailed_Ljava_lang_Exception_;
			public unsafe void OnCameraOpenFailed (global::Java.Lang.Exception p0)
			{
				if (id_onCameraOpenFailed_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onCameraOpenFailed_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCameraOpenFailed", "(Ljava/lang/Exception;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onCameraOpenFailed_Ljava_lang_Exception_, __args);
			}

			static Delegate cb_onError_Lcom_moodstocks_android_MoodstocksError_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_moodstocks_android_MoodstocksError_Handler ()
			{
				if (cb_onError_Lcom_moodstocks_android_MoodstocksError_ == null)
					cb_onError_Lcom_moodstocks_android_MoodstocksError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_moodstocks_android_MoodstocksError_);
				return cb_onError_Lcom_moodstocks_android_MoodstocksError_;
			}

			static void n_OnError_Lcom_moodstocks_android_MoodstocksError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.ManualScannerSession.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Moodstocks.Android.MoodstocksError p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.MoodstocksError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Lcom_moodstocks_android_MoodstocksError_;
			public unsafe void OnError (global::Com.Moodstocks.Android.MoodstocksError p0)
			{
				if (id_onError_Lcom_moodstocks_android_MoodstocksError_ == IntPtr.Zero)
					id_onError_Lcom_moodstocks_android_MoodstocksError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/moodstocks/android/MoodstocksError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onError_Lcom_moodstocks_android_MoodstocksError_, __args);
			}

			static Delegate cb_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_ == null)
					cb_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_);
				return cb_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_;
			}

			static void n_OnResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Moodstocks.Android.ManualScannerSession.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Moodstocks.Android.Result p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_;
			public unsafe void OnResult (global::Com.Moodstocks.Android.Result p0, global::Android.Graphics.Bitmap p1)
			{
				if (id_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/moodstocks/android/Result;Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onResult_Lcom_moodstocks_android_Result_Landroid_graphics_Bitmap_, __args);
			}

			static Delegate cb_onServerSearchStart;
#pragma warning disable 0169
			static Delegate GetOnServerSearchStartHandler ()
			{
				if (cb_onServerSearchStart == null)
					cb_onServerSearchStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnServerSearchStart);
				return cb_onServerSearchStart;
			}

			static void n_OnServerSearchStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.ManualScannerSession.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnServerSearchStart ();
			}
#pragma warning restore 0169

			IntPtr id_onServerSearchStart;
			public unsafe void OnServerSearchStart ()
			{
				if (id_onServerSearchStart == IntPtr.Zero)
					id_onServerSearchStart = JNIEnv.GetMethodID (class_ref, "onServerSearchStart", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onServerSearchStart);
			}

			static Delegate cb_onWarning_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnWarning_Ljava_lang_String_Handler ()
			{
				if (cb_onWarning_Ljava_lang_String_ == null)
					cb_onWarning_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWarning_Ljava_lang_String_);
				return cb_onWarning_Ljava_lang_String_;
			}

			static void n_OnWarning_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.ManualScannerSession.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWarning (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWarning_Ljava_lang_String_;
			public unsafe void OnWarning (string p0)
			{
				if (id_onWarning_Ljava_lang_String_ == IntPtr.Zero)
					id_onWarning_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWarning", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onWarning_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class CameraOpenFailedEventArgs : global::System.EventArgs {

			public CameraOpenFailedEventArgs (global::Java.Lang.Exception p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Exception p0;
			public global::Java.Lang.Exception P0 {
				get { return p0; }
			}
		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Com.Moodstocks.Android.MoodstocksError p0)
			{
				this.p0 = p0;
			}

			global::Com.Moodstocks.Android.MoodstocksError p0;
			public global::Com.Moodstocks.Android.MoodstocksError P0 {
				get { return p0; }
			}
		}

		public partial class ResultEventArgs : global::System.EventArgs {

			public ResultEventArgs (global::Com.Moodstocks.Android.Result p0, global::Android.Graphics.Bitmap p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Moodstocks.Android.Result p0;
			public global::Com.Moodstocks.Android.Result P0 {
				get { return p0; }
			}

			global::Android.Graphics.Bitmap p1;
			public global::Android.Graphics.Bitmap P1 {
				get { return p1; }
			}
		}

		public partial class WarningEventArgs : global::System.EventArgs {

			public WarningEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/moodstocks/android/ManualScannerSession_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/moodstocks/android/ManualScannerSession_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraOpenFailedEventArgs> OnCameraOpenFailedHandler;
#pragma warning restore 0649

			public void OnCameraOpenFailed (global::Java.Lang.Exception p0)
			{
				var __h = OnCameraOpenFailedHandler;
				if (__h != null)
					__h (sender, new CameraOpenFailedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (global::Com.Moodstocks.Android.MoodstocksError p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ResultEventArgs> OnResultHandler;
#pragma warning restore 0649

			public void OnResult (global::Com.Moodstocks.Android.Result p0, global::Android.Graphics.Bitmap p1)
			{
				var __h = OnResultHandler;
				if (__h != null)
					__h (sender, new ResultEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnServerSearchStartHandler;
#pragma warning restore 0649

			public void OnServerSearchStart ()
			{
				var __h = OnServerSearchStartHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<WarningEventArgs> OnWarningHandler;
#pragma warning restore 0649

			public void OnWarning (string p0)
			{
				var __h = OnWarningHandler;
				if (__h != null)
					__h (sender, new WarningEventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnCameraOpenFailedHandler == null && value.OnErrorHandler == null && value.OnResultHandler == null && value.OnServerSearchStartHandler == null && value.OnWarningHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession.MsgCode']"
		[global::Android.Runtime.Register ("com/moodstocks/android/ManualScannerSession$MsgCode", DoNotGenerateAcw=true)]
		public sealed partial class MsgCode : global::Java.Lang.Object {

			internal MsgCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession.ReturnCode']"
		[global::Android.Runtime.Register ("com/moodstocks/android/ManualScannerSession$ReturnCode", DoNotGenerateAcw=true)]
		public sealed partial class ReturnCode : global::Java.Lang.Object {

			internal ReturnCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession.State']"
		[global::Android.Runtime.Register ("com/moodstocks/android/ManualScannerSession$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession.State']/field[@name='BACKGROUND']"
			[Register ("BACKGROUND")]
			public const int Background = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession.State']/field[@name='FRAME']"
			[Register ("FRAME")]
			public const int Frame = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession.State']/field[@name='SNAP']"
			[Register ("SNAP")]
			public const int Snap = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/ManualScannerSession$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/ManualScannerSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ManualScannerSession); }
		}

		protected ManualScannerSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_Scanner_Lcom_moodstocks_android_ManualScannerSession_Listener_Landroid_view_SurfaceView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/constructor[@name='ManualScannerSession' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.moodstocks.android.Scanner'] and parameter[3][@type='com.moodstocks.android.ManualScannerSession.Listener'] and parameter[4][@type='android.view.SurfaceView']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/moodstocks/android/Scanner;Lcom/moodstocks/android/ManualScannerSession$Listener;Landroid/view/SurfaceView;)V", "")]
		public unsafe ManualScannerSession (global::Android.App.Activity p0, global::Com.Moodstocks.Android.Scanner p1, global::Com.Moodstocks.Android.ManualScannerSession.IListener p2, global::Android.Views.SurfaceView p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ManualScannerSession)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Lcom/moodstocks/android/Scanner;Lcom/moodstocks/android/ManualScannerSession$Listener;Landroid/view/SurfaceView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;Lcom/moodstocks/android/Scanner;Lcom/moodstocks/android/ManualScannerSession$Listener;Landroid/view/SurfaceView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_Scanner_Lcom_moodstocks_android_ManualScannerSession_Listener_Landroid_view_SurfaceView_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_Scanner_Lcom_moodstocks_android_ManualScannerSession_Listener_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/moodstocks/android/Scanner;Lcom/moodstocks/android/ManualScannerSession$Listener;Landroid/view/SurfaceView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_Scanner_Lcom_moodstocks_android_ManualScannerSession_Listener_Landroid_view_SurfaceView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_moodstocks_android_Scanner_Lcom_moodstocks_android_ManualScannerSession_Listener_Landroid_view_SurfaceView_, __args);
			} finally {
			}
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
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		static IntPtr id_isListening;
		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler")]
			get {
				if (id_isListening == IntPtr.Zero)
					id_isListening = JNIEnv.GetMethodID (class_ref, "isListening", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isListening);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isListening", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
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
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraOpenException (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCameraOpenException_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='onCameraOpenException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
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
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Moodstocks.Android.Camera.CameraFrame p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewFrameInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='onNewFrameInBackground' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.camera.CameraFrame']]"
		[Register ("onNewFrameInBackground", "(Lcom/moodstocks/android/camera/CameraFrame;)V", "GetOnNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_Handler")]
		public virtual unsafe void OnNewFrameInBackground (global::Com.Moodstocks.Android.Camera.CameraFrame p0)
		{
			if (id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ == IntPtr.Zero)
				id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_ = JNIEnv.GetMethodID (class_ref, "onNewFrameInBackground", "(Lcom/moodstocks/android/camera/CameraFrame;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onNewFrameInBackground_Lcom_moodstocks_android_camera_CameraFrame_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewFrameInBackground", "(Lcom/moodstocks/android/camera/CameraFrame;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setResultTypes_I;
#pragma warning disable 0169
		static Delegate GetSetResultTypes_IHandler ()
		{
			if (cb_setResultTypes_I == null)
				cb_setResultTypes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResultTypes_I);
			return cb_setResultTypes_I;
		}

		static void n_SetResultTypes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetResultTypes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResultTypes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='setResultTypes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setResultTypes", "(I)V", "GetSetResultTypes_IHandler")]
		public virtual unsafe void SetResultTypes (int p0)
		{
			if (id_setResultTypes_I == IntPtr.Zero)
				id_setResultTypes_I = JNIEnv.GetMethodID (class_ref, "setResultTypes", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResultTypes_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultTypes", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_snap;
#pragma warning disable 0169
		static Delegate GetSnapHandler ()
		{
			if (cb_snap == null)
				cb_snap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Snap);
			return cb_snap;
		}

		static void n_Snap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Snap ();
		}
#pragma warning restore 0169

		static IntPtr id_snap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='snap' and count(parameter)=0]"
		[Register ("snap", "()V", "GetSnapHandler")]
		public virtual unsafe void Snap ()
		{
			if (id_snap == IntPtr.Zero)
				id_snap = JNIEnv.GetMethodID (class_ref, "snap", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_snap);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "snap", "()V"));
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
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
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='stop' and count(parameter)=0]"
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

		static Delegate cb_wantQueryImage_Z;
#pragma warning disable 0169
		static Delegate GetWantQueryImage_ZHandler ()
		{
			if (cb_wantQueryImage_Z == null)
				cb_wantQueryImage_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_WantQueryImage_Z);
			return cb_wantQueryImage_Z;
		}

		static void n_WantQueryImage_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Moodstocks.Android.ManualScannerSession __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.ManualScannerSession> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WantQueryImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_wantQueryImage_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='ManualScannerSession']/method[@name='wantQueryImage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("wantQueryImage", "(Z)V", "GetWantQueryImage_ZHandler")]
		public virtual unsafe void WantQueryImage (bool p0)
		{
			if (id_wantQueryImage_Z == IntPtr.Zero)
				id_wantQueryImage_Z = JNIEnv.GetMethodID (class_ref, "wantQueryImage", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_wantQueryImage_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wantQueryImage", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
