using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Advanced {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']"
	[global::Android.Runtime.Register ("com/moodstocks/android/advanced/Tools", DoNotGenerateAcw=true)]
	public partial class Tools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/advanced/Tools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tools); }
		}

		protected Tools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']/constructor[@name='Tools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tools)) {
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

		static IntPtr id_convertNV21ToBitmap_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']/method[@name='convertNV21ToBitmap' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("convertNV21ToBitmap", "([BIII)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ConvertNV21ToBitmap (byte[] p0, int p1, int p2, int p3)
		{
			if (id_convertNV21ToBitmap_arrayBIII == IntPtr.Zero)
				id_convertNV21ToBitmap_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "convertNV21ToBitmap", "([BIII)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertNV21ToBitmap_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_dataFromBase64URLString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']/method[@name='dataFromBase64URLString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dataFromBase64URLString", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] DataFromBase64URLString (string p0)
		{
			if (id_dataFromBase64URLString_Ljava_lang_String_ == IntPtr.Zero)
				id_dataFromBase64URLString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "dataFromBase64URLString", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_dataFromBase64URLString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_detectProxySettings;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']/method[@name='detectProxySettings' and count(parameter)=0]"
		[Register ("detectProxySettings", "()Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair DetectProxySettings ()
		{
			if (id_detectProxySettings == IntPtr.Zero)
				id_detectProxySettings = JNIEnv.GetStaticMethodID (class_ref, "detectProxySettings", "()Landroid/util/Pair;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_detectProxySettings), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']/method[@name='warpBitmap' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Matrix'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("warpBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap WarpBitmap (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Matrix p1, int p2, int p3)
		{
			if (id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_II == IntPtr.Zero)
				id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_II = JNIEnv.GetStaticMethodID (class_ref, "warpBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_IIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Tools']/method[@name='warpBitmap' and count(parameter)=5 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Matrix'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float']]"
		[Register ("warpBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;IIF)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap WarpBitmap (global::Android.Graphics.Bitmap p0, global::Android.Graphics.Matrix p1, int p2, int p3, float p4)
		{
			if (id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_IIF == IntPtr.Zero)
				id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_IIF = JNIEnv.GetStaticMethodID (class_ref, "warpBitmap", "(Landroid/graphics/Bitmap;Landroid/graphics/Matrix;IIF)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_warpBitmap_Landroid_graphics_Bitmap_Landroid_graphics_Matrix_IIF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
