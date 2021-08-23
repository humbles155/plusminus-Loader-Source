using System;
using System.IO;

// Token: 0x02000033 RID: 51
public class GClass1
{
	// Token: 0x060000F1 RID: 241 RVA: 0x00002148 File Offset: 0x00000348
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00002174 File Offset: 0x00000374
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000219B File Offset: 0x0000039B
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00003000 File Offset: 0x00001200
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00003058 File Offset: 0x00001258
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x000030D0 File Offset: 0x000012D0
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x0000310C File Offset: 0x0000130C
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x0400006E RID: 110
	private byte[] byte_0;

	// Token: 0x0400006F RID: 111
	private uint uint_0;

	// Token: 0x04000070 RID: 112
	private uint uint_1;

	// Token: 0x04000071 RID: 113
	private uint uint_2;

	// Token: 0x04000072 RID: 114
	private Stream stream_0;

	// Token: 0x04000073 RID: 115
	private uint uint_3 = 1U;

	// Token: 0x04000074 RID: 116
	public uint uint_4;
}
