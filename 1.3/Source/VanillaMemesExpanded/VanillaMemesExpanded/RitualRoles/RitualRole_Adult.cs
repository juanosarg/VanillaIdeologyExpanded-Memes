using System;
using System.Collections.Generic;
using System.Linq;
using Verse;
using RimWorld;

namespace VanillaMemesExpanded 
{ 

	
	public class RitualRole_Adult : RitualRole
	{
        public override bool AppliesToPawn(Pawn p, out string reason, LordJob_Ritual ritual = null, RitualRoleAssignments assignments = null, Precept_Ritual precept = null, bool skipReason = false)
        {
			reason = null;
			if (p.ageTracker.AgeBiologicalYears>18)
			{
				return true;
			}
			else
			{
				reason = "VME_PawnMustBeAnAdult".Translate(p);
				return false;
			}
		}

        public override bool AppliesToRole(Precept_Role role, out string reason, Precept_Ritual ritual = null, Pawn pawn = null, bool skipReason = false)
        {
            throw new NotImplementedException();
        }



    }
}
