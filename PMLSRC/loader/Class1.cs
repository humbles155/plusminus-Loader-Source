using System;

// Token: 0x0200002E RID: 46
internal abstract class Class1
{
	// Token: 0x060000DD RID: 221 RVA: 0x000020C6 File Offset: 0x000002C6
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x04000041 RID: 65
	public const uint uint_0 = 12U;

	// Token: 0x04000042 RID: 66
	public const int int_0 = 6;

	// Token: 0x04000043 RID: 67
	private const int int_1 = 2;

	// Token: 0x04000044 RID: 68
	public const uint uint_1 = 4U;

	// Token: 0x04000045 RID: 69
	public const uint uint_2 = 2U;

	// Token: 0x04000046 RID: 70
	public const int int_2 = 4;

	// Token: 0x04000047 RID: 71
	public const uint uint_3 = 4U;

	// Token: 0x04000048 RID: 72
	public const uint uint_4 = 14U;

	// Token: 0x04000049 RID: 73
	public const uint uint_5 = 128U;

	// Token: 0x0400004A RID: 74
	public const int int_3 = 4;

	// Token: 0x0400004B RID: 75
	public const uint uint_6 = 16U;

	// Token: 0x0400004C RID: 76
	public const int int_4 = 3;

	// Token: 0x0400004D RID: 77
	public const int int_5 = 3;

	// Token: 0x0400004E RID: 78
	public const int int_6 = 8;

	// Token: 0x0400004F RID: 79
	public const uint uint_7 = 8U;

	// Token: 0x04000050 RID: 80
	public const uint uint_8 = 8U;

	// Token: 0x02000046 RID: 70
	public struct Struct2
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000022F0 File Offset: 0x000004F0
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000022F9 File Offset: 0x000004F9
		public void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002333 File Offset: 0x00000533
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002349 File Offset: 0x00000549
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000235F File Offset: 0x0000055F
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002376 File Offset: 0x00000576
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x040000CE RID: 206
		public uint uint_0;
	}
}
