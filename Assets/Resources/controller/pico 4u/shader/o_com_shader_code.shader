Shader "o_com_shader_code" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		_LightColor_01 ("Light Color_01", Vector) = (0.3921569,0.3921569,0.3921569,1)
		_LightColor_02 ("Light Color_02", Vector) = (0.3921569,0.3921569,0.3921569,1)
		_MainTex ("MainTex", 2D) = "white" {}
		_Tint ("Tint", Vector) = (1,1,1,0)
		_Matcap_01 ("Matcap_01", 2D) = "white" {}
		_Matcap_02 ("Matcap_02", 2D) = "white" {}
		_MatcapIntensity ("MatcapIntensity", Range(0, 2)) = 0
		_Light ("Light", Vector) = (0,0,0,0)
		_Light_Power ("Light_Power", Range(0, 4)) = 1
		[Toggle(_LIGHT_O_ON)] _Light_O ("Light_O", Float) = 0
		_Mask ("Mask", 2D) = "white" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}