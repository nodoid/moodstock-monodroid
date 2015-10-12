using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']"
	[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraInstance", DoNotGenerateAcw=true)]
	public partial class CameraInstance : global::Android.OS.Handler, global::Android.Hardware.Camera.IPreviewCallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraInstance.Listener']"
		[Register ("com/moodstocks/android/camera/CameraInstance$Listener", "", "Com.Moodstocks.Android.Camera.CameraInstance/IListenerInvoker")]
		protected internal partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraInstance.Listener']/method[@name='onCameraOpenException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onCameraOpenException", "(Ljava/lang/Exception;)V", "GetOnCameraOpenException_Ljava_lang_Exception_Handler:Com.Moodstocks.Android.Camera.CameraInstance/IListenerInvoker, moodstock_droid")]
			void OnCameraOpenException (global::Java.Lang.Exception p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraInstance.Listener']/method[@name='onCameraOpenSuccess' and count(parameter)=0]"
			[Register ("onCameraOpenSuccess", "()V", "GetOnCameraOpenSuccessHandler:Com.Moodstocks.Android.Camera.CameraInstance/IListenerInvoker, moodstock_droid")]
			void OnCameraOpenSuccess ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraInstance.Listener']/method[@name='onNewFrame' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.moodstocks.android.camera.Size'] and parameter[3][@type='int']]"
			[Register ("onNewFrame", "([BLcom/moodstocks/android/camera/Size;I)V", "GetOnNewFrame_arrayBLcom_moodstocks_android_camera_Size_IHandler:Com.Moodstocks.Android.Camera.CameraInstance/IListenerInvoker, moodstock_droid")]
			void OnNewFrame (byte[] p0, global::Com.Moodstocks.Android.Camera.Size p1, int p2);

		}

		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraInstance$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/moodstocks/android/camera/CameraInstance$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.moodstocks.android.camera.CameraInstance.Listener"));
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
				global::Com.Moodstocks.Android.Camera.CameraInstance.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Moodstocks.Android.Camera.CameraInstance.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpenSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraOpenSuccess;
			public unsafe void OnCameraOpenSuccess ()
			{
				if (id_onCameraOpenSuccess == IntPtr.Zero)
					id_onCameraOpenSuccess = JNIEnv.GetMethodID (class_ref, "onCameraOpenSuccess", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCameraOpenSuccess);
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
				global::Com.Moodstocks.Android.Camera.CameraInstance.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				global::Com.Moodstocks.Android.Camera.Size p1 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnNewFrame (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I;
			public unsafe void OnNewFrame (byte[] p0, global::Com.Moodstocks.Android.Camera.Size p1, int p2)
			{
				if (id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I == IntPtr.Zero)
					id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I = JNIEnv.GetMethodID (class_ref, "onNewFrame", "([BLcom/moodstocks/android/camera/Size;I)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onNewFrame_arrayBLcom_moodstocks_android_camera_Size_I, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		public partial class CameraOpenExceptionEventArgs : global::System.EventArgs {

			public CameraOpenExceptionEventArgs (global::Java.Lang.Exception p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Exception p0;
			public global::Java.Lang.Exception P0 {
				get { return p0; }
			}
		}

		public partial class NewFrameEventArgs : global::System.EventArgs {

			public NewFrameEventArgs (byte[] p0, global::Com.Moodstocks.Android.Camera.Size p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			byte[] p0;
			public byte[] P0 {
				get { return p0; }
			}

			global::Com.Moodstocks.Android.Camera.Size p1;
			public global::Com.Moodstocks.Android.Camera.Size P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/moodstocks/android/camera/CameraInstance_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/moodstocks/android/camera/CameraInstance_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CameraOpenExceptionEventArgs> OnCameraOpenExceptionHandler;
#pragma warning restore 0649

			public void OnCameraOpenException (global::Java.Lang.Exception p0)
			{
				var __h = OnCameraOpenExceptionHandler;
				if (__h != null)
					__h (sender, new CameraOpenExceptionEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnCameraOpenSuccessHandler;
#pragma warning restore 0649

			public void OnCameraOpenSuccess ()
			{
				var __h = OnCameraOpenSuccessHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<NewFrameEventArgs> OnNewFrameHandler;
#pragma warning restore 0649

			public void OnNewFrame (byte[] p0, global::Com.Moodstocks.Android.Camera.Size p1, int p2)
			{
				var __h = OnNewFrameHandler;
				if (__h != null)
					__h (sender, new NewFrameEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnCameraOpenExceptionHandler == null && value.OnCameraOpenSuccessHandler == null && value.OnNewFrameHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.Msg']"
		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraInstance$Msg", DoNotGenerateAcw=true)]
		public sealed partial class Msg : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.Msg']/field[@name='FAIL']"
			[Register ("FAIL")]
			public const int Fail = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.Msg']/field[@name='OPEN']"
			[Register ("OPEN")]
			public const int Open = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/camera/CameraInstance$Msg", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Msg); }
			}

			internal Msg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.OpenThread']"
		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraInstance$OpenThread", DoNotGenerateAcw=true)]
		public partial class OpenThread : global::Java.Lang.Thread {

			protected OpenThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']"
		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraInstance$PreviewParamsManager", DoNotGenerateAcw=true)]
		public partial class PreviewParamsManager : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/camera/CameraInstance$PreviewParamsManager", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PreviewParamsManager); }
			}

			protected PreviewParamsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ZI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']/constructor[@name='CameraInstance.PreviewParamsManager' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
			[Register (".ctor", "(ZI)V", "")]
			protected unsafe PreviewParamsManager (bool p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (PreviewParamsManager)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZI)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZI)V", __args);
						return;
					}

					if (id_ctor_ZI == IntPtr.Zero)
						id_ctor_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(ZI)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZI, __args);
				} finally {
				}
			}

			static Delegate cb_getDisplayOrientation;
#pragma warning disable 0169
			static Delegate GetGetDisplayOrientationHandler ()
			{
				if (cb_getDisplayOrientation == null)
					cb_getDisplayOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayOrientation);
				return cb_getDisplayOrientation;
			}

			static int n_GetDisplayOrientation (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DisplayOrientation;
			}
#pragma warning restore 0169

			static IntPtr id_getDisplayOrientation;
			protected virtual unsafe int DisplayOrientation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']/method[@name='getDisplayOrientation' and count(parameter)=0]"
				[Register ("getDisplayOrientation", "()I", "GetGetDisplayOrientationHandler")]
				get {
					if (id_getDisplayOrientation == IntPtr.Zero)
						id_getDisplayOrientation = JNIEnv.GetMethodID (class_ref, "getDisplayOrientation", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getDisplayOrientation);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayOrientation", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getFrameOrientation;
#pragma warning disable 0169
			static Delegate GetGetFrameOrientationHandler ()
			{
				if (cb_getFrameOrientation == null)
					cb_getFrameOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameOrientation);
				return cb_getFrameOrientation;
			}

			static int n_GetFrameOrientation (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameOrientation;
			}
#pragma warning restore 0169

			static IntPtr id_getFrameOrientation;
			protected virtual unsafe int FrameOrientation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']/method[@name='getFrameOrientation' and count(parameter)=0]"
				[Register ("getFrameOrientation", "()I", "GetGetFrameOrientationHandler")]
				get {
					if (id_getFrameOrientation == IntPtr.Zero)
						id_getFrameOrientation = JNIEnv.GetMethodID (class_ref, "getFrameOrientation", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod  (Handle, id_getFrameOrientation);
						else
							return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameOrientation", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getFrameSize;
#pragma warning disable 0169
			static Delegate GetGetFrameSizeHandler ()
			{
				if (cb_getFrameSize == null)
					cb_getFrameSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameSize);
				return cb_getFrameSize;
			}

			static IntPtr n_GetFrameSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FrameSize);
			}
#pragma warning restore 0169

			static IntPtr id_getFrameSize;
			protected virtual unsafe global::Com.Moodstocks.Android.Camera.Size FrameSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']/method[@name='getFrameSize' and count(parameter)=0]"
				[Register ("getFrameSize", "()Lcom/moodstocks/android/camera/Size;", "GetGetFrameSizeHandler")]
				get {
					if (id_getFrameSize == IntPtr.Zero)
						id_getFrameSize = JNIEnv.GetMethodID (class_ref, "getFrameSize", "()Lcom/moodstocks/android/camera/Size;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (JNIEnv.CallObjectMethod  (Handle, id_getFrameSize), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameSize", "()Lcom/moodstocks/android/camera/Size;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_setAvailablePreviewSizes_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSetAvailablePreviewSizes_Ljava_util_List_Handler ()
			{
				if (cb_setAvailablePreviewSizes_Ljava_util_List_ == null)
					cb_setAvailablePreviewSizes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAvailablePreviewSizes_Ljava_util_List_);
				return cb_setAvailablePreviewSizes_Ljava_util_List_;
			}

			static void n_SetAvailablePreviewSizes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Moodstocks.Android.Camera.Size>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetAvailablePreviewSizes (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setAvailablePreviewSizes_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']/method[@name='setAvailablePreviewSizes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.moodstocks.android.camera.Size&gt;']]"
			[Register ("setAvailablePreviewSizes", "(Ljava/util/List;)V", "GetSetAvailablePreviewSizes_Ljava_util_List_Handler")]
			protected virtual unsafe void SetAvailablePreviewSizes (global::System.Collections.Generic.IList<global::Com.Moodstocks.Android.Camera.Size> p0)
			{
				if (id_setAvailablePreviewSizes_Ljava_util_List_ == IntPtr.Zero)
					id_setAvailablePreviewSizes_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAvailablePreviewSizes", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Moodstocks.Android.Camera.Size>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAvailablePreviewSizes_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvailablePreviewSizes", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_update_Lcom_moodstocks_android_camera_Size_ZI;
#pragma warning disable 0169
			static Delegate GetUpdate_Lcom_moodstocks_android_camera_Size_ZIHandler ()
			{
				if (cb_update_Lcom_moodstocks_android_camera_Size_ZI == null)
					cb_update_Lcom_moodstocks_android_camera_Size_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int>) n_Update_Lcom_moodstocks_android_camera_Size_ZI);
				return cb_update_Lcom_moodstocks_android_camera_Size_ZI;
			}

			static void n_Update_Lcom_moodstocks_android_camera_Size_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2)
			{
				global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance.PreviewParamsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Moodstocks.Android.Camera.Size p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Update (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_update_Lcom_moodstocks_android_camera_Size_ZI;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance.PreviewParamsManager']/method[@name='update' and count(parameter)=3 and parameter[1][@type='com.moodstocks.android.camera.Size'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
			[Register ("update", "(Lcom/moodstocks/android/camera/Size;ZI)V", "GetUpdate_Lcom_moodstocks_android_camera_Size_ZIHandler")]
			protected virtual unsafe void Update (global::Com.Moodstocks.Android.Camera.Size p0, bool p1, int p2)
			{
				if (id_update_Lcom_moodstocks_android_camera_Size_ZI == IntPtr.Zero)
					id_update_Lcom_moodstocks_android_camera_Size_ZI = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/moodstocks/android/camera/Size;ZI)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_update_Lcom_moodstocks_android_camera_Size_ZI, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/moodstocks/android/camera/Size;ZI)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/camera/CameraInstance", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraInstance); }
		}

		protected CameraInstance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_moodstocks_android_camera_CameraInstance_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/constructor[@name='CameraInstance' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.camera.CameraInstance.Listener']]"
		[Register (".ctor", "(Lcom/moodstocks/android/camera/CameraInstance$Listener;)V", "")]
		protected unsafe CameraInstance (global::Com.Moodstocks.Android.Camera.CameraInstance.IListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CameraInstance)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/moodstocks/android/camera/CameraInstance$Listener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/moodstocks/android/camera/CameraInstance$Listener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_moodstocks_android_camera_CameraInstance_Listener_ == IntPtr.Zero)
					id_ctor_Lcom_moodstocks_android_camera_CameraInstance_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/moodstocks/android/camera/CameraInstance$Listener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_moodstocks_android_camera_CameraInstance_Listener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_moodstocks_android_camera_CameraInstance_Listener_, __args);
			} finally {
			}
		}

		static Delegate cb_isFocussed;
