using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Advanced {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher']"
	[global::Android.Runtime.Register ("com/moodstocks/android/advanced/ApiSearcher", DoNotGenerateAcw=true)]
	public partial class ApiSearcher : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher.Status']"
		[global::Android.Runtime.Register ("com/moodstocks/android/advanced/ApiSearcher$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher.Status']/field[@name='ENDED']"
			[Register ("ENDED")]
			public const int Ended = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher.Status']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public const int Running = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher.Status']/field[@name='WAITING']"
			[Register ("WAITING")]
			public const int Waiting = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/advanced/ApiSearcher$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher.Status']/constructor[@name='ApiSearcher.Status' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Status ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Status)) {
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
				return JNIEnv.FindClass ("com/moodstocks/android/advanced/ApiSearcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiSearcher); }
		}

		protected ApiSearcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_moodstocks_android_Scanner_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher']/constructor[@name='ApiSearcher' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.Scanner']]"
		[Register (".ctor", "(Lcom/moodstocks/android/Scanner;)V", "")]
		public unsafe ApiSearcher (global::Com.Moodstocks.Android.Scanner p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ApiSearcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/moodstocks/android/Scanner;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/moodstocks/android/Scanner;)V", __args);
					return;
				}

				if (id_ctor_Lcom_moodstocks_android_Scanner_ == IntPtr.Zero)
					id_ctor_Lcom_moodstocks_android_Scanner_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/moodstocks/android/Scanner;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_moodstocks_android_Scanner_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_moodstocks_android_Scanner_, __args);
			} finally {
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
			global::Com.Moodstocks.Android.Advanced.ApiSearcher __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.ApiSearcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher']/method[@name='cancel' and count(parameter)=0]"
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

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Advanced.ApiSearcher __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.ApiSearcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()I", "GetGetStatusHandler")]
		public virtual unsafe int GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getStatus);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
			} finally {
			}
		}

		static Delegate cb_search_Lcom_moodstocks_android_advanced_Image_;
#pragma warning disable 0169
		static Delegate GetSearch_Lcom_moodstocks_android_advanced_Image_Handler ()
		{
			if (cb_search_Lcom_moodstocks_android_advanced_Image_ == null)
				cb_search_Lcom_moodstocks_android_advanced_Image_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Search_Lcom_moodstocks_android_advanced_Image_);
			return cb_search_Lcom_moodstocks_android_advanced_Image_;
		}

		static IntPtr n_Search_Lcom_moodstocks_android_advanced_Image_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Advanced.ApiSearcher __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.ApiSearcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Moodstocks.Android.Advanced.Image p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Image> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Search (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_search_Lcom_moodstocks_android_advanced_Image_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='ApiSearcher']/method[@name='search' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.advanced.Image']]"
		[Register ("search", "(Lcom/moodstocks/android/advanced/Image;)Lcom/moodstocks/android/Result;", "GetSearch_Lcom_moodstocks_android_advanced_Image_Handler")]
		public virtual unsafe global::Com.Moodstocks.Android.Result Search (global::Com.Moodstocks.Android.Advanced.Image p0)
		{
			if (id_search_Lcom_moodstocks_android_advanced_Image_ == IntPtr.Zero)
				id_search_Lcom_moodstocks_android_advanced_Image_ = JNIEnv.GetMethodID (class_ref, "search", "(Lcom/moodstocks/android/advanced/Image;)Lcom/moodstocks/android/Result;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Moodstocks.Android.Result __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (JNIEnv.CallObjectMethod  (Handle, id_search_Lcom_moodstocks_android_advanced_Image_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "search", "(Lcom/moodstocks/android/advanced/Image;)Lcom/moodstocks/android/Result;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
