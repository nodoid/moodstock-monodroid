using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']"
	[global::Android.Runtime.Register ("com/moodstocks/android/camera/AutoFocusManager", DoNotGenerateAcw=true)]
	public partial class AutoFocusManager : global::Android.OS.Handler, global::Android.Hardware.Camera.IAutoFocusCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/camera/AutoFocusManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AutoFocusManager); }
		}

		protected AutoFocusManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_hardware_Camera_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']/constructor[@name='AutoFocusManager' and count(parameter)=1 and parameter[1][@type='android.hardware.Camera']]"
		[Register (".ctor", "(Landroid/hardware/Camera;)V", "")]
		protected unsafe AutoFocusManager (global::Android.Hardware.Camera p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AutoFocusManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/hardware/Camera;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/hardware/Camera;)V", __args);
					return;
				}

				if (id_ctor_Landroid_hardware_Camera_ == IntPtr.Zero)
					id_ctor_Landroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/hardware/Camera;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_hardware_Camera_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_hardware_Camera_, __args);
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
			global::Com.Moodstocks.Android.Camera.AutoFocusManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.AutoFocusManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFocussed;
		}
#pragma warning restore 0169

		static IntPtr id_isFocussed;
		protected virtual unsafe bool IsFocussed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']/method[@name='isFocussed' and count(parameter)=0]"
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

		static Delegate cb_onAutoFocus_ZLandroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetOnAutoFocus_ZLandroid_hardware_Camera_Handler ()
		{
			if (cb_onAutoFocus_ZLandroid_hardware_Camera_ == null)
				cb_onAutoFocus_ZLandroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnAutoFocus_ZLandroid_hardware_Camera_);
			return cb_onAutoFocus_ZLandroid_hardware_Camera_;
		}

		static void n_OnAutoFocus_ZLandroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Moodstocks.Android.Camera.AutoFocusManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.AutoFocusManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAutoFocus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAutoFocus_ZLandroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']/method[@name='onAutoFocus' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='android.hardware.Camera']]"
		[Register ("onAutoFocus", "(ZLandroid/hardware/Camera;)V", "GetOnAutoFocus_ZLandroid_hardware_Camera_Handler")]
		public virtual unsafe void OnAutoFocus (bool p0, global::Android.Hardware.Camera p1)
		{
			if (id_onAutoFocus_ZLandroid_hardware_Camera_ == IntPtr.Zero)
				id_onAutoFocus_ZLandroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "onAutoFocus", "(ZLandroid/hardware/Camera;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAutoFocus_ZLandroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAutoFocus", "(ZLandroid/hardware/Camera;)V"), __args);
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
			global::Com.Moodstocks.Android.Camera.AutoFocusManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.AutoFocusManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestFocus ();
		}
#pragma warning restore 0169

		static IntPtr id_requestFocus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']/method[@name='requestFocus' and count(parameter)=0]"
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
			global::Com.Moodstocks.Android.Camera.AutoFocusManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.AutoFocusManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		protected virtual unsafe void Start ()
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
			global::Com.Moodstocks.Android.Camera.AutoFocusManager __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.AutoFocusManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='AutoFocusManager']/method[@name='stop' and count(parameter)=0]"
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

	}
}
