using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MyMVC4.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-1.9.1.js",
				"~/Scripts/bootstrap.min.js"));
			bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
				"~/Content/bootstrap-theme.css",
				"~/Content/bootstrap.css"));
		}
	}
}