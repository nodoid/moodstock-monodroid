using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']"
	[global::Android.Runtime.Register ("com/moodstocks/android/Result", DoNotGenerateAcw=true)]
	public partial class Result : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Extra']"
		[global::Android.Runtime.Register ("com/moodstocks/android/Result$Extra", DoNotGenerateAcw=true)]
		public sealed partial class Extra : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Extra']/field[@name='CORNERS']"
			[Register ("CORNERS")]
			public const int Corners = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Extra']/field[@name='DIMENSIONS']"
			[Register ("DIMENSIONS")]
			public const int Dimensions = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Extra']/field[@name='HOMOGRAPHY']"
			[Register ("HOMOGRAPHY")]
			public const int Homography = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Extra']/field[@name='NONE']"
			[Register ("NONE")]
			public const int None = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/Result$Extra", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Extra); }
			}

			internal Extra (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Extra']/constructor[@name='Result.Extra' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Extra ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Extra)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Origin']"
		[global::Android.Runtime.Register ("com/moodstocks/android/Result$Origin", DoNotGenerateAcw=true)]
		public sealed partial class Origin : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Origin']/field[@name='CLIENT']"
			[Register ("CLIENT")]
			public const int Client = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Origin']/field[@name='SERVER']"
			[Register ("SERVER")]
			public const int Server = (int) 2;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/Result$Origin", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Origin); }
			}

			internal Origin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Origin']/constructor[@name='Result.Origin' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Origin ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Origin)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']"
		[global::Android.Runtime.Register ("com/moodstocks/android/Result$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/field[@name='DATAMATRIX']"
			[Register ("DATAMATRIX")]
			public const int Datamatrix = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/field[@name='EAN13']"
			[Register ("EAN13")]
			public const int Ean13 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/field[@name='EAN8']"
			[Register ("EAN8")]
			public const int Ean8 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/field[@name='IMAGE']"
			[Register ("IMAGE")]
			public const int Image = (int) -2147483648;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/field[@name='NONE']"
			[Register ("NONE")]
			public const int None = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/field[@name='QRCODE']"
			[Register ("QRCODE")]
			public const int Qrcode = (int) 4;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/Result$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result.Type']/constructor[@name='Result.Type' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Type ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Type)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/Result", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Result); }
		}

		protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHomography;
#pragma warning disable 0169
		static Delegate GetGetHomographyHandler ()
		{
			if (cb_getHomography == null)
				cb_getHomography = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHomography);
			return cb_getHomography;
		}

		static IntPtr n_GetHomography (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Homography);
		}
#pragma warning restore 0169

		static IntPtr id_getHomography;
		public virtual unsafe global::Android.Graphics.Matrix Homography {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getHomography' and count(parameter)=0]"
			[Register ("getHomography", "()Landroid/graphics/Matrix;", "GetGetHomographyHandler")]
			get {
				if (id_getHomography == IntPtr.Zero)
					id_getHomography = JNIEnv.GetMethodID (class_ref, "getHomography", "()Landroid/graphics/Matrix;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getHomography), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHomography", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetObjTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetObjType);
			return cb_getType;
		}

		static int n_GetObjType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjType;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe int ObjType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetObjTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCorners;
#pragma warning disable 0169
		static Delegate GetGetCornersHandler ()
		{
			if (cb_getCorners == null)
				cb_getCorners = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCorners);
			return cb_getCorners;
		}

		static IntPtr n_GetCorners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCorners ());
		}
#pragma warning restore 0169

		static IntPtr id_getCorners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getCorners' and count(parameter)=0]"
		[Register ("getCorners", "()[F", "GetGetCornersHandler")]
		public virtual unsafe float[] GetCorners ()
		{
			if (id_getCorners == IntPtr.Zero)
				id_getCorners = JNIEnv.GetMethodID (class_ref, "getCorners", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getCorners), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCorners", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDataFromBase64URL;
#pragma warning disable 0169
		static Delegate GetGetDataFromBase64URLHandler ()
		{
			if (cb_getDataFromBase64URL == null)
				cb_getDataFromBase64URL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataFromBase64URL);
			return cb_getDataFromBase64URL;
		}

		static IntPtr n_GetDataFromBase64URL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDataFromBase64URL ());
		}
