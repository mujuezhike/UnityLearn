Shader "Custom/TerrainShader" {
	Properties {
		_Color ("Main Color", Color) = (1.0,0.9,0.0,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_DetailTex1 ("Detail1 (RGB)", 2D) = "white" {}
		//_DetailTex2 ("Detail2 (RGB)", 2D) = "white" {}
	}
	SubShader 
	{
		Pass {
			Lighting Off

 			SetTexture [_MainTex] {
				constantColor [_Color]
				Combine texture * constant
			}

 			SetTexture [_DetailTex1] {
				Combine texture * previous DOUBLE, previous
			}
			
		
		}
	}
}
