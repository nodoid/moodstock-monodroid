using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader']"
	[global::Android.Runtime.Register ("com/moodstocks/android/core/Loader", DoNotGenerateAcw=true)]
	public partial class Loader : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']"
		[global::Android.Runtime.Register ("com/moodstocks/android/core/Loader$Architecture", DoNotGenerateAcw=true)]
		public sealed partial class Architecture : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']/field[@name='ARM64']"
			[Register ("ARM64")]
			public const int Arm64 = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']/field[@name='ARMv6']"
			[Register ("ARMv6")]
			public const int ARMv6 = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']/field[@name='ARMv7']"
			[Register ("ARMv7")]
			public const int ARMv7 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']/field[@name='ARMv7_NEON']"
			[Register ("ARMv7_NEON")]
			public const int ARMv7NEON = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']/field[@name='x86']"
			[Register ("x86")]
			public const int X86 = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader.Architecture']/field[@name='x86_64']"
			[Register ("x86_64")]
			public const int X8664 = (int) 5;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/core/Loader$Architecture", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Architecture); }
			}

			internal Architecture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/core/Loader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Loader); }
		}

		protected Loader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader']/constructor[@name='Loader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Loader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Loader)) {
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

		static IntPtr id_isCompatible;
		public static unsafe bool IsCompatible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader']/method[@name='isCompatible' and count(parameter)=0]"
			[Register ("isCompatible", "()Z", "GetIsCompatibleHandler")]
			get {
				if (id_isCompatible == IntPtr.Zero)
					id_isCompatible = JNIEnv.GetStaticMethodID (class_ref, "isCompatible", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCompatible);
				} finally {
				}
			}
		}

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.core']/class[@name='Loader']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "")]
		public static unsafe void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetStaticMethodID (class_ref, "load", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_load);
			} finally {
			}
		}

	}
}
