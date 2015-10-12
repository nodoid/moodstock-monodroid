using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android.Advanced {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer']"
	[global::Android.Runtime.Register ("com/moodstocks/android/advanced/Synchronizer", DoNotGenerateAcw=true)]
	public partial class Synchronizer : global::Android.OS.Handler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer.Msg']"
		[global::Android.Runtime.Register ("com/moodstocks/android/advanced/Synchronizer$Msg", DoNotGenerateAcw=true)]
		public sealed partial class Msg : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer.Msg']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public const int Complete = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer.Msg']/field[@name='ERROR']"
			[Register ("ERROR")]
			public const int Error = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer.Msg']/field[@name='PROGRESS']"
			[Register ("PROGRESS")]
			public const int Progress = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer.Msg']/field[@name='START']"
			[Register ("START")]
			public const int Start = (int) 0;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/advanced/Synchronizer$Msg", ref java_class_handle);
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/advanced/Synchronizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Synchronizer); }
		}

		protected Synchronizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_moodstocks_android_Scanner_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer']/constructor[@name='Synchronizer' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.Scanner']]"
		[Register (".ctor", "(Lcom/moodstocks/android/Scanner;)V", "")]
		public unsafe Synchronizer (global::Com.Moodstocks.Android.Scanner p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Synchronizer)) {
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
			global::Com.Moodstocks.Android.Advanced.Synchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Synchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer']/method[@name='cancel' and count(parameter)=0]"
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

		static Delegate cb_setListener_Lcom_moodstocks_android_Scanner_SyncListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_moodstocks_android_Scanner_SyncListener_Handler ()
		{
			if (cb_setListener_Lcom_moodstocks_android_Scanner_SyncListener_ == null)
				cb_setListener_Lcom_moodstocks_android_Scanner_SyncListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_moodstocks_android_Scanner_SyncListener_);
			return cb_setListener_Lcom_moodstocks_android_Scanner_SyncListener_;
		}

		static void n_SetListener_Lcom_moodstocks_android_Scanner_SyncListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moodstocks.Android.Advanced.Synchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Synchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Moodstocks.Android.Scanner.ISyncListener p0 = (global::Com.Moodstocks.Android.Scanner.ISyncListener)global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Scanner.ISyncListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_moodstocks_android_Scanner_SyncListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.Scanner.SyncListener']]"
		[Register ("setListener", "(Lcom/moodstocks/android/Scanner$SyncListener;)V", "GetSetListener_Lcom_moodstocks_android_Scanner_SyncListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Moodstocks.Android.Scanner.ISyncListener p0)
		{
			if (id_setListener_Lcom_moodstocks_android_Scanner_SyncListener_ == IntPtr.Zero)
				id_setListener_Lcom_moodstocks_android_Scanner_SyncListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/moodstocks/android/Scanner$SyncListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_moodstocks_android_Scanner_SyncListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/moodstocks/android/Scanner$SyncListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_synchronize;
#pragma warning disable 0169
		static Delegate GetSynchronizeHandler ()
		{
			if (cb_synchronize == null)
				cb_synchronize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Synchronize);
			return cb_synchronize;
		}

		static void n_Synchronize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moodstocks.Android.Advanced.Synchronizer __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Advanced.Synchronizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Synchronize ();
		}
#pragma warning restore 0169

		static IntPtr id_synchronize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android.advanced']/class[@name='Synchronizer']/method[@name='synchronize' and count(parameter)=0]"
		[Register ("synchronize", "()V", "GetSynchronizeHandler")]
		public virtual unsafe void Synchronize ()
		{
			if (id_synchronize == IntPtr.Zero)
				id_synchronize = JNIEnv.GetMethodID (class_ref, "synchronize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_synchronize);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "synchronize", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Moodstocks.Android.Scanner.ISyncListener"

		global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor __CreateISyncListenerImplementor ()
		{
			return new global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor (this);
		}
#endregion
	}
}
