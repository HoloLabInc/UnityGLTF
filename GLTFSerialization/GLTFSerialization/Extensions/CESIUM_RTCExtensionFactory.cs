using Newtonsoft.Json.Linq;
using GLTF.Extensions;
using GLTF.Math;

namespace GLTF.Schema
{
	public class CESIUM_RTCExtensionFactory : ExtensionFactory
	{
		public const string EXTENSION_NAME = "CESIUM_RTC";
		public const string CENTER = "center";

		public CESIUM_RTCExtensionFactory()
		{
			ExtensionName = EXTENSION_NAME;
		}

		public override IExtension Deserialize(GLTFRoot root, JProperty extensionToken)
		{
			Vector3Double center = new Vector3Double(CESIUM_RTCExtension.CENTER_DEFAULT);

			if (extensionToken != null)
			{
				JToken offsetToken = extensionToken.Value[CENTER];
				center = offsetToken != null ? offsetToken.DeserializeAsVector3Double() : center;
			}

			return new CESIUM_RTCExtension(center);
		}
	}
}
