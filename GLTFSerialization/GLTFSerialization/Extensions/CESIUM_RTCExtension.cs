﻿using System;
using GLTF.Math;
using GLTF.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GLTF.Schema
{
	public class CESIUM_RTCExtension : IExtension
	{
		public Vector3Double Center = new Vector3Double(0, 0, 0);

		public static readonly Vector3Double CENTER_DEFAULT = new Vector3Double(0, 0, 0);

		public CESIUM_RTCExtension(Vector3Double center)
		{
			Center = center;
		}

		public IExtension Clone(GLTFRoot root)
		{
			return new CESIUM_RTCExtension(Center);
		}

		public JProperty Serialize()
		{
			JObject ext = new JObject();

			if (Center != CENTER_DEFAULT)
			{
				ext.Add(new JProperty(
					CESIUM_RTCExtensionFactory.CENTER,
					new JArray(Center.X, Center.Y, Center.Z)
				));
			}

			return new JProperty(CESIUM_RTCExtensionFactory.EXTENSION_NAME, ext);
		}
	}
}