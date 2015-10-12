using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moodstocks.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']"
	[global::Android.Runtime.Register ("com/moodstocks/android/Scanner", DoNotGenerateAcw=true)]
	public sealed partial class Scanner : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner.SearchOption']"
		[global::Android.Runtime.Register ("com/moodstocks/android/Scanner$SearchOption", DoNotGenerateAcw=true)]
		public sealed partial class SearchOption : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner.SearchOption']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public const int Default = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner.SearchOption']/field[@name='NOPARTIAL']"
			[Register ("NOPARTIAL")]
			public const int Nopartial = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner.SearchOption']/field[@name='SMALLTARGET']"
			[Register ("SMALLTARGET")]
			public const int Smalltarget = (int) 2;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/moodstocks/android/Scanner$SearchOption", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SearchOption); }
			}

			internal SearchOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_moodstocks_android_Scanner_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner.SearchOption']/constructor[@name='Scanner.SearchOption' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.Scanner']]"
			[Register (".ctor", "(Lcom/moodstocks/android/Scanner;)V", "")]
			public unsafe SearchOption (global::Com.Moodstocks.Android.Scanner __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (SearchOption)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
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

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='Scanner.SyncListener']"
		[Register ("com/moodstocks/android/Scanner$SyncListener", "", "Com.Moodstocks.Android.Scanner/ISyncListenerInvoker")]
		public partial interface ISyncListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='Scanner.SyncListener']/method[@name='onSyncComplete' and count(parameter)=0]"
			[Register ("onSyncComplete", "()V", "GetOnSyncCompleteHandler:Com.Moodstocks.Android.Scanner/ISyncListenerInvoker, moodstock_droid")]
			void OnSyncComplete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='Scanner.SyncListener']/method[@name='onSyncFailed' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.MoodstocksError']]"
			[Register ("onSyncFailed", "(Lcom/moodstocks/android/MoodstocksError;)V", "GetOnSyncFailed_Lcom_moodstocks_android_MoodstocksError_Handler:Com.Moodstocks.Android.Scanner/ISyncListenerInvoker, moodstock_droid")]
			void OnSyncFailed (global::Com.Moodstocks.Android.MoodstocksError p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='Scanner.SyncListener']/method[@name='onSyncProgress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onSyncProgress", "(II)V", "GetOnSyncProgress_IIHandler:Com.Moodstocks.Android.Scanner/ISyncListenerInvoker, moodstock_droid")]
			void OnSyncProgress (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/interface[@name='Scanner.SyncListener']/method[@name='onSyncStart' and count(parameter)=0]"
			[Register ("onSyncStart", "()V", "GetOnSyncStartHandler:Com.Moodstocks.Android.Scanner/ISyncListenerInvoker, moodstock_droid")]
			void OnSyncStart ();

		}

		[global::Android.Runtime.Register ("com/moodstocks/android/Scanner$SyncListener", DoNotGenerateAcw=true)]
		internal class ISyncListenerInvoker : global::Java.Lang.Object, ISyncListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/moodstocks/android/Scanner$SyncListener");
			IntPtr class_ref;

			public static ISyncListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISyncListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.moodstocks.android.Scanner.SyncListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISyncListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISyncListenerInvoker); }
			}

			static Delegate cb_onSyncComplete;
