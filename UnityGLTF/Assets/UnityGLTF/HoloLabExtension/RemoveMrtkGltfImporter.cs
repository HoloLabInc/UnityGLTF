using System.Collections.Generic;
using UnityEditor;

namespace UnityGLTF.HoloLabExtension
{
	[InitializeOnLoad]
	public static class RemoveMrtkGltfImporter
	{
		static readonly List<string> importerGuidList = new List<string>()
		{
			// "8f83316e73954ae4fa56b79705605b45", // GltfAssetImporter
			"75911c45f303c8f45927f5efeaa50cc4" // GlbAssetImporter
		};

		static RemoveMrtkGltfImporter()
		{
			foreach (var guid in importerGuidList)
			{
				var path = AssetDatabase.GUIDToAssetPath(guid);
				if (path != "")
				{
					AssetDatabase.DeleteAsset(path);
				}
			}
		}
	}
}
