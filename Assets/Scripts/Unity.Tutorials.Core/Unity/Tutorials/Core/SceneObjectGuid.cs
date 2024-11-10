using System;
using UnityEngine;

namespace Unity.Tutorials.Core
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public class SceneObjectGuid : MonoBehaviour
	{
		[SerializeField]
		private string m_Id;

		[NonSerialized]
		private bool m_Registered;

		public string Id => null;

		private void Awake()
		{
		}

		private void Register()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
