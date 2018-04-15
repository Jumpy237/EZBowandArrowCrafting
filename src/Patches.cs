using Harmony;
using UnityEngine;
using System.IO;

namespace EZBowandArrowCrafting
{
    [HarmonyPatch(typeof(BlueprintItem), "Start")]
    internal class BluePrintItem_Start
    {
        
        private static void Postfix(BlueprintItem __instance)
        {
            if (__instance.m_CraftedResult.name == "GEAR_ArrowHead")
            {
                GameObject gameObject = Resources.Load("GEAR_Stone") as GameObject;
                GearItem requiredItem = gameObject.GetComponent<GearItem>();
                __instance.m_RequiredGear = new GearItem[1];
                __instance.m_RequiredGear[0] = requiredItem;
                __instance.m_RequiresForge = false;
                __instance.m_RequiredTool = null;
                __instance.m_DurationMinutes = 30;
            }
            
            else if(__instance.m_CraftedResult.name == "GEAR_ArrowShaft")
            {
                GameObject gameObject = Resources.Load("GEAR_Stick") as GameObject;
                GearItem gearItem = gameObject.GetComponent<GearItem>();
                __instance.m_RequiredGear = new GearItem[1];
                __instance.m_RequiredGear[0] = gearItem;
                __instance.m_RequiredGearUnits[0] = 2;
                __instance.m_DurationMinutes = 10;
                __instance.m_RequiredTool = null;
                __instance.m_RequiresForge = false;
                __instance.m_RequiresWorkbench = false;
            }
            else if (__instance.m_CraftedResult.name == "GEAR_Arrow")
            {
                GameObject gameObject1 = Resources.Load("GEAR_ArrowShaft") as GameObject;
                GameObject gameObject2 = Resources.Load("GEAR_ArrowHead") as GameObject;
                GearItem gearItem1 = gameObject1.GetComponent<GearItem>();
                GearItem gearItem2 = gameObject2.GetComponent<GearItem>();
                __instance.m_RequiredGear = new GearItem[2];
                __instance.m_RequiredGear[0] = gearItem1;
                __instance.m_RequiredGear[1] = gearItem2;
                __instance.m_RequiredGearUnits[0] = 1;
                __instance.m_RequiredGearUnits[1] = 1;
                __instance.m_DurationMinutes = 30;
                __instance.m_RequiredTool = null;
                __instance.m_RequiresForge = false;
                __instance.m_RequiresWorkbench = false;
            }
            else if(__instance.m_CraftedResult.name == "GEAR_Bow")
            {
                GameObject gameObject1 = Resources.Load("GEAR_Stick") as GameObject;
                GameObject gameObject2 = Resources.Load("GEAR_Cloth") as GameObject;
                GearItem gearItem1 = gameObject1.GetComponent<GearItem>();
                GearItem gearItem2 = gameObject2.GetComponent<GearItem>();
                __instance.m_RequiredGear = new GearItem[2];
                __instance.m_RequiredGear[0] = gearItem1;
                __instance.m_RequiredGear[1] = gearItem2;
                __instance.m_RequiredGearUnits[0] = 2;
                __instance.m_RequiredGearUnits[1] = 1;
                __instance.m_DurationMinutes = 60;
                __instance.m_RequiredTool = null;
                __instance.m_RequiresForge = false;
                __instance.m_RequiresWorkbench = false;
            }
            else
            {
                return;
            }
        }
    }
}
