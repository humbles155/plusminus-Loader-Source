using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000044 RID: 68
internal static class Class38
{
	// Token: 0x060001A5 RID: 421
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	// Token: 0x060001A6 RID: 422
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Class38.Enum2 enum2_0, int int_5, int int_6, string string_0);

	// Token: 0x060001A7 RID: 423
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool FlushViewOfFile(IntPtr intptr_3, int int_5);

	// Token: 0x060001A8 RID: 424
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Class38.Enum3 enum3_0, int int_5, int int_6, IntPtr intptr_4);

	// Token: 0x060001A9 RID: 425
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenFileMapping(int int_5, bool bool_0, string string_0);

	// Token: 0x060001AA RID: 426
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	// Token: 0x060001AB RID: 427
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	// Token: 0x060001AC RID: 428
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x060001AD RID: 429
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr intptr_3, UIntPtr uintptr_0, Class38.Enum1 enum1_0, Class38.Enum2 enum2_0);

	// Token: 0x060001AE RID: 430
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualFree(IntPtr intptr_3, uint uint_0, uint uint_1);

	// Token: 0x060001AF RID: 431
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Class38.Enum2 enum2_0, out Class38.Enum2 enum2_1);

	// Token: 0x060001B0 RID: 432
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	// Token: 0x060001B1 RID: 433
	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	// Token: 0x060001B2 RID: 434
	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	// Token: 0x060001B3 RID: 435
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint EnumSystemFirmwareTables(uint uint_0, IntPtr intptr_3, uint uint_1);

	// Token: 0x060001B4 RID: 436
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetSystemFirmwareTable(uint uint_0, uint uint_1, IntPtr intptr_3, uint uint_2);

	// Token: 0x060001B5 RID: 437
	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, IntPtr intptr_4, uint uint_0, out uint uint_1);

	// Token: 0x040000C4 RID: 196
	public const int int_0 = -2147483648;

	// Token: 0x040000C5 RID: 197
	public const int int_1 = 3;

	// Token: 0x040000C6 RID: 198
	public const int int_2 = 128;

	// Token: 0x040000C7 RID: 199
	public const int int_3 = 1;

	// Token: 0x040000C8 RID: 200
	public const int int_4 = 2;

	// Token: 0x040000C9 RID: 201
	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x040000CA RID: 202
	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x040000CB RID: 203
	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	// Token: 0x02000070 RID: 112
	[Flags]
	public enum Enum1 : uint
	{
		// Token: 0x0400010F RID: 271
		flag_0 = 4096U,
		// Token: 0x04000110 RID: 272
		flag_1 = 8192U
	}

	// Token: 0x02000071 RID: 113
	[Flags]
	public enum Enum2 : uint
	{
		// Token: 0x04000112 RID: 274
		flag_0 = 1U,
		// Token: 0x04000113 RID: 275
		flag_1 = 2U,
		// Token: 0x04000114 RID: 276
		flag_2 = 4U,
		// Token: 0x04000115 RID: 277
		flag_3 = 8U,
		// Token: 0x04000116 RID: 278
		flag_4 = 16U,
		// Token: 0x04000117 RID: 279
		flag_5 = 32U,
		// Token: 0x04000118 RID: 280
		flag_6 = 64U,
		// Token: 0x04000119 RID: 281
		flag_7 = 256U
	}

	// Token: 0x02000072 RID: 114
	[Flags]
	public enum Enum3 : uint
	{
		// Token: 0x0400011B RID: 283
		flag_0 = 1U,
		// Token: 0x0400011C RID: 284
		flag_1 = 2U,
		// Token: 0x0400011D RID: 285
		flag_2 = 4U,
		// Token: 0x0400011E RID: 286
		flag_3 = 31U
	}

	// Token: 0x02000073 RID: 115
	[Flags]
	public enum Enum4 : uint
	{
		// Token: 0x04000120 RID: 288
		flag_0 = 536870912U,
		// Token: 0x04000121 RID: 289
		flag_1 = 1073741824U,
		// Token: 0x04000122 RID: 290
		flag_2 = 2147483648U
	}
}
