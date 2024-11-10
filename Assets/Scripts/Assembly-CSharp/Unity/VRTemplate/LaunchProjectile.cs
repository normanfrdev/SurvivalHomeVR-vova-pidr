using UnityEngine;

namespace Unity.VRTemplate
{
	public class LaunchProjectile : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The projectile that's created")]
		private GameObject m_ProjectilePrefab;

		[SerializeField]
		[Tooltip("The point that the project is created")]
		private Transform m_StartPoint;

		[SerializeField]
		[Tooltip("The speed at which the projectile is launched")]
		private float m_LaunchSpeed;

		public void Fire()
		{
		}

		private void ApplyForce(Rigidbody rigidBody)
		{
		}
	}
}
