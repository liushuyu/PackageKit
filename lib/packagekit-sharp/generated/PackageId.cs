// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace PackageKit {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class PackageId : GLib.Opaque {

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_package_id_build(IntPtr name, IntPtr version, IntPtr arch, IntPtr data);

		public static string Build(string name, string version, string arch, string data) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_version = GLib.Marshaller.StringToPtrGStrdup (version);
			IntPtr native_arch = GLib.Marshaller.StringToPtrGStrdup (arch);
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup (data);
			IntPtr raw_ret = pk_package_id_build(native_name, native_version, native_arch, native_data);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_version);
			GLib.Marshaller.Free (native_arch);
			GLib.Marshaller.Free (native_data);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_package_id_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = pk_package_id_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern bool pk_package_id_equal_fuzzy_arch(IntPtr raw, IntPtr id2);

		public bool EqualFuzzyArch(PackageKit.PackageId id2) {
			bool raw_ret = pk_package_id_equal_fuzzy_arch(Handle, id2 == null ? IntPtr.Zero : id2.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern bool pk_package_id_equal_strings(IntPtr pid1, IntPtr pid2);

		public static bool EqualStrings(string pid1, string pid2) {
			IntPtr native_pid1 = GLib.Marshaller.StringToPtrGStrdup (pid1);
			IntPtr native_pid2 = GLib.Marshaller.StringToPtrGStrdup (pid2);
			bool raw_ret = pk_package_id_equal_strings(native_pid1, native_pid2);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_pid1);
			GLib.Marshaller.Free (native_pid2);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern bool pk_package_id_free(IntPtr raw);

		public bool Free() {
			bool raw_ret = pk_package_id_free(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern bool pk_package_id_check(IntPtr package_id);

		public static bool Check(string package_id) {
			IntPtr native_package_id = GLib.Marshaller.StringToPtrGStrdup (package_id);
			bool raw_ret = pk_package_id_check(native_package_id);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_package_id);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern bool pk_package_id_equal(IntPtr raw, IntPtr id2);

		public bool Equal(PackageKit.PackageId id2) {
			bool raw_ret = pk_package_id_equal(Handle, id2 == null ? IntPtr.Zero : id2.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_package_id_copy(IntPtr raw);

		public PackageKit.PackageId Copy() {
			IntPtr raw_ret = pk_package_id_copy(Handle);
			PackageKit.PackageId ret = raw_ret == IntPtr.Zero ? null : (PackageKit.PackageId) GLib.Opaque.GetOpaque (raw_ret, typeof (PackageKit.PackageId), true);
			return ret;
		}

		public PackageId(IntPtr raw) : base(raw) {}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_package_id_new();

		public PackageId ()
		{
			Raw = pk_package_id_new();
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_package_id_new_from_list(IntPtr name, IntPtr version, IntPtr arch, IntPtr data);

		public PackageId (string name, string version, string arch, string data)
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_version = GLib.Marshaller.StringToPtrGStrdup (version);
			IntPtr native_arch = GLib.Marshaller.StringToPtrGStrdup (arch);
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup (data);
			Raw = pk_package_id_new_from_list(native_name, native_version, native_arch, native_data);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_version);
			GLib.Marshaller.Free (native_arch);
			GLib.Marshaller.Free (native_data);
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_package_id_new_from_string(IntPtr package_id);

		public PackageId (string package_id)
		{
			IntPtr native_package_id = GLib.Marshaller.StringToPtrGStrdup (package_id);
			Raw = pk_package_id_new_from_string(native_package_id);
			GLib.Marshaller.Free (native_package_id);
		}

#endregion
	}
}
