using System.Collections.Generic;

namespace Unity.Tutorials.Core
{
	public class SceneObjectGuidManager
	{
		private static SceneObjectGuidManager m_Instance;

		private Dictionary<string, SceneObjectGuid> m_Components;

		public static SceneObjectGuidManager Instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public void Register(SceneObjectGuid component)
		{
		}

		public bool Contains(string id)
		{
			return false;
		}

		public bool Unregister(SceneObjectGuid component)
		{
			return false;
		}

		public SceneObjectGuid GetComponent(string id)
		{
			return null;
		}
	}
}
