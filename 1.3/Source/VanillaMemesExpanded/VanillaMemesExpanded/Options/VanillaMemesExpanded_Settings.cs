using RimWorld;
using UnityEngine;
using Verse;


namespace VanillaMemesExpanded
{


    public class VanillaMemesExpanded_Settings : ModSettings

    {


        public static bool flagAllowMoreMemes = false;
    


        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref flagAllowMoreMemes, "flagAllowMoreMemes", true, true);
          


        }

        public static void DoWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();


            ls.Begin(inRect);
          
            ls.CheckboxLabeled("VME_AllowUpToSixMemes".Translate(), ref flagAllowMoreMemes, null);
            ls.Gap(12f);
         


            ls.End();
        }



    }










}
