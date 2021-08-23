using System;

// Token: 0x0200003C RID: 60
public class GClass8
{
	// Token: 0x0600011D RID: 285 RVA: 0x000021F0 File Offset: 0x000003F0
	public GClass8()
	{
		this.uint_0 = 23822096U;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00003330 File Offset: 0x00001530
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass9.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x040000A0 RID: 160
	private uint uint_0;
}
