using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeData", menuName = "Game/Upgrade Data")]
public class UpgradeData : ScriptableObject
{
    public string upgradeType; // Ví dụ: "Health", "Speed", ...
    public string upgradeName;
    [TextArea] public string description;

    public int value; // giá trị nâng cấp
}
