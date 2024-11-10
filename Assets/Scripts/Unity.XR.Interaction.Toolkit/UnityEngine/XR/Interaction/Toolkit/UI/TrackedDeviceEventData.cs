using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	public class TrackedDeviceEventData : PointerEventData
	{
		public List<Vector3> rayPoints
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int rayHitIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LayerMask layerMask
		{
			[CompilerGenerated]
			get
			{
				return default(LayerMask);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IUIInteractor interactor => null;

		internal Vector3 pressWorldPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TrackedDeviceEventData(EventSystem eventSystem)
			: base(null)
		{
		}
	}
}
