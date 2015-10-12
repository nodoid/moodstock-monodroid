using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Configuration']"
	[global::Android.Runtime.Register ("com/moodstocks/android/Configuration", DoNotGenerateAcw=true)]
	public partial class Configuration : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Configuration.Platform']"
		[global::Android.Runtime.Register ("com/moodstocks/android/Configuration$Platform", DoNotGenerateAcw=true)]
		public sealed partial class Platform : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Configuration.Platform']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public const int Default = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Configuration.Platform']/field[@name='GOOGLE_GLASS']"
			[Register ("GOOGLE_GLASS")]
			public const int GoogleGlass = (int) 1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/Configuration$Platform", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Platform); }
			}

			internal Platform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Configuration.Platform']/constructor[@name='Configuration.Platform' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Platform ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Platform)) {
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
				return JNIEnv.FindClass ("com/moodstocks/android/Configuration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Configuration); }
		}

		protected Configuration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Configuration']/constructor[@name='Configuration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Configuration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Configuration)) {
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
}
