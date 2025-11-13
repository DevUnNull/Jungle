using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private List<UpgradeData> allUpgradeData;

    public List<IUpgrade> GetRandomUpgrades(int count)
    {
        var chosen = allUpgradeData
            .OrderBy(x => Random.value)
            .Take(count)
            .Select(data => UpgradeFactory.Create(data))
            .Where(u => u != null)
            .ToList();

        return chosen;
    }

    public void ApplyUpgrade(IUpgrade upgrade, InformationPlayer player)
    {
        upgrade.Apply(player);
        Debug.Log($"Applied upgrade: {upgrade.Name}");
    }
}
