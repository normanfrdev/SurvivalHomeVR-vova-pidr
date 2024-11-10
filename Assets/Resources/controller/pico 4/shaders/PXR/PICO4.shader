Shader "PXR/PICO4" {
	Properties {
		[NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
		_DiffuseColor ("DiffuseColor", Vector) = (1,1,1,1)
		[HDR] _FresnelCol ("FresnelColor", Vector) = (1,1,1,1)
		_FresnelPower ("FresnelPower", Range(0, 99)) = 1
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