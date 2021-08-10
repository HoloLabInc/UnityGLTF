using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGLTF
{
	public class CesiumRtcExtensionComponent : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private double centerX;

		[SerializeField]
		[HideInInspector]
		private double centerY;

		[SerializeField]
		[HideInInspector]
		private double centerZ;

		public double CenterX
		{
			set => centerX = value;
			get => centerX;
		}

		public double CenterY
		{
			set => centerY = value;
			get => centerY;
		}

		public double CenterZ
		{
			set => centerZ = value;
			get => centerZ;
		}
	}
}
