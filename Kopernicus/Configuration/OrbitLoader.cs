/** 
 * Kopernicus Planetary System Modifier
 * Copyright (C) 2014 Bryce C Schroeder (bryce.schroeder@gmail.com), Nathaniel R. Lewis (linux.robotdude@gmail.com)
 * 
 * http://www.ferazelhosting.net/~bryce/contact.html
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2014 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace Kopernicus
{
	namespace Configuration
	{
		[RequireConfigType(ConfigType.Node)]
		public class OrbitLoader
		{
			// KSP orbit object we are editing
			public Orbit orbit { get; private set ; }

			// Orbit renderer color
			[ParserTarget("color", optional = true, allowMerge = false)]
			public ColorParser color = new ColorParser();

			// Reference body to orbit
			[ParserTarget("referenceBody", optional = true, allowMerge = false)]
			public string referenceBody = null;

			[ParserTarget("inclination", optional = true, allowMerge = false)]
			public NumericParser<double> inclination 
			{
				set { orbit.inclination = value.value; }
			}
			
			[ParserTarget("eccentricity", optional = true, allowMerge = false)]
			public NumericParser<double> eccentricity
			{
				set { orbit.eccentricity = value.value; }
			}

			[ParserTarget("semiMajorAxis", optional = true, allowMerge = false)]
			public NumericParser<double> semiMajorAxis
			{
				set { orbit.semiMajorAxis = value.value; }
			}

			[ParserTarget("longitudeOfAscendingNode", optional = true, allowMerge = false)]
			public NumericParser<double> longitudeOfAscendingNode
			{
				set { orbit.LAN = value.value; }
			}

			// See: http://en.wikipedia.org/wiki/Argument_of_periapsis#mediaviewer/File:Orbit1.svg
			[ParserTarget("argumentOfPeriapsis", optional = true, allowMerge = false)]
			public NumericParser<double> argumentOfPeriapsis
			{
				set { orbit.argumentOfPeriapsis = value.value; }
			}

			[ParserTarget("meanAnomalyAtEpoch", optional = true, allowMerge = false)]
			public NumericParser<double> meanAnomalyAtEpoch
			{
				set { orbit.meanAnomalyAtEpoch = value.value; }
			}

			[ParserTarget("epoch", optional = true, allowMerge = false)]
			public NumericParser<double> epoch
			{
				set { orbit.epoch = value.value; }
			}

			// Construct an empty orbit
			public OrbitLoader ()
			{
				orbit = new Orbit();

			}

			// Copy orbit provided
			public OrbitLoader (Orbit orbit, Color color)
			{
				this.orbit = orbit;
				this.color.value = color;
			}
		}
	}
}
