using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Pico.Platform.Samples
{
	public class SimpleDemo : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDownloadImage_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string mediaUrl;

			public SimpleDemo _003C_003E4__this;

			public RawImage rawImage;

			private UnityWebRequest _003Crequest_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDownloadImage_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public bool useAsyncInit;

		public RawImage headImage;

		public Text nameText;

		public Text logText;

		private void Start()
		{
		}

		private void EnterDemo()
		{
		}

		private void getUser()
		{
		}

		[IteratorStateMachine(typeof(_003CDownloadImage_003Ed__7))]
		private IEnumerator DownloadImage(string mediaUrl, RawImage rawImage)
		{
			return null;
		}

		private void Log(string s)
		{
		}
	}
}
