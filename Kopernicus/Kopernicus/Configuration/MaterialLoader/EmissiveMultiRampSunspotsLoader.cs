// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class EmissiveMultiRampSunspotsLoader : EmissiveMultiRampSunspots
        {
            // Ramp Map (RGBA), default = "white" { }
            [ParserTarget("rampMap")]
            public Texture2DParser rampMapSetter
            {
                get { return rampMap; }
                set { rampMap = value; }
            }

            [ParserTarget("rampMapScale")]
            private Vector2Parser rampMapScaleSetter
            {
                get { return rampMapScale; }
                set { rampMapScale = value; }
            }

            [ParserTarget("rampMapOffset")]
            private Vector2Parser rampMapOffsetSetter
            {
                get { return rampMapOffset; }
                set { rampMapOffset = value; }
            }

            // Noise Map (RGBA), default = "white" { }
            [ParserTarget("noiseMap")]
            public Texture2DParser noiseMapSetter
            {
                get { return noiseMap; }
                set { noiseMap = value; }
            }

            [ParserTarget("noiseMapScale")]
            private Vector2Parser noiseMapScaleSetter
            {
                get { return noiseMapScale; }
                set { noiseMapScale = value; }
            }

            [ParserTarget("noiseMapOffset")]
            private Vector2Parser noiseMapOffsetSetter
            {
                get { return noiseMapOffset; }
                set { noiseMapOffset = value; }
            }

            // Emission Color 0, default = (1,1,1,1)
            [ParserTarget("emitColor0")]
            public ColorParser emitColor0Setter
            {
                get { return emitColor0; }
                set { emitColor0 = value; }
            }

            // Emission Color 1, default = (1,1,1,1)
            [ParserTarget("emitColor1")]
            public ColorParser emitColor1Setter
            {
                get { return emitColor1; }
                set { emitColor1 = value; }
            }

            // Sunspot Map (R), default = "white" { }
            [ParserTarget("sunspotTex")]
            public Texture2DParser sunspotTexSetter
            {
                get { return sunspotTex; }
                set { sunspotTex = value; }
            }

            [ParserTarget("sunspotTexScale")]
            private Vector2Parser sunspotTexScaleSetter
            {
                get { return sunspotTexScale; }
                set { sunspotTexScale = value; }
            }

            [ParserTarget("sunspotTexOffset")]
            private Vector2Parser sunspotTexOffsetSetter
            {
                get { return sunspotTexOffset; }
                set { sunspotTexOffset = value; }
            }

            // Sunspot Power, default = 1
            [ParserTarget("sunspotPower")]
            public NumericParser<float> sunspotPowerSetter
            {
                get { return sunspotPower; }
                set { sunspotPower = value; }
            }

            // Sunspot Color, default = (0,0,0,0)
            [ParserTarget("sunspotColor")]
            public ColorParser sunspotColorSetter
            {
                get { return sunspotColor; }
                set { sunspotColor = value; }
            }

            // Rimlight Color, default = (1,1,1,1)
            [ParserTarget("rimColor")]
            public ColorParser rimColorSetter
            {
                get { return rimColor; }
                set { rimColor = value; }
            }

            // Rimlight Power, default = 0.2
            [ParserTarget("rimPower")]
            public NumericParser<float> rimPowerSetter
            {
                get { return rimPower; }
                set { rimPower = value; }
            }

            // Rimlight Blend, default = 0.2
            [ParserTarget("rimBlend")]
            public NumericParser<float> rimBlendSetter
            {
                get { return rimBlend; }
                set { rimBlend = value; }
            }

            // Constructors
            public EmissiveMultiRampSunspotsLoader () : base() { }
            [Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.")]
            public EmissiveMultiRampSunspotsLoader (string contents) : base (contents) { }
            public EmissiveMultiRampSunspotsLoader (Material material) : base(material) { }
        }
    }
}
