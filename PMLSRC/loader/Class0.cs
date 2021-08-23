using System;

// Token: 0x0200002D RID: 45
internal static class Class0
{
	// Token: 0x060000D4 RID: 212
	internal static extern void smethod_0(uint[] uint_0);

	// Token: 0x060000D5 RID: 213
	private static extern uint[] smethod_1(uint[] uint_0, int int_1);

	// Token: 0x060000D6 RID: 214
	internal static extern void smethod_2<T>(ref T gparam_0, ref T gparam_1);

	// Token: 0x060000D7 RID: 215
	internal static extern ulong smethod_3(uint uint_0, uint uint_1);

	// Token: 0x060000D8 RID: 216
	internal static extern uint smethod_4(ulong ulong_0);

	// Token: 0x060000D9 RID: 217
	internal static extern uint smethod_5(ulong ulong_0);

	// Token: 0x060000DA RID: 218 RVA: 0x0000267C File Offset: 0x0000087C
	private static uint smethod_6(uint uint_0, uint uint_1)
	{
		/*
An exception occurred when decompiling this method (060000DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Class0::smethod_6(System.UInt32,System.UInt32)

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

	// Token: 0x060000DB RID: 219
	internal static extern int smethod_7(int int_1, int int_2);

	// Token: 0x060000DC RID: 220
	internal static extern int smethod_8(uint uint_0);

	// Token: 0x04000040 RID: 64
	private const int int_0 = 32;
}
