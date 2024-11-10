using UnityEngine;
using UnityEngine.Video;

namespace Unity.VRTemplate
{
	[RequireComponent(typeof(VideoPlayer))]
	public class VideoPlayerRenderTexture : MonoBehaviour
	{
		private const string k_ShaderName = "Unlit/Texture";

		[SerializeField]
		[Tooltip("The target Renderer which will display the video.")]
		private Renderer m_Renderer;

		[SerializeField]
		[Tooltip("The width of the RenderTexture which will be created.")]
		private int m_RenderTextureWidth;

		[SerializeField]
		[Tooltip("The height of the RenderTexture which will be created.")]
		private int m_RenderTextureHeight;

		[SerializeField]
		[Tooltip("The bit depth of the depth channel for the RenderTexture which will be created.")]
		private int m_RenderTextureDepth;

		private void Start()
		{
		}
	}
}