#pragma warning restore 0169

		static IntPtr id_getDataFromBase64URL;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getDataFromBase64URL' and count(parameter)=0]"
		[Register ("getDataFromBase64URL", "()[B", "GetGetDataFromBase64URLHandler")]
		public virtual unsafe byte[] GetDataFromBase64URL ()
		{
			if (id_getDataFromBase64URL == IntPtr.Zero)
				id_getDataFromBase64URL = JNIEnv.GetMethodID (class_ref, "getDataFromBase64URL", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDataFromBase64URL), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataFromBase64URL", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDimensions;
#pragma warning disable 0169
		static Delegate GetGetDimensionsHandler ()
		{
			if (cb_getDimensions == null)
				cb_getDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDimensions);
			return cb_getDimensions;
		}

		static IntPtr n_GetDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDimensions ());
		}
#pragma warning restore 0169

		static IntPtr id_getDimensions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getDimensions' and count(parameter)=0]"
		[Register ("getDimensions", "()[I", "GetGetDimensionsHandler")]
		public virtual unsafe int[] GetDimensions ()
		{
			if (id_getDimensions == IntPtr.Zero)
				id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDimensions), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensions", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getOrigin;
#pragma warning disable 0169
		static Delegate GetGetOriginHandler ()
		{
			if (cb_getOrigin == null)
				cb_getOrigin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrigin);
			return cb_getOrigin;
		}

		static int n_GetOrigin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOrigin ();
		}
#pragma warning restore 0169

		static IntPtr id_getOrigin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='getOrigin' and count(parameter)=0]"
		[Register ("getOrigin", "()I", "GetGetOriginHandler")]
		public virtual unsafe int GetOrigin ()
		{
			if (id_getOrigin == IntPtr.Zero)
				id_getOrigin = JNIEnv.GetMethodID (class_ref, "getOrigin", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getOrigin);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrigin", "()I"));
			} finally {
			}
		}

		static Delegate cb_warpImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetWarpImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_warpImage_Landroid_graphics_Bitmap_ == null)
				cb_warpImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WarpImage_Landroid_graphics_Bitmap_);
			return cb_warpImage_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_WarpImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WarpImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_warpImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='warpImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("warpImage", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetWarpImage_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap WarpImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_warpImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_warpImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "warpImage", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_warpImage_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "warpImage", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_warpImage_Landroid_graphics_Bitmap_F;
#pragma warning disable 0169
		static Delegate GetWarpImage_Landroid_graphics_Bitmap_FHandler ()
		{
			if (cb_warpImage_Landroid_graphics_Bitmap_F == null)
				cb_warpImage_Landroid_graphics_Bitmap_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_WarpImage_Landroid_graphics_Bitmap_F);
			return cb_warpImage_Landroid_graphics_Bitmap_F;
		}

		static IntPtr n_WarpImage_Landroid_graphics_Bitmap_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Moodstocks.Android.Result __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WarpImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_warpImage_Landroid_graphics_Bitmap_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Result']/method[@name='warpImage' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='float']]"
		[Register ("warpImage", "(Landroid/graphics/Bitmap;F)Landroid/graphics/Bitmap;", "GetWarpImage_Landroid_graphics_Bitmap_FHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap WarpImage (global::Android.Graphics.Bitmap p0, float p1)
		{
			if (id_warpImage_Landroid_graphics_Bitmap_F == IntPtr.Zero)
				id_warpImage_Landroid_graphics_Bitmap_F = JNIEnv.GetMethodID (class_ref, "warpImage", "(Landroid/graphics/Bitmap;F)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_warpImage_Landroid_graphics_Bitmap_F, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "warpImage", "(Landroid/graphics/Bitmap;F)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
