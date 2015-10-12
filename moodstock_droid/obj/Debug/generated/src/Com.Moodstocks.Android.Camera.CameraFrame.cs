using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraFrame']"
	[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraFrame", DoNotGenerateAcw=true)]
	public partial class CameraFrame : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraFrame']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr orientation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraFrame']/field[@name='orientation']"
		[Register ("orientation")]
		public int Orientation {
			get {
				if (orientation_jfieldId == IntPtr.Zero)
					orientation_jfieldId = JNIEnv.GetFieldID (class_ref, "orientation", "I");
				return JNIEnv.GetIntField (Handle, orientation_jfieldId);
			}
			set {
				if (orientation_jfieldId == IntPtr.Zero)
					orientation_jfieldId = JNIEnv.GetFieldID (class_ref, "orientation", "I");
				try {
					JNIEnv.SetField (Handle, orientation_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraFrame']/field[@name='size']"
		[Register ("size")]
		public global::Com.Moodstocks.Android.Camera.Size Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "Lcom/moodstocks/android/camera/Size;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, size_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "Lcom/moodstocks/android/camera/Size;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, size_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraFrame.ReleaseListener']"
		[Register ("com/moodstocks/android/camera/CameraFrame$ReleaseListener", "", "Com.Moodstocks.Android.Camera.CameraFrame/IReleaseListenerInvoker")]
		public partial interface IReleaseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/interface[@name='CameraFrame.ReleaseListener']/method[@name='onFrameReleased' and count(parameter)=0]"
			[Register ("onFrameReleased", "()V", "GetOnFrameReleasedHandler:Com.Moodstocks.Android.Camera.CameraFrame/IReleaseListenerInvoker, moodstock_droid")]
			void OnFrameReleased ();

		}

		[global::Android.Runtime.Register ("com/moodstocks/android/camera/CameraFrame$ReleaseListener", DoNotGenerateAcw=true)]
		internal class IReleaseListenerInvoker : global::Java.Lang.Object, IReleaseListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/moodstocks/android/camera/CameraFrame$ReleaseListener");
			IntPtr class_ref;

			public static IReleaseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IReleaseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.moodstocks.android.camera.CameraFrame.ReleaseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IReleaseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IReleaseListenerInvoker); }
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
				global::Com.Moodstocks.Android.Camera.CameraFrame.IReleaseListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraFrame.IReleaseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFrameReleased ();
			}
#pragma warning restore 0169

			IntPtr id_onFrameReleased;
			public unsafe void OnFrameReleased ()
			{
				if (id_onFrameReleased == IntPtr.Zero)
					id_onFrameReleased = JNIEnv.GetMethodID (class_ref, "onFrameReleased", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onFrameReleased);
			}

		}

		[global::Android.Runtime.Register ("mono/com/moodstocks/android/camera/CameraFrame_ReleaseListenerImplementor")]
		internal sealed partial class IReleaseListenerImplementor : global::Java.Lang.Object, IReleaseListener {

			object sender;

			public IReleaseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/moodstocks/android/camera/CameraFrame_ReleaseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnFrameReleased ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IReleaseListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/camera/CameraFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraFrame); }
		}

		protected CameraFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_moodstocks_android_camera_CameraFrame_ReleaseListener_arrayBLcom_moodstocks_android_camera_Size_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraFrame']/constructor[@name='CameraFrame' and count(parameter)=4 and parameter[1][@type='com.moodstocks.android.camera.CameraFrame.ReleaseListener'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.moodstocks.android.camera.Size'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lcom/moodstocks/android/camera/CameraFrame$ReleaseListener;[BLcom/moodstocks/android/camera/Size;I)V", "")]
		public unsafe CameraFrame (global::Com.Moodstocks.Android.Camera.CameraFrame.IReleaseListener p0, byte[] p1, global::Com.Moodstocks.Android.Camera.Size p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (CameraFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/moodstocks/android/camera/CameraFrame$ReleaseListener;[BLcom/moodstocks/android/camera/Size;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/moodstocks/android/camera/CameraFrame$ReleaseListener;[BLcom/moodstocks/android/camera/Size;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_moodstocks_android_camera_CameraFrame_ReleaseListener_arrayBLcom_moodstocks_android_camera_Size_I == IntPtr.Zero)
					id_ctor_Lcom_moodstocks_android_camera_CameraFrame_ReleaseListener_arrayBLcom_moodstocks_android_camera_Size_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/moodstocks/android/camera/CameraFrame$ReleaseListener;[BLcom/moodstocks/android/camera/Size;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_moodstocks_android_camera_CameraFrame_ReleaseListener_arrayBLcom_moodstocks_android_camera_Size_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_moodstocks_android_camera_CameraFrame_ReleaseListener_arrayBLcom_moodstocks_android_camera_Size_I, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.CameraFrame __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.CameraFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='CameraFrame']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

	}
}
