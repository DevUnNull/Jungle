using UnityEngine;

public interface IUpgrade
{
    string Name { get; }
    string Description { get; }
    Sprite Icon { get; }
    void Apply(InformationPlayer player);
}

// --- Các lớp upgrade cụ thể ---
public class HealthUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    private int amount;

    public HealthUpgrade(string name, string desc, int amount, Sprite icon)
    {
        Name = name;
        Description = desc;
        this.amount = amount;
        Icon = icon;
    }

    public void Apply(InformationPlayer player)
    {
        player.health += amount;

        // Nếu có HealthPlayer trên cùng GameObject, cập nhật luôn thanh máu
        var healthPlayer = player.GetComponent<HealthPlayer>();
        if (healthPlayer != null)
        {
            healthPlayer.ResetHealthToFull(0.2f);
        }
    }
}

public class SpeedUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    private float multiplier;

    public SpeedUpgrade(string name, string desc, float multiplier, Sprite icon)
    {
        Name = name;
        Description = desc;
        this.multiplier = multiplier;
        Icon = icon;
    }

    public void Apply(InformationPlayer player)
    {
        player.moveSpeed *= multiplier;
    }
}

public class DamageUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    private int amount;

    public DamageUpgrade(string name, string desc, int amount, Sprite icon)
    {
        Name = name;
        Description = desc;
        this.amount = amount;
        Icon = icon;
    }

    public void Apply(InformationPlayer player)
    {
        player.damage += amount;
    }
}

public class AttackSpeedUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    private float multiplier;

    public AttackSpeedUpgrade(string name, string desc, float multiplier, Sprite icon)
    {
        Name = name;
        Description = desc;
        this.multiplier = multiplier;
        Icon = icon;
    }

    public void Apply(InformationPlayer player)
    {
        player.attackSpeed *= multiplier;
    }
}

public class CriticalChanceUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    private float addChance;

    public CriticalChanceUpgrade(string name, string desc, float addChance, Sprite icon)
    {
        Name = name;
        Description = desc;
        this.addChance = addChance;
        Icon = icon;
    }

    public void Apply(InformationPlayer player)
    {
        player.critChance += addChance;
    }
}

public class ShieldUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public Sprite Icon { get; }
    private int shieldValue;

    public ShieldUpgrade(string name, string desc, int shieldValue, Sprite icon)
    {
        Name = name;
        Description = desc;
        this.shieldValue = shieldValue;
        Icon = icon;
    }

    public void Apply(InformationPlayer player)
    {
        player.shield += shieldValue;
    }
}
