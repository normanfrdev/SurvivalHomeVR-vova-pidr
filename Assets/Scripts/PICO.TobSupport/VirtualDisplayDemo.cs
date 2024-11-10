using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.UI;

public class VirtualDisplayDemo : MonoBehaviour
{
	private new string tag;

	private PXR_OverLay overlay;

	public Text mylog;

	private bool isBind;

	private int displayId;

	public const int VIRTUAL_DISPLAY_FLAG_AUTO_MIRROR = 16;

	public const int VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLY = 8;

	public const int VIRTUAL_DISPLAY_FLAG_PRESENTATION = 2;

	public const int VIRTUAL_DISPLAY_FLAG_PUBLIC = 1;

	public const int VIRTUAL_DISPLAY_FLAG_SECURE = 4;

	public const int SOURCE_KEYBOARD = 257;

	public const int ACTION_DOWN = 0;

	public const int ACTION_UP = 1;

	public const int ACTION_MOVE = 2;

	private int KEYCODE_BACK;

	private void Awake()
	{
	}

	public void showLog(string log)
	{
	}

	private void Start()
	{
	}

	public void OpenApp()
	{
	}

	public void ReleaseVirtualDisplay()
	{
	}

	public void InjectEvent(int action, float x, float y)
	{
	}

	public void bcak()
	{
	}
}
