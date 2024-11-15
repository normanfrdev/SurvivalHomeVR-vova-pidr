using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement
	{
		[CompilerGenerated]
		private sealed class _003CDelayedGraphicRebuild_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshProUGUI _003C_003E4__this;

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
			public _003CDelayedGraphicRebuild_003Ed__18(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CDelayedMaterialRebuild_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshProUGUI _003C_003E4__this;

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
			public _003CDelayedMaterialRebuild_003Ed__19(int _003C_003E1__state)
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

		private bool m_isRebuildingLayout;

		private Coroutine m_DelayedGraphicRebuild;

		private Coroutine m_DelayedMaterialRebuild;

		private Rect m_ClipRect;

		private bool m_ValidRect;

		[SerializeField]
		private bool m_hasFontAssetChanged;

		protected TMP_SubMeshUI[] m_subTextObjects;

		private float m_previousLossyScaleY;

		private Vector3[] m_RectTransformCorners;

		private CanvasRenderer m_canvasRenderer;

		private Canvas m_canvas;

		private float m_CanvasScaleFactor;

		private bool m_isFirstAllocation;

		private int m_max_characters;

		[SerializeField]
		private Material m_baseMaterial;

		private bool m_isScrollRegionSet;

		[SerializeField]
		private Vector4 m_maskOffset;

		private Matrix4x4 m_EnvMapMatrix;

		[NonSerialized]
		private bool m_isRegisteredForEvents;

		private static ProfilerMarker k_GenerateTextMarker;

		private static ProfilerMarker k_SetArraySizesMarker;

		private static ProfilerMarker k_GenerateTextPhaseIMarker;

		private static ProfilerMarker k_ParseMarkupTextMarker;

		private static ProfilerMarker k_CharacterLookupMarker;

		private static ProfilerMarker k_HandleGPOSFeaturesMarker;

		private static ProfilerMarker k_CalculateVerticesPositionMarker;

		private static ProfilerMarker k_ComputeTextMetricsMarker;

		private static ProfilerMarker k_HandleVisibleCharacterMarker;

		private static ProfilerMarker k_HandleWhiteSpacesMarker;

		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker;

		private static ProfilerMarker k_HandleVerticalLineBreakingMarker;

		private static ProfilerMarker k_SaveGlyphVertexDataMarker;

		private static ProfilerMarker k_ComputeCharacterAdvanceMarker;

		private static ProfilerMarker k_HandleCarriageReturnMarker;

		private static ProfilerMarker k_HandleLineTerminationMarker;

		private static ProfilerMarker k_SavePageInfoMarker;

		private static ProfilerMarker k_SaveProcessingStatesMarker;

		private static ProfilerMarker k_GenerateTextPhaseIIMarker;

		private static ProfilerMarker k_GenerateTextPhaseIIIMarker;

		public override Material materialForRendering => null;

		public override bool autoSizeTextContainer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override Mesh mesh => null;

		public new CanvasRenderer canvasRenderer => null;

		public Vector4 maskOffset
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public override event Action<TMP_TextInfo> OnPreRenderText
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}

		public override void SetVerticesDirty()
		{
		}

		public override void SetLayoutDirty()
		{
		}

		public override void SetMaterialDirty()
		{
		}

		public override void SetAllDirty()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedGraphicRebuild_003Ed__18))]
		private IEnumerator DelayedGraphicRebuild()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelayedMaterialRebuild_003Ed__19))]
		private IEnumerator DelayedMaterialRebuild()
		{
			return null;
		}

		public override void Rebuild(CanvasUpdate update)
		{
		}

		private void UpdateSubObjectPivot()
		{
		}

		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		protected override void UpdateMaterial()
		{
		}

		public override void RecalculateClipping()
		{
		}

		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		internal override void UpdateCulling()
		{
		}

		public override void UpdateMeshPadding()
		{
		}

		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		public override TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		public override void ClearMesh()
		{
		}

		public override void UpdateGeometry(Mesh mesh, int index)
		{
		}

		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		public override void UpdateVertexData()
		{
		}

		public void UpdateFontAsset()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void LoadFontAsset()
		{
		}

		private Canvas GetCanvas()
		{
			return null;
		}

		private void UpdateEnvMapMatrix()
		{
		}

		private void EnableMasking()
		{
		}

		private void DisableMasking()
		{
		}

		private void UpdateMask()
		{
		}

		protected override Material GetMaterial(Material mat)
		{
			return null;
		}

		protected override Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		protected override void SetSharedMaterial(Material mat)
		{
		}

		protected override Material[] GetSharedMaterials()
		{
			return null;
		}

		protected override void SetSharedMaterials(Material[] materials)
		{
		}

		protected override void SetOutlineThickness(float thickness)
		{
		}

		protected override void SetFaceColor(Color32 color)
		{
		}

		protected override void SetOutlineColor(Color32 color)
		{
		}

		protected override void SetShaderDepth()
		{
		}

		protected override void SetCulling()
		{
		}

		private void SetPerspectiveCorrection()
		{
		}

		private void SetMeshArrays(int size)
		{
		}

		internal override int SetArraySizes(UnicodeChar[] unicodeChars)
		{
			return 0;
		}

		public override void ComputeMarginSize()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		protected override void OnCanvasHierarchyChanged()
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		internal override void InternalUpdate()
		{
		}

		private void OnPreRenderCanvas()
		{
		}

		protected virtual void GenerateTextMesh()
		{
		}

		protected override Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		protected override void SetActiveSubMeshes(bool state)
		{
		}

		protected override void DestroySubMeshObjects()
		{
		}

		protected override Bounds GetCompoundBounds()
		{
			return default(Bounds);
		}

		internal override Rect GetCanvasSpaceClippingRect()
		{
			return default(Rect);
		}

		private void UpdateSDFScale(float scaleDelta)
		{
		}
	}
}