#pragma warning disable 0169
			static Delegate GetOnSyncCompleteHandler ()
			{
				if (cb_onSyncComplete == null)
					cb_onSyncComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSyncComplete);
				return cb_onSyncComplete;
			}

			static void n_OnSyncComplete (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.Scanner.ISyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Scanner.ISyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSyncComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onSyncComplete;
			public unsafe void OnSyncComplete ()
			{
				if (id_onSyncComplete == IntPtr.Zero)
					id_onSyncComplete = JNIEnv.GetMethodID (class_ref, "onSyncComplete", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onSyncComplete);
			}

			static Delegate cb_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_;
#pragma warning disable 0169
			static Delegate GetOnSyncFailed_Lcom_moodstocks_android_MoodstocksError_Handler ()
			{
				if (cb_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_ == null)
					cb_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSyncFailed_Lcom_moodstocks_android_MoodstocksError_);
				return cb_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_;
			}

			static void n_OnSyncFailed_Lcom_moodstocks_android_MoodstocksError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Moodstocks.Android.Scanner.ISyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Scanner.ISyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Moodstocks.Android.MoodstocksError p0 = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.MoodstocksError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSyncFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_;
			public unsafe void OnSyncFailed (global::Com.Moodstocks.Android.MoodstocksError p0)
			{
				if (id_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_ == IntPtr.Zero)
					id_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_ = JNIEnv.GetMethodID (class_ref, "onSyncFailed", "(Lcom/moodstocks/android/MoodstocksError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onSyncFailed_Lcom_moodstocks_android_MoodstocksError_, __args);
			}

			static Delegate cb_onSyncProgress_II;
#pragma warning disable 0169
			static Delegate GetOnSyncProgress_IIHandler ()
			{
				if (cb_onSyncProgress_II == null)
					cb_onSyncProgress_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnSyncProgress_II);
				return cb_onSyncProgress_II;
			}

			static void n_OnSyncProgress_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Moodstocks.Android.Scanner.ISyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Scanner.ISyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSyncProgress (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSyncProgress_II;
			public unsafe void OnSyncProgress (int p0, int p1)
			{
				if (id_onSyncProgress_II == IntPtr.Zero)
					id_onSyncProgress_II = JNIEnv.GetMethodID (class_ref, "onSyncProgress", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onSyncProgress_II, __args);
			}

			static Delegate cb_onSyncStart;
#pragma warning disable 0169
			static Delegate GetOnSyncStartHandler ()
			{
				if (cb_onSyncStart == null)
					cb_onSyncStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSyncStart);
				return cb_onSyncStart;
			}

			static void n_OnSyncStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Moodstocks.Android.Scanner.ISyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Scanner.ISyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSyncStart ();
			}
