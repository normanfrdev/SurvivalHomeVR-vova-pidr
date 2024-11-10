using System;
using System.Collections.Generic;

namespace UnityEngine.XR.Management
{
	public abstract class XRLoaderHelper : XRLoader
	{
		protected Dictionary<Type, ISubsystem> m_SubsystemInstanceMap;

		public override T GetLoadedSubsystem<T>()
		{
			return null;
		}

		protected void StartSubsystem<T>() where T : class, ISubsystem
		{
		}

		protected void StopSubsystem<T>() where T : class, ISubsystem
		{
		}

		protected void DestroySubsystem<T>() where T : class, ISubsystem
		{
		}

		protected void CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : ISubsystemDescriptor where TSubsystem : ISubsystem
		{
		}

		[Obsolete("This method is obsolete. Please use the geenric CreateSubsystem method.", false)]
		protected void CreateIntegratedSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : IntegratedSubsystemDescriptor where TSubsystem : IntegratedSubsystem
		{
		}

		[Obsolete("This method is obsolete. Please use the generic CreateSubsystem method.", false)]
		protected void CreateStandaloneSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : SubsystemDescriptor where TSubsystem : Subsystem
		{
		}

		public override bool Deinitialize()
		{
			return false;
		}
	}
}
