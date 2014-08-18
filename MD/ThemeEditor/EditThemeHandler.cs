using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Core.Setup;

namespace XSThemeEditor
{
	class EditThemeHandler : CommandHandler
	{
		protected override void Run()
		{
		// Amazingly, this line below is all that's needed to set the GTK engine theme. Now,
		// how do I update the engine?
			Gtk.Settings.Default.ThemeName = "Clearlooks";
			//MonoDevelop.Components.Theming.ThemeEngine.SetCurrentTheme<Theme> ();
			MonoDevelop
		}
		
		protected override void Update(CommandInfo info)
		{
		}
	}
}

