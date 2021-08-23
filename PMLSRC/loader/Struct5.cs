using System;

// Token: 0x02000032 RID: 50
internal struct Struct5
{
	// Token: 0x060000EC RID: 236 RVA: 0x0000212E File Offset: 0x0000032E
	public Struct5(int int_1)
	{
		this.int_0 = int_1;
		this.struct4_0 = new Struct4[1 << int_1];
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002EFC File Offset: 0x000010FC
	public void method_0()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
		{
			this.struct4_0[(int)num].method_0();
			num += 1U;
		}
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002F34 File Offset: 0x00001134
	public uint method_1(Class4 class4_0)
	{
		uint num = 1U;
		for (int i = this.int_0; i > 0; i--)
		{
			num = (num << 1) + this.struct4_0[(int)num].method_1(class4_0);
		}
		return num - (1U << this.int_0);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002F78 File Offset: 0x00001178
	public uint method_2(Class4 class4_0)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.int_0; i++)
		{
			uint num3 = this.struct4_0[(int)num].method_1(class4_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002FC0 File Offset: 0x000011C0
	public static uint smethod_0(Struct4[] struct4_1, uint uint_0, Class4 class4_0, int int_1)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct4_1[(int)(uint_0 + num)].method_1(class4_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0400006C RID: 108
	private readonly Struct4[] struct4_0;

	// Token: 0x0400006D RID: 109
	private readonly int int_0;
}
