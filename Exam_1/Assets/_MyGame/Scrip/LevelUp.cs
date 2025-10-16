using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    [Header("⚙️ Cấu hình EXP & Level")]
    [SerializeField] private int expMax = 10;
    [SerializeField] private int currentExp = 0;
    [SerializeField] private int currentLevel = 1;

    [Header("🧩 Tham chiếu hệ thống")]
    public UpgradeManager upgradeManager;
    public UpgradeUI upgradeUI;
    public InformationPlayer playerStats;
    public HealthBar levelBar;

    private bool isChoosingUpgrade = false;

    void Start()
    {
        currentExp = 0;

        // Cập nhật UI level bar
        if (levelBar != null)
        {
            levelBar.UpdateLevel(currentLevel);
            levelBar.UpdateBar(currentExp, expMax);
        }

        // Khởi tạo UpgradeUI
        if (upgradeUI != null && upgradeManager != null && playerStats != null)
        {
            upgradeUI.Init(upgradeManager, playerStats);
            upgradeUI.levelUp = this; // ✅ Gán tham chiếu ngược
        }
        else
        {
            Debug.LogWarning("⚠️ LevelUp: Chưa gán đầy đủ UpgradeUI / UpgradeManager / PlayerStats!");
        }
    }

    void Update()
    {
        // Dành cho test – nhấn T để nhận 1 EXP
        if (Input.GetKeyUp(KeyCode.T))
        {
            AddExp(1);
        }

        // Nếu đủ EXP và chưa mở UI
        if (currentExp >= expMax && !isChoosingUpgrade)
        {
            HandleLevelUp();
        }
    }

    /// <summary>
    /// Cộng thêm EXP
    /// </summary>
    public void AddExp(int value)
    {
        currentExp += value;
        currentExp = Mathf.Min(currentExp, expMax); // Giới hạn không vượt quá

        if (levelBar != null)
        {
            levelBar.UpdateBar(currentExp, expMax);
        }
    }

    /// <summary>
    /// Xử lý khi đủ EXP để lên cấp
    /// </summary>
    private void HandleLevelUp()
    {
        currentLevel++;
        currentExp = 0;
        isChoosingUpgrade = true;

        if (levelBar != null)
        {
            levelBar.UpdateLevel(currentLevel);
            levelBar.UpdateBar(currentExp, expMax);
        }

        // Hiển thị UI chọn nâng cấp
        if (upgradeUI != null)
        {
            upgradeUI.gameObject.SetActive(true);
            upgradeUI.ShowUpgrades();
        }
        else
        {
            Debug.LogWarning("⚠️ LevelUp: UpgradeUI chưa được gán!");
        }
    }

    /// <summary>
    /// Gọi khi người chơi chọn xong nâng cấp
    /// </summary>
    public void OnUpgradeChosen()
    {
        isChoosingUpgrade = false;
        Debug.Log("✅ LevelUp: Người chơi đã chọn xong nâng cấp, tiếp tục game.");
    }

    // ---------------------------
    // Ví dụ buff test (nếu bạn muốn dùng)
    // ---------------------------

    public void StrongBullet()
    {
        Move strongBullet = GetComponent<Move>();
        if (strongBullet != null)
            strongBullet.strongBullet = currentLevel;
    }

    public void SpeedBullet()
    {
        Move moveScript = GetComponent<Move>();
        if (moveScript != null)
            moveScript.diem = currentLevel;
    }
}
