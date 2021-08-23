using System;
using System.Runtime.InteropServices;

namespace loader
{
	// Token: 0x02000003 RID: 3
	public static class NativeInterface
	{
		// Token: 0x06000006 RID: 6
		[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
		private static extern uint LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

		// Token: 0x06000007 RID: 7
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern void Initialize();

		// Token: 0x06000008 RID: 8
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern void Inject();

		// Token: 0x06000009 RID: 9
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern void InjectGameWer(string ln);

		// Token: 0x0600000A RID: 10
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern bool Login(string username, string password);

		// Token: 0x0600000B RID: 11
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern bool Register(string username, string password, string licenseKey);

		// Token: 0x0600000C RID: 12
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern bool Renew(string username, string licenseKey);

		// Token: 0x0600000D RID: 13
		[DllImport("loader.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
		public static extern int GetStatus();

		// Token: 0x0600000E RID: 14
		public static extern void Init();

		// Token: 0x04000002 RID: 2
		private static uint loaderLib;
	}
}
