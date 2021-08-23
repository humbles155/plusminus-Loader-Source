using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace loader.Properties
{
	// Token: 0x02000009 RID: 9
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x0600003B RID: 59
		internal extern Resources();

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003C RID: 60
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static extern ResourceManager ResourceManager { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003D RID: 61
		// (set) Token: 0x0600003E RID: 62
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static extern CultureInfo Culture { get; set; }

		// Token: 0x0400002E RID: 46
		private static ResourceManager resourceMan;

		// Token: 0x0400002F RID: 47
		private static CultureInfo resourceCulture;
	}
}
