using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace UnityGLTF.Examples
{
	public class GLTFExporterTest : MonoBehaviour {

		// Use this for initialization
		void Awake() {
			var exporter = new GLTFSceneExporter(new[] { transform });
			var appPath = Application.dataPath;
			var wwwPath = appPath.Substring(0, appPath.LastIndexOf("Assets")) + "www";
			exporter.SaveGLTFandBin(Path.Combine(wwwPath, "TestScene"), "TestScene");
		}
	}
}

