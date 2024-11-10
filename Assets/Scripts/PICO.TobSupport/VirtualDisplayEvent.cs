using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class VirtualDisplayEvent : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IInitializePotentialDragHandler
{
	public new string tag;

	public XRRayInteractor xrLeftRayInteractor;

	public XRRayInteractor xrRightRayInteractor;

	public VirtualDisplayDemo virtualDisplayController;

	public Text mylog;

	private XRRayInteractor currentRayInteractor;

	private GameObject mDisplay;

	private RectTransform mDisplayTran;

	private int mKeyEvent;

	private const int KEYEVENT_DEFAULT = -1;

	private const int KEYEVENT_DOWN = 0;

	private const int KEYEVENT_UP = 1;

	private bool LeftState;

	private bool mLeftTriggerPressTemp;

	private bool RightState;

	private bool mRightTriggerPressTemp;

	private bool mIsUp;

	private float mLastX;

	private float mLastY;

	private void Start()
	{
	}

	public void showLog(string log)
	{
	}

	private void Update()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	private void DispatchMessageToAndroid(int actionType, PointerEventData eventData)
	{
	}

	private void InstrumentationInput(Vector3 eventPoint, int actionType)
	{
	}
}
