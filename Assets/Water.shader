Shader "Unlit/Water"
{
    Properties
    {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _Color ("Main Color", Color) = (0.0,0.5,1,0.5) // Water-like color
        _WaveStrength ("Wave Strength", float) = 0.5 // Controls the strength of wave distortions
        _Shininess ("Shininess", Range(0,1)) = 0.8 // Controls the shininess of the water surface
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _Color;
            float _WaveStrength;
            float _Shininess;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                
                // Add simple wave effect by modifying vertex positions
                float wave = sin(v.vertex.x * _WaveStrength + _Time.y) * cos(v.vertex.z * _WaveStrength + _Time.y) * 0.1;
                o.vertex.y += wave;
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv) * _Color;

                // Add simple water-like specular highlight
                float3 viewDir = normalize(UnityWorldSpaceViewDir(i.vertex.xyz));
                float3 norm = float3(0,1,0); // Assuming water surface is flat on Y axis
                float spec = pow(max(0.0, dot(norm, viewDir)), _Shininess * 128.0);
                col.rgb += spec;

                return col;
            }
            ENDCG
        }
    }
}
