// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace PackageKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Global {

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_strv_to_ptr_array(IntPtr array);

		public static GLib.PtrArray StrvToPtrArray(string array) {
			IntPtr raw_ret = pk_strv_to_ptr_array(GLib.Marshaller.StringToPtrGStrdup(array));
			GLib.PtrArray ret = new GLib.PtrArray(raw_ret);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_va_list_to_argv(IntPtr string_first, IntPtr args);

		public static string VaListToArgv(string string_first, IntPtr args) {
			IntPtr native_string_first = GLib.Marshaller.StringToPtrGStrdup (string_first);
			IntPtr raw_ret = pk_va_list_to_argv(native_string_first, args);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_string_first);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_ptr_array_to_strv(IntPtr array);

		public static string PtrArrayToStrv(GLib.PtrArray array) {
			IntPtr raw_ret = pk_ptr_array_to_strv(array == null ? IntPtr.Zero : array.Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_get_distro_id();

		public static string DistroId {
			get {
				IntPtr raw_ret = pk_get_distro_id();
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
