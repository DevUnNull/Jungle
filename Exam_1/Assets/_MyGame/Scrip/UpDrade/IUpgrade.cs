using UnityEngine;

public interface IUpgrade
{
    string Name { get; }
    string Description { get; }
    void Apply(InformationPlayer player);
}

// --- Các lớp upgrade cụ thể ---
public class HealthUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    private int amount;

    public HealthUpgrade(string name, string desc, int amount)
    {
        Name = name;
        Description = desc;
        this.amount = amount;
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
    private float amount;

    public SpeedUpgrade(string name, string desc, float amount)
    {
        Name = name;
        Description = desc;
        this.amount = amount;
    }

    public void Apply(InformationPlayer player)
    {
        player.moveSpeed += amount;
    }
}

public class DamageUpgrade : IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    private float amount;

    public DamageUpgrade(string name, string desc, float amount)
    {
        Name = name;
        Description = desc;
        this.amount = amount;
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
    private float multiplier;

    public AttackSpeedUpgrade(string name, string desc, float multiplier)
    {
        Name = name;
        Description = desc;
        this.multiplier = multiplier;
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
    private float addChance;

    public CriticalChanceUpgrade(string name, string desc, float addChance)
    {
        Name = name;
        Description = desc;
        this.addChance = addChance;
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
    private int shieldValue;

    public ShieldUpgrade(string name, string desc, int shieldValue)
    {
        Name = name;
        Description = desc;
        this.shieldValue = shieldValue;
    }

    public void Apply(InformationPlayer player)
    {
        player.shield += shieldValue;
    }
}
