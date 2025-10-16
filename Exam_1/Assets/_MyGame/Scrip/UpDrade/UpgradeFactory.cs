using System;
using UnityEngine;

public static class UpgradeFactory 
{
    public static IUpgrade Create(UpgradeData data)
    {
        switch (data.upgradeType)
        {
            case "Health":

                return new HealthUpgrade(data.upgradeName, data.description, data.value);
            case "Speed":
                return new SpeedUpgrade(data.upgradeName, data.description, data.value);
            case "Damage":
                return new DamageUpgrade(data.upgradeName, data.description, data.value);
            case "AttackSpeed":
                return new AttackSpeedUpgrade(data.upgradeName, data.description, data.value);
            case "CriticalChance":
                return new CriticalChanceUpgrade(data.upgradeName, data.description, data.value);
            case "Shield":
                return new ShieldUpgrade(data.upgradeName, data.description, data.value);
            default:
                Debug.LogWarning($"Unknown upgrade type: {data.upgradeType}");
                return null;
        }
    }
}
