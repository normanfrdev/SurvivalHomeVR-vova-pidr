Shader "HPE/hand_axis" {
	Properties {
		[Hand(FadeColor)] _Scale ("Scale", Float) = 20
		_Power ("Power", Float) = 3
		_ColorX ("ColorX", Vector) = (206,71,38,1)
		_ColorY ("ColorY", Vector) = (156,204,85,1)
		_ColorZ ("ColorZ", Vector) = (66,118,184,1)
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