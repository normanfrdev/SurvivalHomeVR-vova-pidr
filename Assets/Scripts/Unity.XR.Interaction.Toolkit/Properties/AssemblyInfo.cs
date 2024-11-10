using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using Unity.Burst;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Editor")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Samples.StarterAssets.Editor")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Tests")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Editor.Tests")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Samples.StarterAssets")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Samples.ARStarterAssets")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Samples.Hands")]
[assembly: InternalsVisibleTo("Unity.XR.Interaction.Toolkit.Samples.VisionOS")]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SortingHelpers.SquareDistanceAttachPointEvaluator.SqDistanceToInteractable_0000159C_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EBezierLerp_0000033F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EBezierLerp_00000340_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EBounceOutLerp_00000342_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EBounceOutLerp_00000343_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ESingleBounceOutLerp_00000346_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ESingleBounceOutLerp_00000347_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EOrthogonalUpVector_00000349_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EOrthogonalUpVector_0000034A_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EOrthogonalLookRotation_0000034B_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EOrthogonalLookRotation_0000034C_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EProjectOnPlane_0000034D_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EProjectOnPlane_0000034E_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ELookRotationWithForwardProjectedOnPlane_0000034F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ELookRotationWithForwardProjectedOnPlane_00000350_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EAngle_00000351_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EAngle_00000352_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EFastVectorEquals_00000353_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EFastVectorEquals_00000354_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EFastSafeDivide_00000355_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EFastSafeDivide_00000356_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EScale_00000357_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EScale_00000358_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EOrthogonal_0000035A_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EGetSphereOverlapParameters_0000035B_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EGetConecastParameters_0000035C_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002EGetConecastOffset_0000035D_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ETweenables_002ESmartTweenableVariables_002EComputeNewTweenTarget_00000402_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ETweenables_002ESmartTweenableVariables_002EComputeNewTweenTarget_0000040E_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ETweenables_002ESmartTweenableVariables_002EIsNewTargetWithinThreshold_0000040F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002ESampleQuadraticBezierPoint_0000042F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002ESampleCubicBezierPoint_00000430_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002EElevateQuadraticToCubicBezier_00000431_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002EGenerateCubicBezierCurve_00000432_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002ETryGenerateCubicBezierCurve_00000433_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002ETryGenerateCubicBezierCurve_00000434_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002EApproximateCubicBezierLength_00000436_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002ESampleProjectilePoint_00000437_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EUtilities_002ECurves_002ECalculateProjectileFlightTime_00000438_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EComputeNewObjectPosition_00000828_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EAdjustPositionForPermittedAxesBurst_0000082C_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EComputeNewOneHandedScale_0000082E_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EComputeNewTwoHandedScale_0000082F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EFastCalculateRadiusOffset_0000084F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EFastComputeNewTrackedPose_00000850_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002EIsWithinRadius_00000851_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002ETransformers_002ECalculateScaleToFit_00000852_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002EGetAdjustedEndPointForMaxDistance_00000C29_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002EGetClosestPointOnLine_00000C2A_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002EAdjustCastHitEndPoint_00000C2B_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002EComputeFallBackLine_00000C2C_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002ECalculateLineCurveRenderPoints_00000C7F_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002EComputeNewRenderPoints_00000C80_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractors_002EVisuals_002EEvaluateLineEndPoint_00000C81_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractables_002EEaseAttachBurst_00000E80_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInteractables_002EStepSmoothingBurst_00000E81_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EGaze_002EGetAssistedVelocityInternal_00000EFD_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EAttachment_002EComputeAmplifiedOffset_00001015_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInputs_002EStabilizeTransform_00001081_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInputs_002EStabilizePosition_00001082_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInputs_002EStabilizeOptimalRotation_00001083_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInputs_002ECalculateStabilizedLerp_00001084_0024BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UnityEngine_002EXR_002EInteraction_002EToolkit_002EInputs_002ECalculateRotationParams_00001085_0024BurstDirectCall))]
[assembly: AssemblyVersion("0.0.0.0")]
