using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using HarmonyLib;
using RimWorld;
using Verse;

namespace VanillaMemesExpanded
{
    public class VMEMod : Mod
    {
        public static Harmony Harm;

        public VMEMod(ModContentPack content) : base(content)
        {
            Harm = new Harmony("vanillaexpanded.ideology.memes");
            Harm.Patch(AccessTools.Method(typeof(Dialog_ChooseMemes), "DoNormalMemeSelector"), transpiler: new HarmonyMethod(GetType(), nameof(FixMemeList)));
        }

        public static IEnumerable<CodeInstruction> FixMemeList(IEnumerable<CodeInstruction> instructions)
        {
            var list = instructions.ToList();
            var idx1 = list.FindIndex(ins => ins.opcode == OpCodes.Ble_S);
            var labels = new List<Label>();
            foreach (var ins in list.GetRange(idx1 - 2, 9)) labels.AddRange(ins.labels);
            list.RemoveRange(idx1 - 2, 7);
            list[idx1].labels.AddRange(labels);
            return list;
        }
    }
}