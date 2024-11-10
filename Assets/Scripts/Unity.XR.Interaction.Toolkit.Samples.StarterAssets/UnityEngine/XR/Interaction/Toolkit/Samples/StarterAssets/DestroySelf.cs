namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class DestroySelf : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The amount of time, in seconds, to wait after Start before destroying the GameObject.")]
		private float m_Lifetime;

		public float lifetime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Start()
		{
		}
	}
}