#pragma warning restore 0169

			IntPtr id_onSyncStart;
			public unsafe void OnSyncStart ()
			{
				if (id_onSyncStart == IntPtr.Zero)
					id_onSyncStart = JNIEnv.GetMethodID (class_ref, "onSyncStart", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onSyncStart);
			}

		}

		public partial class SyncFailedEventArgs : global::System.EventArgs {

			public SyncFailedEventArgs (global::Com.Moodstocks.Android.MoodstocksError p0)
			{
				this.p0 = p0;
			}

			global::Com.Moodstocks.Android.MoodstocksError p0;
			public global::Com.Moodstocks.Android.MoodstocksError P0 {
				get { return p0; }
			}
		}

		public partial class SyncProgressEventArgs : global::System.EventArgs {

			public SyncProgressEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/moodstocks/android/Scanner_SyncListenerImplementor")]
		internal sealed partial class ISyncListenerImplementor : global::Java.Lang.Object, ISyncListener {

			object sender;

			public ISyncListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/moodstocks/android/Scanner_SyncListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnSyncCompleteHandler;
#pragma warning restore 0649

			public void OnSyncComplete ()
			{
				var __h = OnSyncCompleteHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<SyncFailedEventArgs> OnSyncFailedHandler;
#pragma warning restore 0649

			public void OnSyncFailed (global::Com.Moodstocks.Android.MoodstocksError p0)
			{
				var __h = OnSyncFailedHandler;
				if (__h != null)
					__h (sender, new SyncFailedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<SyncProgressEventArgs> OnSyncProgressHandler;
#pragma warning restore 0649

			public void OnSyncProgress (int p0, int p1)
			{
				var __h = OnSyncProgressHandler;
				if (__h != null)
					__h (sender, new SyncProgressEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnSyncStartHandler;
#pragma warning restore 0649

			public void OnSyncStart ()
			{
				var __h = OnSyncStartHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ISyncListenerImplementor value)
			{
				return value.OnSyncCompleteHandler == null && value.OnSyncFailedHandler == null && value.OnSyncProgressHandler == null && value.OnSyncStartHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moodstocks/android/Scanner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scanner); }
		}

		internal Scanner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isCompatible;
		public static unsafe bool IsCompatible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='isCompatible' and count(parameter)=0]"
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

		static IntPtr id_isSyncing;
		public unsafe bool IsSyncing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='isSyncing' and count(parameter)=0]"
			[Register ("isSyncing", "()Z", "GetIsSyncingHandler")]
			get {
				if (id_isSyncing == IntPtr.Zero)
					id_isSyncing = JNIEnv.GetMethodID (class_ref, "isSyncing", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isSyncing);
				} finally {
				}
			}
		}

		static IntPtr id_cancelSync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='cancelSync' and count(parameter)=0]"
		[Register ("cancelSync", "()V", "")]
		public unsafe void CancelSync ()
		{
			if (id_cancelSync == IntPtr.Zero)
				id_cancelSync = JNIEnv.GetMethodID (class_ref, "cancelSync", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_cancelSync);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_count;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "")]
		public unsafe int Count ()
		{
			if (id_count == IntPtr.Zero)
				id_count = JNIEnv.GetMethodID (class_ref, "count", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_count);
			} finally {
			}
		}

		static IntPtr id_decode_Lcom_moodstocks_android_advanced_Image_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='decode' and count(parameter)=3 and parameter[1][@type='com.moodstocks.android.advanced.Image'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("decode", "(Lcom/moodstocks/android/advanced/Image;II)Lcom/moodstocks/android/Result;", "")]
		public unsafe global::Com.Moodstocks.Android.Result Decode (global::Com.Moodstocks.Android.Advanced.Image p0, int p1, int p2)
		{
			if (id_decode_Lcom_moodstocks_android_advanced_Image_II == IntPtr.Zero)
				id_decode_Lcom_moodstocks_android_advanced_Image_II = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/moodstocks/android/advanced/Image;II)Lcom/moodstocks/android/Result;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Moodstocks.Android.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (JNIEnv.CallObjectMethod  (Handle, id_decode_Lcom_moodstocks_android_advanced_Image_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/moodstocks/android/Scanner;", "")]
		public static unsafe global::Com.Moodstocks.Android.Scanner Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/moodstocks/android/Scanner;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Scanner> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_importBundle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='importBundle' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("importBundle", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ImportBundle (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_importBundle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_importBundle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importBundle", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod  (Handle, id_importBundle_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_info;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='info' and count(parameter)=0]"
		[Register ("info", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<byte[]> Info ()
		{
			if (id_info == IntPtr.Zero)
				id_info = JNIEnv.GetMethodID (class_ref, "info", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_info), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_match_Lcom_moodstocks_android_advanced_Image_Lcom_moodstocks_android_Result_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='match' and count(parameter)=4 and parameter[1][@type='com.moodstocks.android.advanced.Image'] and parameter[2][@type='com.moodstocks.android.Result'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("match", "(Lcom/moodstocks/android/advanced/Image;Lcom/moodstocks/android/Result;II)Lcom/moodstocks/android/Result;", "")]
		public unsafe global::Com.Moodstocks.Android.Result Match (global::Com.Moodstocks.Android.Advanced.Image p0, global::Com.Moodstocks.Android.Result p1, int p2, int p3)
		{
			if (id_match_Lcom_moodstocks_android_advanced_Image_Lcom_moodstocks_android_Result_II == IntPtr.Zero)
				id_match_Lcom_moodstocks_android_advanced_Image_Lcom_moodstocks_android_Result_II = JNIEnv.GetMethodID (class_ref, "match", "(Lcom/moodstocks/android/advanced/Image;Lcom/moodstocks/android/Result;II)Lcom/moodstocks/android/Result;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Moodstocks.Android.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (JNIEnv.CallObjectMethod  (Handle, id_match_Lcom_moodstocks_android_advanced_Image_Lcom_moodstocks_android_Result_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_open_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='open' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void Open (string p0, string p1, string p2)
		{
			if (id_open_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_open_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod  (Handle, id_open_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_pathFromFilesDir_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='pathFromFilesDir' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("pathFromFilesDir", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PathFromFilesDir (global::Android.Content.Context p0, string p1)
		{
			if (id_pathFromFilesDir_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_pathFromFilesDir_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "pathFromFilesDir", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_pathFromFilesDir_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_search_Lcom_moodstocks_android_advanced_Image_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='search' and count(parameter)=3 and parameter[1][@type='com.moodstocks.android.advanced.Image'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("search", "(Lcom/moodstocks/android/advanced/Image;II)Lcom/moodstocks/android/Result;", "")]
		public unsafe global::Com.Moodstocks.Android.Result Search (global::Com.Moodstocks.Android.Advanced.Image p0, int p1, int p2)
		{
			if (id_search_Lcom_moodstocks_android_advanced_Image_II == IntPtr.Zero)
				id_search_Lcom_moodstocks_android_advanced_Image_II = JNIEnv.GetMethodID (class_ref, "search", "(Lcom/moodstocks/android/advanced/Image;II)Lcom/moodstocks/android/Result;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Moodstocks.Android.Result __ret = global::Java.Lang.Object.GetObject<global::Com.Moodstocks.Android.Result> (JNIEnv.CallObjectMethod  (Handle, id_search_Lcom_moodstocks_android_advanced_Image_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setAuthenticatedProxy_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='setAuthenticatedProxy' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setAuthenticatedProxy", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetAuthenticatedProxy (string p0, int p1, string p2, string p3)
		{
			if (id_setAuthenticatedProxy_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAuthenticatedProxy_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthenticatedProxy", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod  (Handle, id_setAuthenticatedProxy_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_setProxy_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='setProxy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setProxy", "(Ljava/lang/String;I)V", "")]
		public unsafe void SetProxy (string p0, int p1)
		{
			if (id_setProxy_Ljava_lang_String_I == IntPtr.Zero)
				id_setProxy_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setProxy", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setProxy_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setSyncListener_Lcom_moodstocks_android_Scanner_SyncListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='setSyncListener' and count(parameter)=1 and parameter[1][@type='com.moodstocks.android.Scanner.SyncListener']]"
		[Register ("setSyncListener", "(Lcom/moodstocks/android/Scanner$SyncListener;)V", "")]
		public unsafe void SetSyncListener (global::Com.Moodstocks.Android.Scanner.ISyncListener p0)
		{
			if (id_setSyncListener_Lcom_moodstocks_android_Scanner_SyncListener_ == IntPtr.Zero)
				id_setSyncListener_Lcom_moodstocks_android_Scanner_SyncListener_ = JNIEnv.GetMethodID (class_ref, "setSyncListener", "(Lcom/moodstocks/android/Scanner$SyncListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setSyncListener_Lcom_moodstocks_android_Scanner_SyncListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setSyncProxy_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='setSyncProxy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSyncProxy", "(Ljava/lang/String;)V", "")]
		public unsafe void SetSyncProxy (string p0)
		{
			if (id_setSyncProxy_Ljava_lang_String_ == IntPtr.Zero)
				id_setSyncProxy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSyncProxy", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setSyncProxy_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moodstocks.android']/class[@name='Scanner']/method[@name='sync' and count(parameter)=0]"
		[Register ("sync", "()Z", "")]
		public unsafe bool Sync ()
		{
			if (id_sync == IntPtr.Zero)
				id_sync = JNIEnv.GetMethodID (class_ref, "sync", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_sync);
			} finally {
			}
		}

#region "Event implementation for Com.Moodstocks.Android.Scanner.ISyncListener"
		public event EventHandler SyncComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						__CreateISyncListenerImplementor,
						SetSyncListener,
						__h => __h.OnSyncCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor.__IsEmpty,
						__v => SetSyncListener (null),
						__h => __h.OnSyncCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Com.Moodstocks.Android.Scanner.SyncFailedEventArgs> SyncFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						__CreateISyncListenerImplementor,
						SetSyncListener,
						__h => __h.OnSyncFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor.__IsEmpty,
						__v => SetSyncListener (null),
						__h => __h.OnSyncFailedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Moodstocks.Android.Scanner.SyncProgressEventArgs> SyncProgress {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						__CreateISyncListenerImplementor,
						SetSyncListener,
						__h => __h.OnSyncProgressHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor.__IsEmpty,
						__v => SetSyncListener (null),
						__h => __h.OnSyncProgressHandler -= value);
			}
		}

		public event EventHandler SyncStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						__CreateISyncListenerImplementor,
						SetSyncListener,
						__h => __h.OnSyncStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Moodstocks.Android.Scanner.ISyncListener, global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor>(
						ref weak_implementor_SetSyncListener,
						global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor.__IsEmpty,
						__v => SetSyncListener (null),
						__h => __h.OnSyncStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetSyncListener;

		global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor __CreateISyncListenerImplementor ()
		{
			return new global::Com.Moodstocks.Android.Scanner.ISyncListenerImplementor (this);
		}
#endregion
	}
}
