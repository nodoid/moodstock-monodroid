using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']"
	[global::Android.Runtime.Register ("com/moodstocks/android/camera/Size", DoNotGenerateAcw=true)]
	public partial class Size : global::Java.Lang.Object {


		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/camera/Size", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Size); }
		}

		protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_hardware_Camera_Size_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']/constructor[@name='Size' and count(parameter)=1 and parameter[1][@type='android.hardware.Camera.Size']]"
		[Register (".ctor", "(Landroid/hardware/Camera$Size;)V", "")]
		protected unsafe Size (global::Android.Hardware.Camera.Size p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Size)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/hardware/Camera$Size;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/hardware/Camera$Size;)V", __args);
					return;
				}

				if (id_ctor_Landroid_hardware_Camera_Size_ == IntPtr.Zero)
					id_ctor_Landroid_hardware_Camera_Size_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/hardware/Camera$Size;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_hardware_Camera_Size_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_hardware_Camera_Size_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']/constructor[@name='Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		protected unsafe Size (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Size)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']/constructor[@name='Size' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Size ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Size)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_isSet;
#pragma warning disable 0169
		static Delegate GetIsSetHandler ()
		{
			if (cb_isSet == null)
				cb_isSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSet);
			return cb_isSet;
		}

		static bool n_IsSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Camera.Size __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Camera.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSet;
		}
#pragma warning restore 0169

		static IntPtr id_isSet;
		protected virtual unsafe bool IsSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.camera']/class[@name='Size']/method[@name='isSet' and count(parameter)=0]"
			[Register ("isSet", "()Z", "GetIsSetHandler")]
			get {
				if (id_isSet == IntPtr.Zero)
					id_isSet = JNIEnv.GetMethodID (class_ref, "isSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSet", "()Z"));
				} finally {
				}
			}
		}

	}
}
