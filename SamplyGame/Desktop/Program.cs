using System;
using System.IO;
using Urho;
using Urho.Desktop;

namespace SamplyGame.Desktop
{
	class Program
	{
		static void Main(string[] _)
		{
			var assetsPath = Path.GetFullPath(@"../../Assets");
			DesktopUrhoInitializer.AssetsDirectory = assetsPath;

			var dataPath = Path.Combine(assetsPath, "Data");
			var options = new ApplicationOptions(assetsFolder: dataPath)
			{
				Height = 1024,
				Width = 576,
				Orientation = ApplicationOptions.OrientationType.Portrait
			};

			var result = new SamplyGame(options).Run();
			Console.WriteLine($"Exit with status {result}");
			Console.ReadLine();
		}
	}
}
