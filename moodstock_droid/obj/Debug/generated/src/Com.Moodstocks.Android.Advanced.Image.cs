using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Advanced {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image']"
	[global::Android.Runtime.Register ("com/moodstocks/android/advanced/Image", DoNotGenerateAcw=true)]
	public partial class Image : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image.ExifOrientation']"
		[global::Android.Runtime.Register ("com/moodstocks/android/advanced/Image$ExifOrientation", DoNotGenerateAcw=true)]
		public sealed partial class ExifOrientation : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image.ExifOrientation']/field[@name='BOTTOM_RIGHT']"
			[Register ("BOTTOM_RIGHT")]
			public const int BottomRight = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image.ExifOrientation']/field[@name='LEFT_BOTTOM']"
			[Register ("LEFT_BOTTOM")]
			public const int LeftBottom = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image.ExifOrientation']/field[@name='RIGHT_TOP']"
			[Register ("RIGHT_TOP")]
			public const int RightTop = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image.ExifOrientation']/field[@name='TOP_LEFT']"
			[Register ("TOP_LEFT")]
			public const int TopLeft = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image.ExifOrientation']/field[@name='UNDEFINED']"
			[Register ("UNDEFINED")]
			public const int Undefined = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/advanced/Image$ExifOrientation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExifOrientation); }
			}

			internal ExifOrientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/advanced/Image", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Image); }
		}

		protected Image (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image']/constructor[@name='Image' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "([BIII)V", "")]
		public unsafe Image (byte[] p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (Image)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BIII)V", __args);
					return;
				}

				if (id_ctor_arrayBIII == IntPtr.Zero)
					id_ctor_arrayBIII = JNIEnv.GetMethodID (class_ref, "<init>", "([BIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image']/constructor[@name='Image' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe Image (global::Android.Graphics.Bitmap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Image)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, __args);
			} finally {
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
			global::Com.Moodstocks.Android.Advanced.Image __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_retain;
#pragma warning disable 0169
		static Delegate GetRetainHandler ()
		{
			if (cb_retain == null)
				cb_retain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Retain);
			return cb_retain;
		}

		static IntPtr n_Retain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Advanced.Image __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Image> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Retain ());
		}
#pragma warning restore 0169

		static IntPtr id_retain;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Image']/method[@name='retain' and count(parameter)=0]"
		[Register ("retain", "()Lcom/moodstocks/android/advanced/Image;", "GetRetainHandler")]
		public virtual unsafe global::Com.Moodstocks.Android.Advanced.Image Retain ()
		{
			if (id_retain == IntPtr.Zero)
				id_retain = JNIEnv.GetMethodID (class_ref, "retain", "()Lcom/moodstocks/android/advanced/Image;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Image> (JNIEnv.CallObjectMethod  (Handle, id_retain), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Image> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retain", "()Lcom/moodstocks/android/advanced/Image;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
