// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class PQSProjectionSurfaceQuadLoader : PQSProjectionSurfaceQuad
        {
            // Saturation, default = 1
            [ParserTarget("saturation")]
            public NumericParser<float> saturationSetter
            {
                get { return saturation; }
                set { saturation = value; }
            }

            // Contrast, default = 1
            [ParserTarget("contrast")]
            public NumericParser<float> contrastSetter
            {
                get { return contrast; }
                set { contrast = value; }
            }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            [ParserTarget("tintColor")]
            public ColorParser tintColorSetter
            {
                get { return tintColor; }
                set { tintColor = value; }
            }

            // Near Tiling, default = 1000
            [ParserTarget("texTiling")]
            public NumericParser<float> texTilingSetter
            {
                get { return texTiling; }
                set { texTiling = value; }
            }

            // Near Blend, default = 0.5
            [ParserTarget("texPower")]
            public NumericParser<float> texPowerSetter
            {
                get { return texPower; }
                set { texPower = value; }
            }

            // Far Blend, default = 0.5
            [ParserTarget("multiPower")]
            public NumericParser<float> multiPowerSetter
            {
                get { return multiPower; }
                set { multiPower = value; }
            }

            // NearFar Start, default = 2000
            [ParserTarget("groundTexStart")]
            public NumericParser<float> groundTexStartSetter
            {
                get { return groundTexStart; }
                set { groundTexStart = value; }
            }

            // NearFar Start, default = 10000
            [ParserTarget("groundTexEnd")]
            public NumericParser<float> groundTexEndSetter
            {
                get { return groundTexEnd; }
                set { groundTexEnd = value; }
            }

            // Steep Tiling, default = 1
            [ParserTarget("steepTiling")]
            public NumericParser<float> steepTilingSetter
            {
                get { return steepTiling; }
                set { steepTiling = value; }
            }

            // Steep Blend, default = 1
            [ParserTarget("steepPower")]
            public NumericParser<float> steepPowerSetter
            {
                get { return steepPower; }
                set { steepPower = value; }
            }

            // Steep Fade Start, default = 20000
            [ParserTarget("steepTexStart")]
            public NumericParser<float> steepTexStartSetter
            {
                get { return steepTexStart; }
                set { steepTexStart = value; }
            }

            // Steep Fade End, default = 30000
            [ParserTarget("steepTexEnd")]
            public NumericParser<float> steepTexEndSetter
            {
                get { return steepTexEnd; }
                set { steepTexEnd = value; }
            }

            // Deep ground, default = "white" { }
            [ParserTarget("deepTex")]
            public Texture2DParser deepTexSetter
            {
                get { return deepTex; }
                set { deepTex = value; }
            }

            [ParserTarget("deepTexScale")]
            private Vector2Parser deepTexScaleSetter
            {
                get { return deepTexScale; }
                set { deepTexScale = value; }
            }

            [ParserTarget("deepTexOffset")]
            private Vector2Parser deepTexOffsetSetter
            {
                get { return deepTexOffset; }
                set { deepTexOffset = value; }
            }

            // Deep MT, default = "white" { }
            [ParserTarget("deepMultiTex")]
            public Texture2DParser deepMultiTexSetter
            {
                get { return deepMultiTex; }
                set { deepMultiTex = value; }
            }

            [ParserTarget("deepMultiTexScale")]
            private Vector2Parser deepMultiTexScaleSetter
            {
                get { return deepMultiTexScale; }
                set { deepMultiTexScale = value; }
            }

            [ParserTarget("deepMultiTexOffset")]
            private Vector2Parser deepMultiTexOffsetSetter
            {
                get { return deepMultiTexOffset; }
                set { deepMultiTexOffset = value; }
            }

            // Deep MT Tiling, default = 1
            [ParserTarget("deepMultiFactor")]
            public NumericParser<float> deepMultiFactorSetter
            {
                get { return deepMultiFactor; }
                set { deepMultiFactor = value; }
            }

            // Main Texture, default = "white" { }
            [ParserTarget("mainTex")]
            public Texture2DParser mainTexSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            [ParserTarget("mainTexScale")]
            private Vector2Parser mainTexScaleSetter
            {
                get { return mainTexScale; }
                set { mainTexScale = value; }
            }

            [ParserTarget("mainTexOffset")]
            private Vector2Parser mainTexOffsetSetter
            {
                get { return mainTexOffset; }
                set { mainTexOffset = value; }
            }

            // Main MT, default = "white" { }
            [ParserTarget("mainMultiTex")]
            public Texture2DParser mainMultiTexSetter
            {
                get { return mainMultiTex; }
                set { mainMultiTex = value; }
            }

            [ParserTarget("mainMultiTexScale")]
            private Vector2Parser mainMultiTexScaleSetter
            {
                get { return mainMultiTexScale; }
                set { mainMultiTexScale = value; }
            }

            [ParserTarget("mainMultiTexOffset")]
            private Vector2Parser mainMultiTexOffsetSetter
            {
                get { return mainMultiTexOffset; }
                set { mainMultiTexOffset = value; }
            }

            // Main MT Tiling, default = 1
            [ParserTarget("mainMultiFactor")]
            public NumericParser<float> mainMultiFactorSetter
            {
                get { return mainMultiFactor; }
                set { mainMultiFactor = value; }
            }

            // High Ground, default = "white" { }
            [ParserTarget("highTex")]
            public Texture2DParser highTexSetter
            {
                get { return highTex; }
                set { highTex = value; }
            }

            [ParserTarget("highTexScale")]
            private Vector2Parser highTexScaleSetter
            {
                get { return highTexScale; }
                set { highTexScale = value; }
            }

            [ParserTarget("highTexOffset")]
            private Vector2Parser highTexOffsetSetter
            {
                get { return highTexOffset; }
                set { highTexOffset = value; }
            }

            // High MT, default = "white" { }
            [ParserTarget("highMultiTex")]
            public Texture2DParser highMultiTexSetter
            {
                get { return highMultiTex; }
                set { highMultiTex = value; }
            }

            [ParserTarget("highMultiTexScale")]
            private Vector2Parser highMultiTexScaleSetter
            {
                get { return highMultiTexScale; }
                set { highMultiTexScale = value; }
            }

            [ParserTarget("highMultiTexOffset")]
            private Vector2Parser highMultiTexOffsetSetter
            {
                get { return highMultiTexOffset; }
                set { highMultiTexOffset = value; }
            }

            // High MT Tiling, default = 1
            [ParserTarget("highMultiFactor")]
            public NumericParser<float> highMultiFactorSetter
            {
                get { return highMultiFactor; }
                set { highMultiFactor = value; }
            }

            // Snow, default = "white" { }
            [ParserTarget("snowTex")]
            public Texture2DParser snowTexSetter
            {
                get { return snowTex; }
                set { snowTex = value; }
            }

            [ParserTarget("snowTexScale")]
            private Vector2Parser snowTexScaleSetter
            {
                get { return snowTexScale; }
                set { snowTexScale = value; }
            }

            [ParserTarget("snowTexOffset")]
            private Vector2Parser snowTexOffsetSetter
            {
                get { return snowTexOffset; }
                set { snowTexOffset = value; }
            }

            // Snow MT, default = "white" { }
            [ParserTarget("snowMultiTex")]
            public Texture2DParser snowMultiTexSetter
            {
                get { return snowMultiTex; }
                set { snowMultiTex = value; }
            }

            [ParserTarget("snowMultiTexScale")]
            private Vector2Parser snowMultiTexScaleSetter
            {
                get { return snowMultiTexScale; }
                set { snowMultiTexScale = value; }
            }

            [ParserTarget("snowMultiTexOffset")]
            private Vector2Parser snowMultiTexOffsetSetter
            {
                get { return snowMultiTexOffset; }
                set { snowMultiTexOffset = value; }
            }

            // Snow MT Tiling, default = 1
            [ParserTarget("snowMultiFactor")]
            public NumericParser<float> snowMultiFactorSetter
            {
                get { return snowMultiFactor; }
                set { snowMultiFactor = value; }
            }

            // Steep Texture, default = "white" { }
            [ParserTarget("steepTex")]
            public Texture2DParser steepTexSetter
            {
                get { return steepTex; }
                set { steepTex = value; }
            }

            [ParserTarget("steepTexScale")]
            private Vector2Parser steepTexScaleSetter
            {
                get { return steepTexScale; }
                set { steepTexScale = value; }
            }

            [ParserTarget("steepTexOffset")]
            private Vector2Parser steepTexOffsetSetter
            {
                get { return steepTexOffset; }
                set { steepTexOffset = value; }
            }

            // Deep Start, default = 0
            [ParserTarget("deepStart")]
            public NumericParser<float> deepStartSetter
            {
                get { return deepStart; }
                set { deepStart = value; }
            }

            // Deep End, default = 0.3
            [ParserTarget("deepEnd")]
            public NumericParser<float> deepEndSetter
            {
                get { return deepEnd; }
                set { deepEnd = value; }
            }

            // Main lower boundary start, default = 0
            [ParserTarget("mainLoStart")]
            public NumericParser<float> mainLoStartSetter
            {
                get { return mainLoStart; }
                set { mainLoStart = value; }
            }

            // Main lower boundary end, default = 0.5
            [ParserTarget("mainLoEnd")]
            public NumericParser<float> mainLoEndSetter
            {
                get { return mainLoEnd; }
                set { mainLoEnd = value; }
            }

            // Main upper boundary start, default = 0.3
            [ParserTarget("mainHiStart")]
            public NumericParser<float> mainHiStartSetter
            {
                get { return mainHiStart; }
                set { mainHiStart = value; }
            }

            // Main upper boundary end, default = 0.5
            [ParserTarget("mainHiEnd")]
            public NumericParser<float> mainHiEndSetter
            {
                get { return mainHiEnd; }
                set { mainHiEnd = value; }
            }

            // High lower boundary start, default = 0.6
            [ParserTarget("hiLoStart")]
            public NumericParser<float> hiLoStartSetter
            {
                get { return hiLoStart; }
                set { hiLoStart = value; }
            }

            // High lower boundary end, default = 0.6
            [ParserTarget("hiLoEnd")]
            public NumericParser<float> hiLoEndSetter
            {
                get { return hiLoEnd; }
                set { hiLoEnd = value; }
            }

            // High upper boundary start, default = 0.6
            [ParserTarget("hiHiStart")]
            public NumericParser<float> hiHiStartSetter
            {
                get { return hiHiStart; }
                set { hiHiStart = value; }
            }

            // High upper boundary end, default = 0.9
            [ParserTarget("hiHiEnd")]
            public NumericParser<float> hiHiEndSetter
            {
                get { return hiHiEnd; }
                set { hiHiEnd = value; }
            }

            // Snow Start, default = 0.9
            [ParserTarget("snowStart")]
            public NumericParser<float> snowStartSetter
            {
                get { return snowStart; }
                set { snowStart = value; }
            }

            // Snow End, default = 1
            [ParserTarget("snowEnd")]
            public NumericParser<float> snowEndSetter
            {
                get { return snowEnd; }
                set { snowEnd = value; }
            }

            // PlanetOpacity, default = 1
            [ParserTarget("planetOpacity")]
            public NumericParser<float> planetOpacitySetter
            {
                get { return planetOpacity; }
                set { planetOpacity = value; }
            }

            // Constructors
            public PQSProjectionSurfaceQuadLoader () : base() { }
            [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.")]
            public PQSProjectionSurfaceQuadLoader (string contents) : base (contents) { }
            public PQSProjectionSurfaceQuadLoader (Material material) : base(material) { }
        }
    }
}
