using HarmonyLib;
using RimWorld;
using Verse;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Reflection.Emit;



namespace VanillaMemesExpanded
{


	[HarmonyPatch(typeof(IdeoUIUtility))]
	[HarmonyPatch("DoPreceptsInt")]
	public static class VanillaMemesExpanded_IdeoUIUtility_DoPreceptsInt_Patch
	{
		static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
		{

			/*int instructionNumber = 0;
			var codes = new List<CodeInstruction>(instructions);
			for (int i = 0; i < codes.Count; i++)
			{
				CodeInstruction instruction = codes[i];
				if (codes[i].opcode == OpCodes.Ldloc_S && codes[i].operand is LocalBuilder lb && lb.LocalIndex == 16)
				{
					yield return instruction;
					yield return new CodeInstruction(OpCodes.Ldc_I4, 10);
					//ldc.i4.6 to ldc.i4.10
					instructionNumber = i;

				}
				else if(i!= instructionNumber + 1) { yield return instruction; }
					
                
				
			}*/
			var codes = instructions.ToList();
		
			for (var i = 0; i < codes.Count; i++)
			{
                
					var code = codes[i];
					if (i>0 && codes[i - 1].opcode == OpCodes.Ldloc_S && codes[i - 1].operand is LocalBuilder lb && lb.LocalIndex == 16)
					{


						yield return new CodeInstruction(OpCodes.Ldc_I4, 10);
					}
					else
					{
						yield return code;
					} 
				
				
			}


		}
	}
}