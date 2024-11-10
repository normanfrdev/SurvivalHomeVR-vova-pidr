using UnityEngine;

namespace Unity.VRTemplate
{
	public class Rotator : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Angular velocity in degrees per second")]
		private Vector3 m_Velocity;

		private void Update()
		{
		}
	}
}
