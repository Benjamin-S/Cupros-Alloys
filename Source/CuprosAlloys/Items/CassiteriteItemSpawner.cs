using Verse;

namespace CuprosAlloys {

  internal class CassiteriteItemSpawner : ItemSpawner {

    public override void SpawnSetup(Map map, bool respawningAfterLoad) {
      base.SpawnSetup(map, respawningAfterLoad);

      SpawnRandomQuantity(ThingDef.Named("EXP_Tin"), 20, 35);
      Destroy();
    }
  }
}
