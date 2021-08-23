using System;
using System.Security;

namespace loader
{
	// Token: 0x02000002 RID: 2
	public class Helpers
	{
		// Token: 0x06000002 RID: 2
		public static extern string RandomString(int length);

		// Token: 0x06000003 RID: 3
		public static extern string SecureStringToString(SecureString value);

		// Token: 0x06000004 RID: 4
		public extern Helpers();

		// Token: 0x04000001 RID: 1
		public static readonly Random Rnd;
	}
}
