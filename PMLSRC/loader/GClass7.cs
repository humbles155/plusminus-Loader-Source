using System;
using System.Runtime.InteropServices;

// Token: 0x0200003B RID: 59
public class GClass7
{
	// Token: 0x0600011B RID: 283 RVA: 0x00003280 File Offset: 0x00001480
	public GClass7()
	{
		if (GClass7.uint_0 == null)
		{
			GClass7.uint_0 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				GClass7.uint_0[i] = num;
			}
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000032E8 File Offset: 0x000014E8
	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)uint_1))
		{
			num = (GClass7.uint_0[(int)(((uint)Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x0400009F RID: 159
	private static uint[] uint_0;
}
