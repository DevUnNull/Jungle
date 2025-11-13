using System;
using UnityEngine;

public static class UpgradeFactory 
{
    public static IUpgrade Create(UpgradeData data)
    {
        switch (data.upgradeType)
        {
            case "Health":
                return new HealthUpgrade(data.upgradeName, data.description, data.value, data.icon);
            case "Speed":
                // Chuyển đổi value (phần trăm) thành multiplier
                // Ví dụ: value = 5 → multiplier = 1.05 (tăng 5% tốc độ di chuyển)
                float speedMultiplier = 1f + (data.value / 100f);
                return new SpeedUpgrade(data.upgradeName, data.description, speedMultiplier, data.icon);
            case "Damage":
                return new DamageUpgrade(data.upgradeName, data.description, data.value, data.icon);
            case "AttackSpeed":
                // Chuyển đổi value (phần trăm) thành multiplier
                // Ví dụ: value = 20 → multiplier = 1.2 (tăng 20% tốc độ bắn)
                float attackSpeedMultiplier = 1f + (data.value / 100f);
                return new AttackSpeedUpgrade(data.upgradeName, data.description, attackSpeedMultiplier, data.icon);
            case "CriticalChance":
                return new CriticalChanceUpgrade(data.upgradeName, data.description, data.value, data.icon);
            case "Shield":
                return new ShieldUpgrade(data.upgradeName, data.description, data.value, data.icon);
            default:
                Debug.LogWarning($"Unknown upgrade type: {data.upgradeType}");
                return null;
        }
    }
}
