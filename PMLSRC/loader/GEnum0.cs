using System;

// Token: 0x02000034 RID: 52
[Flags]
public enum GEnum0
{
	// Token: 0x04000076 RID: 118
	Success = 0,
	// Token: 0x04000077 RID: 119
	Corrupted = 1,
	// Token: 0x04000078 RID: 120
	Invalid = 2,
	// Token: 0x04000079 RID: 121
	Blacklisted = 4,
	// Token: 0x0400007A RID: 122
	DateExpired = 8,
	// Token: 0x0400007B RID: 123
	RunningTimeOver = 16,
	// Token: 0x0400007C RID: 124
	BadHwid = 32,
	// Token: 0x0400007D RID: 125
	MaxBuildExpired = 64
}