#pragma warning disable 0169
		static Delegate GetIsFocussedHandler ()
		{
			if (cb_isFocussed == null)
				cb_isFocussed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFocussed);
			return cb_isFocussed;
		}

		static bool n_IsFocussed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFocussed;
		}
#pragma warning restore 0169

		static IntPtr id_isFocussed;
		protected virtual unsafe bool IsFocussed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='isFocussed' and count(parameter)=0]"
			[Register ("isFocussed", "()Z", "GetIsFocussedHandler")]
			get {
				if (id_isFocussed == IntPtr.Zero)
					id_isFocussed = JNIEnv.GetMethodID (class_ref, "isFocussed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFocussed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFocussed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		protected virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler ()
		{
			if (cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ == null)
				cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewFrame_arrayBLandroid_hardware_Camera_);
			return cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		}

		static void n_OnPreviewFrame_arrayBLandroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Hardware.Camera p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewFrame (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='onPreviewFrame' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.hardware.Camera']]"
		[Register ("onPreviewFrame", "([BLandroid/hardware/Camera;)V", "GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler")]
		public virtual unsafe void OnPreviewFrame (byte[] p0, global::Android.Hardware.Camera p1)
		{
			if (id_onPreviewFrame_arrayBLandroid_hardware_Camera_ == IntPtr.Zero)
				id_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPreviewFrame_arrayBLandroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_openAsync_ZZ;
#pragma warning disable 0169
		static Delegate GetOpenAsync_ZZHandler ()
		{
			if (cb_openAsync_ZZ == null)
				cb_openAsync_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_OpenAsync_ZZ);
			return cb_openAsync_ZZ;
		}

		static void n_OpenAsync_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenAsync (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_openAsync_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='openAsync' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("openAsync", "(ZZ)V", "GetOpenAsync_ZZHandler")]
		protected virtual unsafe void OpenAsync (bool p0, bool p1)
		{
			if (id_openAsync_ZZ == IntPtr.Zero)
				id_openAsync_ZZ = JNIEnv.GetMethodID (class_ref, "openAsync", "(ZZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_openAsync_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openAsync", "(ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_requestFocus;
#pragma warning disable 0169
		static Delegate GetRequestFocusHandler ()
		{
			if (cb_requestFocus == null)
				cb_requestFocus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestFocus);
			return cb_requestFocus;
		}

		static void n_RequestFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestFocus ();
		}
#pragma warning restore 0169

		static IntPtr id_requestFocus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='requestFocus' and count(parameter)=0]"
		[Register ("requestFocus", "()V", "GetRequestFocusHandler")]
		protected virtual unsafe void RequestFocus ()
		{
			if (id_requestFocus == IntPtr.Zero)
				id_requestFocus = JNIEnv.GetMethodID (class_ref, "requestFocus", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_requestFocus);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestFocus", "()V"));
			} finally {
			}
		}

		static Delegate cb_startPreview_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetStartPreview_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_startPreview_Landroid_view_SurfaceHolder_ == null)
				cb_startPreview_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartPreview_Landroid_view_SurfaceHolder_);
			return cb_startPreview_Landroid_view_SurfaceHolder_;
		}

		static void n_StartPreview_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartPreview (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startPreview_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='startPreview' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("startPreview", "(Landroid/view/SurfaceHolder;)V", "GetStartPreview_Landroid_view_SurfaceHolder_Handler")]
		protected virtual unsafe void StartPreview (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_startPreview_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_startPreview_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "startPreview", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startPreview_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startPreview", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopPreview;
#pragma warning disable 0169
		static Delegate GetStopPreviewHandler ()
		{
			if (cb_stopPreview == null)
				cb_stopPreview = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPreview);
			return cb_stopPreview;
		}

		static void n_StopPreview (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPreview ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPreview;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='stopPreview' and count(parameter)=0]"
		[Register ("stopPreview", "()V", "GetStopPreviewHandler")]
		protected virtual unsafe void StopPreview ()
		{
			if (id_stopPreview == IntPtr.Zero)
				id_stopPreview = JNIEnv.GetMethodID (class_ref, "stopPreview", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stopPreview);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopPreview", "()V"));
			} finally {
			}
		}

		static Delegate cb_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI;
#pragma warning disable 0169
		static Delegate GetUpdatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZIHandler ()
		{
			if (cb_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI == null)
				cb_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, int>) n_UpdatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI);
			return cb_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI;
		}

		static void n_UpdatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2)
		{
			global::Com.Moodstocks.Android.Camera.CameraInstance __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraInstance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Moodstocks.Android.Camera.Size p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePreviewParameters (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraInstance']/method[@name='updatePreviewParameters' and count(parameter)=3 and parameter[1][@type='com.moodstocks.android.camera.Size'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("updatePreviewParameters", "(Lcom/moodstocks/android/camera/Size;ZI)V", "GetUpdatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZIHandler")]
		protected virtual unsafe void UpdatePreviewParameters (global::Com.Moodstocks.Android.Camera.Size p0, bool p1, int p2)
		{
			if (id_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI == IntPtr.Zero)
				id_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI = JNIEnv.GetMethodID (class_ref, "updatePreviewParameters", "(Lcom/moodstocks/android/camera/Size;ZI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updatePreviewParameters_Lcom_moodstocks_android_camera_Size_ZI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePreviewParameters", "(Lcom/moodstocks/android/camera/Size;ZI)V"), __args);
			} finally {
			}
		}

	}
}
