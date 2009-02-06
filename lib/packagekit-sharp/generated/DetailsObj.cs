// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace PackageKit {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class DetailsObj : GLib.Opaque {

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_details_obj_copy(IntPtr raw);

		public PackageKit.DetailsObj Copy() {
			IntPtr raw_ret = pk_details_obj_copy(Handle);
			PackageKit.DetailsObj ret = raw_ret == IntPtr.Zero ? null : (PackageKit.DetailsObj) GLib.Opaque.GetOpaque (raw_ret, typeof (PackageKit.DetailsObj), true);
			return ret;
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern bool pk_details_obj_free(IntPtr raw);

		public bool Free() {
			bool raw_ret = pk_details_obj_free(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public DetailsObj(IntPtr raw) : base(raw) {}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_details_obj_new();

		public DetailsObj ()
		{
			Raw = pk_details_obj_new();
		}

		[DllImport("libpackagekit-glib.dll")]
		static extern IntPtr pk_details_obj_new_from_data(IntPtr id, IntPtr license, int group, IntPtr description, IntPtr url, ulong size);

		public DetailsObj (PackageKit.PackageId id, string license, PackageKit.GroupEnum group, string description, string url, ulong size)
		{
			IntPtr native_license = GLib.Marshaller.StringToPtrGStrdup (license);
			IntPtr native_description = GLib.Marshaller.StringToPtrGStrdup (description);
			IntPtr native_url = GLib.Marshaller.StringToPtrGStrdup (url);
			Raw = pk_details_obj_new_from_data(id == null ? IntPtr.Zero : id.Handle, native_license, (int) group, native_description, native_url, size);
			GLib.Marshaller.Free (native_license);
			GLib.Marshaller.Free (native_description);
			GLib.Marshaller.Free (native_url);
		}

#endregion
	}
}
