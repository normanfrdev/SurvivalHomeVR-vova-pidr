Shader "PXR/Hand" {
	Properties {
		[Header(BaseColor)] _InnerColor ("内部颜色", Vector) = (1,1,1,1)
		_OutColor ("外部颜色", Vector) = (1,1,1,1)
		_FresnelPower ("菲涅尔强度", Float) = 1
		[Header(Light)] [Space(5)] _PressLight ("按下光照", Vector) = (1,1,1,1)
		_ClickLight ("点击光照", Vector) = (1,1,1,1)
		_PressRange ("按压范围", Range(0, 1)) = 0.015
		_ClickRange ("点击范围", Range(0, 1)) = 0.015
		_ClickPosition ("点击位置", Vector) = (1,1,1,1)
		_PressIntensity ("按压强度", Range(0, 1)) = 1
		[Header(Wrist)] [Space(10)] _WristFadeRange ("腕部渐变范围", Range(0, 1)) = 1
		_MainAlpha ("总透明度", Range(0, 1)) = 1
		_FadeIn ("透明消隐", Range(0, 1)) = 0
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