using System;
using System.Runtime.InteropServices;

// Token: 0x02000039 RID: 57
public static class GClass5
{
	// Token: 0x06000112 RID: 274 RVA: 0x000031A0 File Offset: 0x000013A0
	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		int[] result;
		try
		{
			byte[] array = (IntPtr.Size == 4) ? GClass5.byte_0 : GClass5.byte_1;
			intPtr = Class38.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class38.Enum1.flag_0 | Class38.Enum1.flag_1, Class38.Enum2.flag_6);
			Marshal.Copy(array, 0, intPtr, array.Length);
			GClass5.Delegate31 @delegate = (GClass5.Delegate31)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(GClass5.Delegate31));
			GCHandle a = default(GCHandle);
			int[] array2 = new int[4];
			try
			{
				a = GCHandle.Alloc(array2, GCHandleType.Pinned);
				@delegate(int_0, array2);
			}
			finally
			{
				if (a != default(GCHandle))
				{
					a.Free();
				}
			}
			result = array2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class38.VirtualFree(intPtr, 0U, 32768U);
			}
		}
		return result;
	}

	// Token: 0x04000096 RID: 150
	private static readonly byte[] byte_0 = new byte[]
	{
		242,
		202,
		237,
		239,
		117,
		230,
		28,
		11,
		160,
		55,
		48,
		11,
		204,
		177,
		92,
		153,
		191,
		26,
		133,
		17,
		161,
		178,
		233,
		44,
		21,
		252,
		87,
		249,
		110,
		231
	};

	// Token: 0x04000097 RID: 151
	private static readonly byte[] byte_1 = new byte[]
	{
		14,
		153,
		206,
		33,
		192,
		59,
		91,
		233,
		54,
		20,
		212,
		60,
		66,
		28,
		182,
		148,
		129,
		144,
		227,
		60,
		25,
		101,
		123,
		32,
		139,
		152
	};

	// Token: 0x02000049 RID: 73
	// (Invoke) Token: 0x060001C8 RID: 456
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate31(int int_0, int[] int_1);
}
