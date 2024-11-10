using UnityEngine;

namespace Unity.VRTemplate
{
	public class DestroyObject : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Time before destroying in seconds.")]
		private float m_Lifetime;

		private void Start()
		{
		}
	}
}
