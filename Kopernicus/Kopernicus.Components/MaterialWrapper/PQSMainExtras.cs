// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSMainExtras : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                public const string shaderName = "Terrain/PQS/PQS Main - Extras";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Saturation, default = 1
                public const string saturationKey = "_saturation";
                public int saturationID { get; private set; }

                // Contrast, default = 1
                public const string contrastKey = "_contrast";
                public int contrastID { get; private set; }

                // Colour Unsaturation (A = Factor), default = (1,1,1,0)
                public const string tintColorKey = "_tintColor";
                public int tintColorID { get; private set; }

                // Near Blend, default = 0.5
                public const string powerNearKey = "_powerNear";
                public int powerNearID { get; private set; }

                // Far Blend, default = 0.5
                public const string powerFarKey = "_powerFar";
                public int powerFarID { get; private set; }

                // NearFar Start, default = 2000
                public const string groundTexStartKey = "_groundTexStart";
                public int groundTexStartID { get; private set; }

                // NearFar End, default = 10000
                public const string groundTexEndKey = "_groundTexEnd";
                public int groundTexEndID { get; private set; }

                // Steep Blend, default = 1
                public const string steepPowerKey = "_steepPower";
                public int steepPowerID { get; private set; }

                // Steep Fade Start, default = 20000
                public const string steepTexStartKey = "_steepTexStart";
                public int steepTexStartID { get; private set; }

                // Steep Fade End, default = 30000
                public const string steepTexEndKey = "_steepTexEnd";
                public int steepTexEndID { get; private set; }

                // Steep Texture, default = "white" {}
                public const string steepTexKey = "_steepTex";
                public int steepTexID { get; private set; }

                // Steep Bump Map, default = "bump" {}
                public const string steepBumpMapKey = "_steepBumpMap";
                public int steepBumpMapID { get; private set; }

                // Steep Near Tiling, default = 1
                public const string steepNearTilingKey = "_steepNearTiling";
                public int steepNearTilingID { get; private set; }

                // Steep Far Tiling, default = 1
                public const string steepTilingKey = "_steepTiling";
                public int steepTilingID { get; private set; }

                // Low Texture, default = "white" {}
                public const string lowTexKey = "_lowTex";
                public int lowTexID { get; private set; }

                // Low Bump Map, default = "bump" {}
                public const string lowBumpMapKey = "_lowBumpMap";
                public int lowBumpMapID { get; private set; }

                // Low Near Tiling, default = 1000
                public const string lowNearTilingKey = "_lowNearTiling";
                public int lowNearTilingID { get; private set; }

                // Low Far Tiling, default = 10
                public const string lowMultiFactorKey = "_lowMultiFactor";
                public int lowMultiFactorID { get; private set; }

                // Low Bump Near Tiling, default = 1
                public const string lowBumpNearTilingKey = "_lowBumpNearTiling";
                public int lowBumpNearTilingID { get; private set; }

                // Low Bump Far Tiling, default = 1
                public const string lowBumpFarTilingKey = "_lowBumpFarTiling";
                public int lowBumpFarTilingID { get; private set; }

                // Mid Texture, default = "white" {}
                public const string midTexKey = "_midTex";
                public int midTexID { get; private set; }

                // Mid Bump Map, default = "bump" {}
                public const string midBumpMapKey = "_midBumpMap";
                public int midBumpMapID { get; private set; }

                // Mid Near Tiling, default = 1000
                public const string midNearTilingKey = "_midNearTiling";
                public int midNearTilingID { get; private set; }

                // Mid Far Tiling, default = 10
                public const string midMultiFactorKey = "_midMultiFactor";
                public int midMultiFactorID { get; private set; }

                // Mid Bump Near Tiling, default = 1
                public const string midBumpNearTilingKey = "_midBumpNearTiling";
                public int midBumpNearTilingID { get; private set; }

                // Mid Bump Far Tiling, default = 1
                public const string midBumpFarTilingKey = "_midBumpFarTiling";
                public int midBumpFarTilingID { get; private set; }

                // High Texture, default = "white" {}
                public const string highTexKey = "_highTex";
                public int highTexID { get; private set; }

                // High Bump Map, default = "bump" {}
                public const string highBumpMapKey = "_highBumpMap";
                public int highBumpMapID { get; private set; }

                // High Near Tiling, default = 1000
                public const string highNearTilingKey = "_highNearTiling";
                public int highNearTilingID { get; private set; }

                // High Far Tiling, default = 10
                public const string highMultiFactorKey = "_highMultiFactor";
                public int highMultiFactorID { get; private set; }

                // High Bump Near Tiling, default = 1
                public const string highBumpNearTilingKey = "_highBumpNearTiling";
                public int highBumpNearTilingID { get; private set; }

                // High Bump Far Tiling, default = 1
                public const string highBumpFarTilingKey = "_highBumpFarTiling";
                public int highBumpFarTilingID { get; private set; }

                // Low Transition Start, default = 0
                public const string lowStartKey = "_lowStart";
                public int lowStartID { get; private set; }

                // Low Transition End, default = 0.3
                public const string lowEndKey = "_lowEnd";
                public int lowEndID { get; private set; }

                // High Transition Start, default = 0.8
                public const string highStartKey = "_highStart";
                public int highStartID { get; private set; }

                // High Transition End, default = 1
                public const string highEndKey = "_highEnd";
                public int highEndID { get; private set; }

                // AP Global Density, default = 1
                public const string globalDensityKey = "_globalDensity";
                public int globalDensityID { get; private set; }

                // FogColorRamp, default = "white" {}
                public const string fogColorRampKey = "_fogColorRamp";
                public int fogColorRampID { get; private set; }

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
                    saturationID = Shader.PropertyToID(saturationKey);
                    contrastID = Shader.PropertyToID(contrastKey);
                    tintColorID = Shader.PropertyToID(tintColorKey);
                    powerNearID = Shader.PropertyToID(powerNearKey);
                    powerFarID = Shader.PropertyToID(powerFarKey);
                    groundTexStartID = Shader.PropertyToID(groundTexStartKey);
                    groundTexEndID = Shader.PropertyToID(groundTexEndKey);
                    steepPowerID = Shader.PropertyToID(steepPowerKey);
                    steepTexStartID = Shader.PropertyToID(steepTexStartKey);
                    steepTexEndID = Shader.PropertyToID(steepTexEndKey);
                    steepTexID = Shader.PropertyToID(steepTexKey);
                    steepBumpMapID = Shader.PropertyToID(steepBumpMapKey);
                    steepNearTilingID = Shader.PropertyToID(steepNearTilingKey);
                    steepTilingID = Shader.PropertyToID(steepTilingKey);
                    lowTexID = Shader.PropertyToID(lowTexKey);
                    lowBumpMapID = Shader.PropertyToID(lowBumpMapKey);
                    lowNearTilingID = Shader.PropertyToID(lowNearTilingKey);
                    lowMultiFactorID = Shader.PropertyToID(lowMultiFactorKey);
                    lowBumpNearTilingID = Shader.PropertyToID(lowBumpNearTilingKey);
                    lowBumpFarTilingID = Shader.PropertyToID(lowBumpFarTilingKey);
                    midTexID = Shader.PropertyToID(midTexKey);
                    midBumpMapID = Shader.PropertyToID(midBumpMapKey);
                    midNearTilingID = Shader.PropertyToID(midNearTilingKey);
                    midMultiFactorID = Shader.PropertyToID(midMultiFactorKey);
                    midBumpNearTilingID = Shader.PropertyToID(midBumpNearTilingKey);
                    midBumpFarTilingID = Shader.PropertyToID(midBumpFarTilingKey);
                    highTexID = Shader.PropertyToID(highTexKey);
                    highBumpMapID = Shader.PropertyToID(highBumpMapKey);
                    highNearTilingID = Shader.PropertyToID(highNearTilingKey);
                    highMultiFactorID = Shader.PropertyToID(highMultiFactorKey);
                    highBumpNearTilingID = Shader.PropertyToID(highBumpNearTilingKey);
                    highBumpFarTilingID = Shader.PropertyToID(highBumpFarTilingKey);
                    lowStartID = Shader.PropertyToID(lowStartKey);
                    lowEndID = Shader.PropertyToID(lowEndKey);
                    highStartID = Shader.PropertyToID(highStartKey);
                    highEndID = Shader.PropertyToID(highEndKey);
                    globalDensityID = Shader.PropertyToID(globalDensityKey);
                    fogColorRampID = Shader.PropertyToID(fogColorRampKey);
                    planetOpacityID = Shader.PropertyToID(planetOpacityKey);
                }
            }

            // Is some random material this material
            public static bool UsesSameShader(Material m)
            {
                return m.shader.name == Properties.shaderName;
            }

            // Saturation, default = 1
            public float saturation
            {
                get { return GetFloat (Properties.Instance.saturationID); }
                set { SetFloat (Properties.Instance.saturationID, value); }
            }

            // Contrast, default = 1
            public float contrast
            {
                get { return GetFloat (Properties.Instance.contrastID); }
                set { SetFloat (Properties.Instance.contrastID, value); }
            }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            public Color tintColor
            {
                get { return GetColor (Properties.Instance.tintColorID); }
                set { SetColor (Properties.Instance.tintColorID, value); }
            }

            // Near Blend, default = 0.5
            public float powerNear
            {
                get { return GetFloat (Properties.Instance.powerNearID); }
                set { SetFloat (Properties.Instance.powerNearID, value); }
            }

            // Far Blend, default = 0.5
            public float powerFar
            {
                get { return GetFloat (Properties.Instance.powerFarID); }
                set { SetFloat (Properties.Instance.powerFarID, value); }
            }

            // NearFar Start, default = 2000
            public float groundTexStart
            {
                get { return GetFloat (Properties.Instance.groundTexStartID); }
                set { SetFloat (Properties.Instance.groundTexStartID, value); }
            }

            // NearFar End, default = 10000
            public float groundTexEnd
            {
                get { return GetFloat (Properties.Instance.groundTexEndID); }
                set { SetFloat (Properties.Instance.groundTexEndID, value); }
            }

            // Steep Blend, default = 1
            public float steepPower
            {
                get { return GetFloat (Properties.Instance.steepPowerID); }
                set { SetFloat (Properties.Instance.steepPowerID, value); }
            }

            // Steep Fade Start, default = 20000
            public float steepTexStart
            {
                get { return GetFloat (Properties.Instance.steepTexStartID); }
                set { SetFloat (Properties.Instance.steepTexStartID, value); }
            }

            // Steep Fade End, default = 30000
            public float steepTexEnd
            {
                get { return GetFloat (Properties.Instance.steepTexEndID); }
                set { SetFloat (Properties.Instance.steepTexEndID, value); }
            }

            // Steep Texture, default = "white" {}
            public Texture2D steepTex
            {
                get { return GetTexture (Properties.Instance.steepTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.steepTexID, value); }
            }

            public Vector2 steepTexScale
            {
                get { return GetTextureScale (Properties.steepTexKey); }
                set { SetTextureScale (Properties.steepTexKey, value); }
            }

            public Vector2 steepTexOffset
            {
                get { return GetTextureOffset (Properties.steepTexKey); }
                set { SetTextureOffset (Properties.steepTexKey, value); }
            }

            // Steep Bump Map, default = "bump" {}
            public Texture2D steepBumpMap
            {
                get { return GetTexture (Properties.Instance.steepBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.steepBumpMapID, value); }
            }

            public Vector2 steepBumpMapScale
            {
                get { return GetTextureScale (Properties.steepBumpMapKey); }
                set { SetTextureScale (Properties.steepBumpMapKey, value); }
            }

            public Vector2 steepBumpMapOffset
            {
                get { return GetTextureOffset (Properties.steepBumpMapKey); }
                set { SetTextureOffset (Properties.steepBumpMapKey, value); }
            }

            // Steep Near Tiling, default = 1
            public float steepNearTiling
            {
                get { return GetFloat (Properties.Instance.steepNearTilingID); }
                set { SetFloat (Properties.Instance.steepNearTilingID, value); }
            }

            // Steep Far Tiling, default = 1
            public float steepTiling
            {
                get { return GetFloat (Properties.Instance.steepTilingID); }
                set { SetFloat (Properties.Instance.steepTilingID, value); }
            }

            // Low Texture, default = "white" {}
            public Texture2D lowTex
            {
                get { return GetTexture (Properties.Instance.lowTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.lowTexID, value); }
            }

            public Vector2 lowTexScale
            {
                get { return GetTextureScale (Properties.lowTexKey); }
                set { SetTextureScale (Properties.lowTexKey, value); }
            }

            public Vector2 lowTexOffset
            {
                get { return GetTextureOffset (Properties.lowTexKey); }
                set { SetTextureOffset (Properties.lowTexKey, value); }
            }

            // Low Bump Map, default = "bump" {}
            public Texture2D lowBumpMap
            {
                get { return GetTexture (Properties.Instance.lowBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.lowBumpMapID, value); }
            }

            public Vector2 lowBumpMapScale
            {
                get { return GetTextureScale (Properties.lowBumpMapKey); }
                set { SetTextureScale (Properties.lowBumpMapKey, value); }
            }

            public Vector2 lowBumpMapOffset
            {
                get { return GetTextureOffset (Properties.lowBumpMapKey); }
                set { SetTextureOffset (Properties.lowBumpMapKey, value); }
            }

            // Low Near Tiling, default = 1000
            public float lowNearTiling
            {
                get { return GetFloat (Properties.Instance.lowNearTilingID); }
                set { SetFloat (Properties.Instance.lowNearTilingID, value); }
            }

            // Low Far Tiling, default = 10
            public float lowMultiFactor
            {
                get { return GetFloat (Properties.Instance.lowMultiFactorID); }
                set { SetFloat (Properties.Instance.lowMultiFactorID, value); }
            }

            // Low Bump Near Tiling, default = 1
            public float lowBumpNearTiling
            {
                get { return GetFloat (Properties.Instance.lowBumpNearTilingID); }
                set { SetFloat (Properties.Instance.lowBumpNearTilingID, value); }
            }

            // Low Bump Far Tiling, default = 1
            public float lowBumpFarTiling
            {
                get { return GetFloat (Properties.Instance.lowBumpFarTilingID); }
                set { SetFloat (Properties.Instance.lowBumpFarTilingID, value); }
            }

            // Mid Texture, default = "white" {}
            public Texture2D midTex
            {
                get { return GetTexture (Properties.Instance.midTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.midTexID, value); }
            }

            public Vector2 midTexScale
            {
                get { return GetTextureScale (Properties.midTexKey); }
                set { SetTextureScale (Properties.midTexKey, value); }
            }

            public Vector2 midTexOffset
            {
                get { return GetTextureOffset (Properties.midTexKey); }
                set { SetTextureOffset (Properties.midTexKey, value); }
            }

            // Mid Bump Map, default = "bump" {}
            public Texture2D midBumpMap
            {
                get { return GetTexture (Properties.Instance.midBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.midBumpMapID, value); }
            }

            public Vector2 midBumpMapScale
            {
                get { return GetTextureScale (Properties.midBumpMapKey); }
                set { SetTextureScale (Properties.midBumpMapKey, value); }
            }

            public Vector2 midBumpMapOffset
            {
                get { return GetTextureOffset (Properties.midBumpMapKey); }
                set { SetTextureOffset (Properties.midBumpMapKey, value); }
            }

            // Mid Near Tiling, default = 1000
            public float midNearTiling
            {
                get { return GetFloat (Properties.Instance.midNearTilingID); }
                set { SetFloat (Properties.Instance.midNearTilingID, value); }
            }

            // Mid Far Tiling, default = 10
            public float midMultiFactor
            {
                get { return GetFloat (Properties.Instance.midMultiFactorID); }
                set { SetFloat (Properties.Instance.midMultiFactorID, value); }
            }

            // Mid Bump Near Tiling, default = 1
            public float midBumpNearTiling
            {
                get { return GetFloat (Properties.Instance.midBumpNearTilingID); }
                set { SetFloat (Properties.Instance.midBumpNearTilingID, value); }
            }

            // Mid Bump Far Tiling, default = 1
            public float midBumpFarTiling
            {
                get { return GetFloat (Properties.Instance.midBumpFarTilingID); }
                set { SetFloat (Properties.Instance.midBumpFarTilingID, value); }
            }

            // High Texture, default = "white" {}
            public Texture2D highTex
            {
                get { return GetTexture (Properties.Instance.highTexID) as Texture2D; }
                set { SetTexture (Properties.Instance.highTexID, value); }
            }

            public Vector2 highTexScale
            {
                get { return GetTextureScale (Properties.highTexKey); }
                set { SetTextureScale (Properties.highTexKey, value); }
            }

            public Vector2 highTexOffset
            {
                get { return GetTextureOffset (Properties.highTexKey); }
                set { SetTextureOffset (Properties.highTexKey, value); }
            }

            // High Bump Map, default = "bump" {}
            public Texture2D highBumpMap
            {
                get { return GetTexture (Properties.Instance.highBumpMapID) as Texture2D; }
                set { SetTexture (Properties.Instance.highBumpMapID, value); }
            }

            public Vector2 highBumpMapScale
            {
                get { return GetTextureScale (Properties.highBumpMapKey); }
                set { SetTextureScale (Properties.highBumpMapKey, value); }
            }

            public Vector2 highBumpMapOffset
            {
                get { return GetTextureOffset (Properties.highBumpMapKey); }
                set { SetTextureOffset (Properties.highBumpMapKey, value); }
            }

            // High Near Tiling, default = 1000
            public float highNearTiling
            {
                get { return GetFloat (Properties.Instance.highNearTilingID); }
                set { SetFloat (Properties.Instance.highNearTilingID, value); }
            }

            // High Far Tiling, default = 10
            public float highMultiFactor
            {
                get { return GetFloat (Properties.Instance.highMultiFactorID); }
                set { SetFloat (Properties.Instance.highMultiFactorID, value); }
            }

            // High Bump Near Tiling, default = 1
            public float highBumpNearTiling
            {
                get { return GetFloat (Properties.Instance.highBumpNearTilingID); }
                set { SetFloat (Properties.Instance.highBumpNearTilingID, value); }
            }

            // High Bump Far Tiling, default = 1
            public float highBumpFarTiling
            {
                get { return GetFloat (Properties.Instance.highBumpFarTilingID); }
                set { SetFloat (Properties.Instance.highBumpFarTilingID, value); }
            }

            // Low Transition Start, default = 0
            public float lowStart
            {
                get { return GetFloat (Properties.Instance.lowStartID); }
                set { SetFloat (Properties.Instance.lowStartID, value); }
            }

            // Low Transition End, default = 0.3
            public float lowEnd
            {
                get { return GetFloat (Properties.Instance.lowEndID); }
                set { SetFloat (Properties.Instance.lowEndID, value); }
            }

            // High Transition Start, default = 0.8
            public float highStart
            {
                get { return GetFloat (Properties.Instance.highStartID); }
                set { SetFloat (Properties.Instance.highStartID, value); }
            }

            // High Transition End, default = 1
            public float highEnd
            {
                get { return GetFloat (Properties.Instance.highEndID); }
                set { SetFloat (Properties.Instance.highEndID, value); }
            }

            // AP Global Density, default = 1
            public float globalDensity
            {
                get { return GetFloat (Properties.Instance.globalDensityID); }
                set { SetFloat (Properties.Instance.globalDensityID, value); }
            }

            // FogColorRamp, default = "white" {}
            public Texture2D fogColorRamp
            {
                get { return GetTexture (Properties.Instance.fogColorRampID) as Texture2D; }
                set { SetTexture (Properties.Instance.fogColorRampID, value); }
            }

            public Vector2 fogColorRampScale
            {
                get { return GetTextureScale (Properties.fogColorRampKey); }
                set { SetTextureScale (Properties.fogColorRampKey, value); }
            }

            public Vector2 fogColorRampOffset
            {
                get { return GetTextureOffset (Properties.fogColorRampKey); }
                set { SetTextureOffset (Properties.fogColorRampKey, value); }
            }

            // PlanetOpacity, default = 1
            public float planetOpacity
            {
                get { return GetFloat (Properties.Instance.planetOpacityID); }
                set { SetFloat (Properties.Instance.planetOpacityID, value); }
            }

            public PQSMainExtras() : base(Properties.shader)
            {
            }

            [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.")]
            public PQSMainExtras(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public PQSMainExtras(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: Terrain/PQS/PQS Main - Optimised shader required");
            }

        }
    }
}
