﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace T0Updater
{
	static class Program
	{
		public static string oldfile, version, curv;
		public static bool forceDownload;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 1)
			{
				oldfile = args[0];
				version = args[1];
				curv = args[2];

				if (args.Length > 3)
					forceDownload = bool.Parse(args[3]);
				else
					forceDownload = false;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Downloader());
		}
	}
}