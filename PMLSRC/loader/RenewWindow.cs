using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace loader
{
	// Token: 0x02000004 RID: 4
	public class RenewWindow : Window, IComponentConnector
	{
		// Token: 0x0600000F RID: 15
		public extern RenewWindow();

		// Token: 0x06000010 RID: 16
		private extern void RegisterButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x06000011 RID: 17
		private extern void LoginButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x06000012 RID: 18
		private extern void MiniButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x06000013 RID: 19
		private extern void CloseButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x06000014 RID: 20
		private extern void Window_Loaded(object sender, RoutedEventArgs e);

		// Token: 0x06000015 RID: 21
		private extern void Window_MouseDown(object sender, MouseButtonEventArgs e);

		// Token: 0x06000016 RID: 22
		private extern void RenewButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x06000017 RID: 23
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public extern void InitializeComponent();

		// Token: 0x06000018 RID: 24
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target);

		// Token: 0x04000003 RID: 3
		internal ScaleTransform ScaleTransform;

		// Token: 0x04000004 RID: 4
		internal Grid TopBox;

		// Token: 0x04000005 RID: 5
		internal Label TitleBox;

		// Token: 0x04000006 RID: 6
		internal Button CloseButton;

		// Token: 0x04000007 RID: 7
		internal Button MiniButton;

		// Token: 0x04000008 RID: 8
		internal TextBox UsernameBox;

		// Token: 0x04000009 RID: 9
		internal TextBox SerialBox;

		// Token: 0x0400000A RID: 10
		internal Button RenewButton;

		// Token: 0x0400000B RID: 11
		internal Button RegisterButton;

		// Token: 0x0400000C RID: 12
		internal Button LoginButton;

		// Token: 0x0400000D RID: 13
		private bool _contentLoaded;
	}
}
