using Verse;

namespace CuprosAlloys {

  internal class BauxiteItemSpawner : ItemSpawner {
    
    public override void SpawnSetup(Map map, bool respawningAfterLoad) {
      base.SpawnSetup(map, respawningAfterLoad);

      // Give a 5% chance to spawn quartz, if it exists
      if (Rand.Range(0, 100) < 5) {
        if (DefDatabase<ThingDef>.GetNamed("EXP_Quartz", false) != null) {
          SpawnRandomQuantity(ThingDef.Named("EXP_Quartz"), 1, 5);
        }
      }

      SpawnRandomQuantity(ThingDef.Named("CAL_Aluminum"), 15, 25);
      Destroy();
    }
  }
}
