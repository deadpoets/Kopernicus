// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSOceanSurfaceQuadFallback : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                private const string shaderName = "Terrain/PQS/Ocean Surface Quad (Fallback)";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Main Color, default = (1,1,1,1)
                public const string colorKey = "_Color";
                public int colorID { get; private set; }

                // Color From Space, default = (1,1,1,1)
                public const string colorFromSpaceKey = "_ColorFromSpace";
                public int colorFromSpaceID { get; private set; }

                // Specular Color, default = (1,1,1,1)
                public const string specColorKey = "_SpecColor";
                public int specColorID { get; private set; }

                // Shininess, default = 0.078125
                public const string shininessKey = "_Shininess";
                public int shininessID { get; private set; }

                // Gloss, default = 0.078125
                public const string glossKey = "_Gloss";
                public int glossID { get; private set; }

                // Tex Tiling, default = 1
                public const string tilingKey = "_tiling";
                public int tilingID { get; private set; }

                // Tex0, default = "white" { }
                public const string waterTexKey = "_WaterTex";
                public int waterTexID { get; private set; }

                // Tex1, default = "white" { }
                public const string waterTex1Key = "_WaterTex1";
                public int waterTex1ID { get; private set; }

                // FadeStart, default = 1
                public const string fadeStartKey = "_fadeStart";
                public int fadeStartID { get; private set; }

                // FadeEnd, default = 1
                public const string fadeEndKey = "_fadeEnd";
                public int fadeEndID { get; private set; }

                // PlanetOpacity, default = 1
                public const string planetOpacityKey = "_PlanetOpacity";
                public int planetOpacityID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
                    get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
                    colorID = Shader.PropertyToID(colorKey);
                    colorFromSpaceID = Shader.PropertyToID(colorFromSpaceKey);
                    specColorID = Shader.PropertyToID(specColorKey);
                    shininessID = Shader.PropertyToID(shininessKey);
                    glossID = Shader.PropertyToID(glossKey);
                    tilingID = Shader.PropertyToID(tilingKey);
                    waterTexID = Shader.PropertyToID(waterTexKey);
                    waterTex1ID = Shader.PropertyToID(waterTex1Key);
                    fadeStartID = Shader.PropertyToID(fadeStartKey);
                    fadeEndID = Shader.PropertyToID(fadeEndKey);
                    planetOpacityID = Shader.PropertyToID(planetOpacityKey);
                }
            }

            // Is some random material this material 
            public static bool UsesSameShader(Material m)
            {
                return m.shader.name == Properties.shader.name;
            }

            // Main Color, default = (1,1,1,1)
            public new Color color
            {
                get { return GetColor (Properties.Instance.colorID); }
                set { SetColor (Properties.Instance.colorID, value); }
            }

            // Color From Space, default = (1,1,1,1)
            public Color colorFromSpace
            {
                get { return GetColor (Properties.Instance.colorFromSpaceID); }
                set { SetColor (Properties.Instance.colorFromSpaceID, value); }
            }

            // Specular Color, default = (1,1,1,1)
            public Color specColor
            {
                get { return GetColor (Properties.Instance.specColorID); }
                set { SetColor (Properties.Instance.specColorID, value); }
            }

            // Shininess, default = 0.078125
            public float shininess
            {
                get { return GetFloat (Properties.Instance.shininessID); }
                set { SetFloat (Properties.Instance.shininessID, Mathf.Clamp(value,0.01f,1f)); }
            }

            // Gloss, default = 0.078125
            public float gloss
            {
                get { return GetFloat (Properties.Instance.glossID); }
                set { SetFloat (Properties.Instance.glossID, Mathf.Clamp(value,0.01f,1f)); }
            }

            // Tex Tiling, default = 1
            public float tiling
            {
                get { return GetFloat (Properties.Instance.tilingID); }
                set { SetFloat (Properties.Instance.tilingID, value); }
            }

            // Tex0, default = "white" { }
            public Texture2D waterTex
            {
                get { return GetTexture (Properties.Instance.waterTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.waterTexID, value); }
            }

            public Vector2 waterTexScale
            {
                get { return GetTextureScale (Properties.waterTexKey); }
                set { SetTextureScale (Properties.waterTexKey, value); }
            }

            public Vector2 waterTexOffset
            {
                get { return GetTextureOffset (Properties.waterTexKey); }
                set { SetTextureOffset (Properties.waterTexKey, value); }
            }

            // Tex1, default = "white" { }
            public Texture2D waterTex1
            {
                get { return GetTexture (Properties.Instance.waterTex1ID) as Texture2D; }
                set { SetTexture (Properties.Instance.waterTex1ID, value); }
            }

            public Vector2 waterTex1Scale
            {
                get { return GetTextureScale (Properties.waterTex1Key); }
                set { SetTextureScale (Properties.waterTex1Key, value); }
            }

            public Vector2 waterTex1Offset
            {
                get { return GetTextureOffset (Properties.waterTex1Key); }
                set { SetTextureOffset (Properties.waterTex1Key, value); }
            }

            // FadeStart, default = 1
            public float fadeStart
            {
                get { return GetFloat (Properties.Instance.fadeStartID); }
                set { SetFloat (Properties.Instance.fadeStartID, value); }
            }

            // FadeEnd, default = 1
            public float fadeEnd
            {
                get { return GetFloat (Properties.Instance.fadeEndID); }
                set { SetFloat (Properties.Instance.fadeEndID, value); }
            }

            // PlanetOpacity, default = 1
            public float planetOpacity
            {
                get { return GetFloat (Properties.Instance.planetOpacityID); }
                set { SetFloat (Properties.Instance.planetOpacityID, value); }
            }

            public PQSOceanSurfaceQuadFallback() : base(Properties.shader)
            {
            }

            [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.")]
            public PQSOceanSurfaceQuadFallback(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public PQSOceanSurfaceQuadFallback(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/PQS/Ocean Surface Quad (Fallback) shader required");
            }

        }
    }
}
