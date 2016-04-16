﻿/**
 * Kopernicus Planetary System Modifier
 * ====================================
 * Created by: BryceSchroeder and Teknoman117 (aka. Nathaniel R. Lewis)
 * Maintained by: Thomas P., NathanKell and KillAshley
 * Additional Content by: Gravitasi, aftokino, KCreator, Padishar, Kragrathea, OvenProofMars, zengei, MrHappyFace
 * ------------------------------------------------------------- 
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
 * which is copyright 2011-2015 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

namespace Kopernicus
{
    public class AFGInfo
    {
        public static Dictionary<string, AFGInfo> atmospheres = new Dictionary<string, AFGInfo>();


        bool DEBUG_alwaysUpdateAll;
        bool doScale;
        float outerRadius;
        float innerRadius;
        float ESun;
        float Kr;
        float Km;
        Vector3 transformScale;
        float scaleDepth;
        float samples;
        float g;
        Color waveLength;
        Color invWaveLength;

        public static bool StoreAFG(AtmosphereFromGround afg)
        {
            if (afg.planet == null)
            {
                Debug.Log("[Kopernicus]: Trying to store AFG, but planet null!");
                return false;
            }
            atmospheres[afg.planet.bodyName] = new AFGInfo(afg);
            return true;
        }

        public static bool UpdateAFGName(string oName, string nName)
        {
            AFGInfo info = null;
            if (atmospheres.TryGetValue(oName, out info))
            {
                atmospheres.Remove(oName);
                atmospheres[nName] = info;
                return true;
            }
            return false;
        }

        public static bool PatchAFG(AtmosphereFromGround afg)
        {
            AFGInfo info = null;
            if (atmospheres.TryGetValue(afg.planet.bodyName, out info))
            {
                try
                {
                    info.Apply(afg);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public AFGInfo(AtmosphereFromGround afg)
        {
            DEBUG_alwaysUpdateAll = afg.DEBUG_alwaysUpdateAll;
            doScale = afg.doScale;
            ESun = afg.ESun;
            Kr = afg.Kr;
            Km = afg.Km;
            transformScale = afg.transform.localScale;
            scaleDepth = afg.scaleDepth;
            samples = afg.samples;
            g = afg.g;
            waveLength = afg.waveLength;
            invWaveLength = afg.invWaveLength;
            outerRadius = afg.outerRadius;
            innerRadius = afg.innerRadius;
        }
        public void Apply(AtmosphereFromGround afg)
        {
            afg.DEBUG_alwaysUpdateAll = DEBUG_alwaysUpdateAll;
            afg.doScale = doScale;
            afg.ESun = ESun;
            afg.Kr = Kr;
            afg.Km = Km;
            afg.transform.localScale = transformScale;
            afg.scaleDepth = scaleDepth;
            afg.samples = samples;
            afg.g = g;
            afg.waveLength = waveLength;
            afg.invWaveLength = invWaveLength;
            afg.outerRadius = outerRadius;
            afg.innerRadius = innerRadius;
            afg.transform.localPosition = Vector3.zero;

            Configuration.AtmosphereFromGroundLoader.CalculatedMembers(afg);
            afg.SetMaterial(true);
        }
    }
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    public class AtmosphereFixer : MonoBehaviour
    {
        double timeCounter = 0d;
        void Awake()
        {
            if (!CompatibilityChecker.IsCompatible())
            {
                Destroy(this);
                return;
            }
        }
        public void Start()
        {
            if (HighLogic.LoadedSceneIsFlight || HighLogic.LoadedScene == GameScenes.SPACECENTER)
            {
                return;
            }
            UnityEngine.Object.Destroy(this); // don't hang around.
        }
        public void Update()
        {
            if (timeCounter < 0.5d)
            {
                timeCounter += Time.deltaTime;
                return;
            }
            foreach (AtmosphereFromGround afg in Resources.FindObjectsOfTypeAll<AtmosphereFromGround>())
            {
                if (afg.planet != null)
                {
                    //Debug.Log("[Kopernicus]: Patching AFG " + afg.planet.bodyName);
                    //if (!AFGInfo.PatchAFG(afg))
                    //    Debug.Log("[Kopernicus]: ERROR AtmosphereFixer => Couldn't patch AtmosphereFromGround for " + afg.planet.bodyName + "!");
                    if (AFGInfo.PatchAFG(afg))
                        Debug.Log("[Kopernicus]: AtmosphereFixer => Patched AtmosphereFromGround for " + afg.planet.bodyName);
                }
            }
            UnityEngine.Object.Destroy(this); // don't hang around.
        }
    }
}