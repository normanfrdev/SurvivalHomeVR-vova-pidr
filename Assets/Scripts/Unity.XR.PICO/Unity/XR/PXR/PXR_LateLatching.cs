using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	[Serializable]
	public class PXR_LateLatching : MonoBehaviour
	{
		private Camera m_LateLatchingCamera;

		private static XRDisplaySubsystem s_DisplaySubsystem;

		private static List<XRDisplaySubsystem> s_DisplaySubsystems;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnPreRender()
		{
		}

		private void OnPostRender()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
