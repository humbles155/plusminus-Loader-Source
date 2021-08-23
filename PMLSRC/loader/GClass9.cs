using System;

// Token: 0x0200003D RID: 61
public class GClass9
{
	// Token: 0x0600011F RID: 287 RVA: 0x0000335C File Offset: 0x0000155C
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000337C File Offset: 0x0000157C
	public static uint smethod_1(uint uint_0, int int_1)
	{
		uint num = uint_0 >> int_1;
		uint num2 = uint_0 << 32 - int_1;
		return num | num2;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x0000339C File Offset: 0x0000159C
	public static uint smethod_2(uint uint_0)
	{
		uint num = uint_0 & 16711935U;
		uint num2 = uint_0 & 4278255360U;
		return (num >> 8 | num << 24) + (num2 << 8 | num2 >> 24);
	}

	// Token: 0x040000A1 RID: 161
	public const int int_0 = 32;
}
