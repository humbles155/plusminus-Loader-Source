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
	// Token: 0x02000005 RID: 5
	public class RegisterWindow : Window, IComponentConnector
	{
		// Token: 0x06000019 RID: 25
		public extern RegisterWindow();

		// Token: 0x0600001A RID: 26
		private extern void RegisterButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x0600001B RID: 27
		private extern void LoginButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x0600001C RID: 28
		private extern void MiniButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x0600001D RID: 29
		private extern void CloseButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x0600001E RID: 30
		private extern void Window_Loaded(object sender, RoutedEventArgs e);

		// Token: 0x0600001F RID: 31
		private extern void Window_MouseDown(object sender, MouseButtonEventArgs e);

		// Token: 0x06000020 RID: 32
		private extern void RenewButton_Click(object sender, RoutedEventArgs e);

		// Token: 0x06000021 RID: 33
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public extern void InitializeComponent();

		// Token: 0x06000022 RID: 34
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target);

		// Token: 0x0400000E RID: 14
		internal ScaleTransform ScaleTransform;

		// Token: 0x0400000F RID: 15
		internal Grid TopBox;

		// Token: 0x04000010 RID: 16
		internal Label TitleBox;

		// Token: 0x04000011 RID: 17
		internal Button CloseButton;

		// Token: 0x04000012 RID: 18
		internal Button MiniButton;

		// Token: 0x04000013 RID: 19
		internal TextBox UsernameBox;

		// Token: 0x04000014 RID: 20
		internal PasswordBox PasswordBox;

		// Token: 0x04000015 RID: 21
		internal TextBox SerialBox;

		// Token: 0x04000016 RID: 22
		internal Button RegisterButton;

		// Token: 0x04000017 RID: 23
		internal Button LoginButton;

		// Token: 0x04000018 RID: 24
		internal Button RenewButton;

		// Token: 0x04000019 RID: 25
		private bool _contentLoaded;
	}
}
