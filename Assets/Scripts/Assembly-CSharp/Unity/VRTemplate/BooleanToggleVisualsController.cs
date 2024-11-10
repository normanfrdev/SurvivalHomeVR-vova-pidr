using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Unity.VRTemplate
{
	[RequireComponent(typeof(Toggle))]
	public class BooleanToggleVisualsController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		private const float k_TargetPositionX = 17f;

		[SerializeField]
		[Tooltip("The boolean toggle knob.")]
		private RectTransform m_Knob;

		[SerializeField]
		[Tooltip("How much to translate the button imagery on the z on hover.")]
		private float m_ZTranslation;

		private Toggle m_Toggle;

		private float m_InitialBackground;

		private Coroutine m_ColorFade;

		private Coroutine m_LocalMove;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		private void ToggleValueChanged(bool value)
		{
		}

		private void PerformEntranceActions()
		{
		}

		private void PerformExitActions()
		{
		}
	}
}
