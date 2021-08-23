using System;
using System.IO;

// Token: 0x02000030 RID: 48
internal class Class4
{
	// Token: 0x060000E6 RID: 230 RVA: 0x00002D50 File Offset: 0x00000F50
	public void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.uint_3 = 0U;
		this.uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.uint_3 = (this.uint_3 << 8 | (uint)((byte)this.stream_0.ReadByte()));
		}
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00002109 File Offset: 0x00000309
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00002D9C File Offset: 0x00000F9C
	public uint method_2(int int_0)
	{
		uint num = this.uint_2;
		uint num2 = this.uint_3;
		uint num3 = 0U;
		for (int i = int_0; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				num <<= 8;
			}
		}
		this.uint_2 = num;
		this.uint_3 = num2;
		return num3;
	}

	// Token: 0x04000063 RID: 99
	private uint uint_0 = 1U;

	// Token: 0x04000064 RID: 100
	public const uint uint_1 = 16777216U;

	// Token: 0x04000065 RID: 101
	public uint uint_2;

	// Token: 0x04000066 RID: 102
	public uint uint_3;

	// Token: 0x04000067 RID: 103
	public Stream stream_0;
}
