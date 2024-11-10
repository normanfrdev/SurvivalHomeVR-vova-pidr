Shader "HPE/Highlight" {
	Properties {
		[Header(Finger)] _FingerIndex ("FingerIndex", Vector) = (0.28,0.875,0.03,0.3)
		_FingerMiddle ("FingerMiddle", Vector) = (0.38,0.825,0.035,0.3)
		_FingerRing ("FingerRing", Vector) = (0.47,0.86,0.04,0.3)
		_FingerThumb ("FingerThumb", Vector) = (0.178,0.72,0.05,0.25)
		_LightColor ("LightColor", Vector) = (1,0,0,0)
		_BlendPower ("BlendPower", Vector) = (1,1,1,1)
		[HideInInspector] _Head ("Head", Float) = 1
		[HideInInspector] _Smooth ("Smooth", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
}