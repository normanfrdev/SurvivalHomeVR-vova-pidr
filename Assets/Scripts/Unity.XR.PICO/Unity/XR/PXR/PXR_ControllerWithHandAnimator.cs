using Unity.XR.PXR.Input;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	public class PXR_ControllerWithHandAnimator : MonoBehaviour
	{
		public PXR_Input.Controller controller;

		private Animator mAnimator;

		private InputDevice mInputDevice;

		private PXR_Controller mXRController;

		private readonly float animation_time;

		private float per_animation_step;

		private readonly string trigger_Touch_LayerName;

		private int trigger_Touch_LayerIndex;

		private readonly string trigger_Value_LayerName;

		private int trigger_Value_LayerIndex;

		private bool trigger_Touch;

		private float trigger_Value;

		private float trigger_Touch_Weight;

		private readonly string X_A_Touch_LayerName;

		private int X_A_Touch_LayerIndex;

		private readonly string X_A_Press_LayerName;

		private int X_A_Press_LayerIndex;

		private bool X_A_Press;

		private bool X_A_Touch;

		private float X_A_Touch_Weight;

		private readonly string Y_B_Touch_LayerName;

		private int Y_B_Touch_LayerIndex;

		private readonly string Y_B_Press_LayerName;

		private int Y_B_Press_LayerIndex;

		private bool Y_B_Press;

		private bool Y_B_Touch;

		private float Y_B_Touch_Weight;

		private readonly string X_A_Y_B_Press_LayerName;

		private int X_A_Y_B_Press_LayerIndex;

		private readonly string X_A_Y_B_Touch_LayerName;

		private int X_A_Y_B_Touch_LayerIndex;

		private float X_A_Y_B_Touch_Weight;

		private readonly string grip_Value_LayerName;

		private int grip_Value_LayerIndex;

		private float grip_Value;

		private readonly string primary2DAxis_Touch_LayerName;

		private int primary2DAxis_Touch_LayerIndex;

		private readonly string primary2DAxis_Vertical;

		private int primary2DAxis_Vertical_Index;

		private readonly string primary2DAxis_Horizontal;

		private int primary2DAxis_Horizontal_Index;

		private Vector2 primary2DAxisVec2;

		private bool primary2DAxis_Touch;

		private float primary2DAxis_Touch_Weight;

		private readonly string menu_Press_LayerName;

		private int menu_Press_LayerIndex;

		private bool menu_Press;

		private float menu_Press_Weight;

		private readonly string pico_Press_LayerName;

		private int pico_Press_LayerIndex;

		private bool pico_Press;

		private float pico_Press_Weight;

		private readonly string thumbstick_Touch_LayerName;

		private int thumbstick_Touch_LayerIndex;

		private bool thumbstick_Touch;

		private float thumbstick_Touch_Weight;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
