using System;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public class UndoBlock : IDisposable
	{
		private int m_UndoGroup;

		private bool m_DisposedValue;

		public UndoBlock(string undoLabel, bool testMode = false)
		{
		}

		public void RegisterCreatedObject(UnityEngine.Object objectToUndo)
		{
		}

		public void RecordObject(UnityEngine.Object objectToUndo)
		{
		}

		public void SetTransformParent(Transform transform, Transform newParent)
		{
		}

		public T AddComponent<T>(GameObject gameObject) where T : Component
		{
			return null;
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
