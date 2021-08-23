using System;

// Token: 0x02000031 RID: 49
internal struct Struct4
{
	// Token: 0x060000EA RID: 234 RVA: 0x00002121 File Offset: 0x00000321
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002E10 File Offset: 0x00001010
	public uint method_1(Class4 class4_0)
	{
		uint num = (class4_0.uint_2 >> 11) * this.uint_1;
		if (class4_0.uint_3 < num)
		{
			class4_0.uint_2 = num;
			this.uint_1 += 2048U - this.uint_1 >> 5;
			if (class4_0.uint_2 < 16777216U)
			{
				class4_0.uint_3 = (class4_0.uint_3 << 8 | (uint)((byte)class4_0.stream_0.ReadByte()));
				class4_0.uint_2 <<= 8;
			}
			return 0U;
		}
		class4_0.uint_2 -= num;
		class4_0.uint_3 -= num;
		this.uint_1 -= this.uint_1 >> 5;
		if (class4_0.uint_2 < 16777216U)
		{
			class4_0.uint_3 = (class4_0.uint_3 << 8 | (uint)((byte)class4_0.stream_0.ReadByte()));
			class4_0.uint_2 <<= 8;
		}
		return 1U;
	}

	// Token: 0x04000068 RID: 104
	private const int int_0 = 11;

	// Token: 0x04000069 RID: 105
	private const uint uint_0 = 2048U;

	// Token: 0x0400006A RID: 106
	private const int int_1 = 5;

	// Token: 0x0400006B RID: 107
	private uint uint_1;
}
