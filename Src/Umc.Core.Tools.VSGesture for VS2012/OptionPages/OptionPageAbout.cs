﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Shell;

namespace Umc.Core.Tools.VSGesture.OptionPages
{
	public class OptionPageAbout : DialogPage
	{
		private OptionPageAboutControl control;

		public OptionPageAbout()
		{
			this.control = new OptionPageAboutControl();
		}

		protected override System.Windows.Forms.IWin32Window Window
		{
			get
			{
				return control;
			}
		}

		protected override void OnApply(PageApplyEventArgs e)
		{
			base.OnApply(e);
		}

		protected override void OnActivate(System.ComponentModel.CancelEventArgs e)
		{
			base.OnActivate(e);
		}
	}
}
