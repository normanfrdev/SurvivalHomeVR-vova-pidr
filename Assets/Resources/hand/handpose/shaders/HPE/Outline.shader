Shader "HPE/Outline" {
	Properties {
		[Header(Outline)] _OutlineWidth ("Width", Range(0, 0.005)) = 0.002
		_OutlineColor ("Color", Vector) = (1,1,1,1)
		_OutlineOpacity ("Opacity", Range(0, 1)) = 0.4
		_FadeIntensity ("Intensity", Range(-5, 5)) = 0
		_FadeOffset ("Offset", Range(-5, 5)) = 1
		_FadeOffset2 ("Offset2", Range(-5, 5)) = 1
		[MaterialToggle] _HandFade_Toggle ("HandFade_Toggle", Float) = 0.5
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