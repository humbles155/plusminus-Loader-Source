using System;
using System.Runtime.InteropServices;

// Token: 0x0200003A RID: 58
public class GClass6
{
	// Token: 0x06000114 RID: 276
	public extern GClass6(byte[] byte_0);

	// Token: 0x06000115 RID: 277
	private extern void method_0(ref GClass6.Struct6 struct6_0);

	// Token: 0x06000116 RID: 278
	private extern void method_1(ref GClass6.Struct6 struct6_0);

	// Token: 0x06000117 RID: 279
	public extern byte[] method_2(byte[] byte_0);

	// Token: 0x06000118 RID: 280
	public extern byte[] method_3(byte[] byte_0);

	// Token: 0x06000119 RID: 281
	public extern void method_4(byte[] byte_0, byte[] byte_1);

	// Token: 0x0600011A RID: 282 RVA: 0x000021E9 File Offset: 0x000003E9
	public void method_5(byte[] byte_0, byte[] byte_1)
	{
		/*
An exception occurred when decompiling this method (0600011A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GClass6::method_5(System.Byte[],System.Byte[])

 ---> System.OverflowException: Arithmetic operation resulted in an overflow.
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 47
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 387
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x04000098 RID: 152
	private const int int_0 = 15;

	// Token: 0x04000099 RID: 153
	private const int int_1 = 8;

	// Token: 0x0400009A RID: 154
	private const int int_2 = 2;

	// Token: 0x0400009B RID: 155
	private const int int_3 = 32;

	// Token: 0x0400009C RID: 156
	private readonly uint[] uint_0;

	// Token: 0x0400009D RID: 157
	private const uint uint_1 = 4207804417U;

	// Token: 0x0400009E RID: 158
	private const uint uint_2 = 4207804418U;

	// Token: 0x0200004A RID: 74
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct6
	{
		// Token: 0x040000DA RID: 218
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x040000DB RID: 219
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040000DC RID: 220
		[FieldOffset(4)]
		public uint uint_1;
	}
}
