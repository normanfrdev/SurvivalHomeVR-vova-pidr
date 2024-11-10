using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.XR.Management
{
	public abstract class XRLoader : ScriptableObject
	{
		public virtual bool Initialize()
		{
			return false;
		}

		public virtual bool Start()
		{
			return false;
		}

		public virtual bool Stop()
		{
			return false;
		}

		public virtual bool Deinitialize()
		{
			return false;
		}

		public abstract T GetLoadedSubsystem<T>() where T : class, ISubsystem;

		public virtual List<GraphicsDeviceType> GetSupportedGraphicsDeviceTypes(bool buildingPlayer)
		{
			return null;
		}
	}
}
