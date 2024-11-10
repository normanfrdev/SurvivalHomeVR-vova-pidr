using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Unity.VRTemplate
{
	[RequireComponent(typeof(VideoPlayer))]
	public class VideoTimeScrubControl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHideSliderAfterSeconds_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public VideoTimeScrubControl _003C_003E4__this;

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
			public _003CHideSliderAfterSeconds_003Ed__18(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("Video play/pause button GameObject")]
		private GameObject m_ButtonPlayOrPause;

		[SerializeField]
		[Tooltip("Slider that controls the video")]
		private Slider m_Slider;

		[SerializeField]
		[Tooltip("Play icon sprite")]
		private Sprite m_IconPlay;

		[SerializeField]
		[Tooltip("Pause icon sprite")]
		private Sprite m_IconPause;

		[SerializeField]
		[Tooltip("Play or pause button image.")]
		private Image m_ButtonPlayOrPauseIcon;

		[SerializeField]
		[Tooltip("Text that displays the current time of the video.")]
		private TextMeshProUGUI m_VideoTimeText;

		[SerializeField]
		[Tooltip("If checked, the slider will fade off after a few seconds. If unchecked, the slider will remain on.")]
		private bool m_HideSliderAfterFewSeconds;

		private bool m_IsDragging;

		private bool m_VideoIsPlaying;

		private bool m_VideoJumpPending;

		private long m_LastFrameBeforeScrub;

		private VideoPlayer m_VideoPlayer;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void OnPointerDown()
		{
		}

		public void OnRelease()
		{
		}

		private void OnSliderValueChange(float sliderValue)
		{
		}

		[IteratorStateMachine(typeof(_003CHideSliderAfterSeconds_003Ed__18))]
		private IEnumerator HideSliderAfterSeconds(float duration = 1f)
		{
			return null;
		}

		public void OnDrag()
		{
		}

		private void VideoJump()
		{
		}

		public void PlayOrPauseVideo()
		{
		}

		private void UpdateVideoTimeText()
		{
		}

		private void VideoStop()
		{
		}

		private void VideoPlay()
		{
		}
	}
}
