using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeUI : MonoBehaviour
{
    [System.Serializable]
    public class UpgradeButton
    {
        [Header("Thành phần nút nâng cấp")]
        public Button button;
        public TextMeshProUGUI titleText;
        public TextMeshProUGUI descText;
    }

    [Header("Danh sách 3 nút nâng cấp hiển thị trên UI")]
    public UpgradeButton[] upgradeButtons;

    [Header("Tham chiếu hệ thống")]
    public UpgradeManager upgradeManager;
    public InformationPlayer player;
    public LevelUp levelUp; // ✅ Báo ngược về LevelUp khi chọn xong

    private List<IUpgrade> currentOptions = new List<IUpgrade>();

    void Start()
    {
        // Ẩn panel lúc đầu
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Khởi tạo tham chiếu từ LevelUp
    /// </summary>
    public void Init(UpgradeManager manager, InformationPlayer playerStats)
    {
        upgradeManager = manager;
        player = playerStats;
    }

    /// <summary>
    /// Hiển thị 3 lựa chọn nâng cấp ngẫu nhiên
    /// </summary>
    public void ShowUpgrades()
    {
        if (upgradeManager == null || player == null)
        {
            Debug.LogWarning("⚠️ UpgradeUI chưa được khởi tạo đúng (thiếu UpgradeManager hoặc PlayerStats).");
            return;
        }

        // Dừng thời gian trong khi người chơi chọn nâng cấp
        Time.timeScale = 0f;

        currentOptions = upgradeManager.GetRandomUpgrades(3);

        for (int i = 0; i < upgradeButtons.Length; i++)
        {
            var ui = upgradeButtons[i];

            if (i < currentOptions.Count)
            {
                var upgrade = currentOptions[i];
                ui.titleText.text = upgrade.Name;
                ui.descText.text = upgrade.Description;

                ui.button.onClick.RemoveAllListeners();

                int index = i; // Tránh lỗi closure
                ui.button.onClick.AddListener(() => OnUpgradeSelected(index));

                ui.button.gameObject.SetActive(true);
            }
            else
            {
                ui.button.gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// Khi người chơi chọn một nâng cấp
    /// </summary>
    private void OnUpgradeSelected(int index)
    {
        if (currentOptions == null || index >= currentOptions.Count)
        {
            Debug.LogError("❌ Index nâng cấp không hợp lệ!");
            return;
        }

        var selected = currentOptions[index];

        // Áp dụng nâng cấp
        selected.Apply(player);

        Debug.Log($"🆙 Người chơi đã chọn nâng cấp: {selected.Name}");

        // Đóng panel và resume game
        Time.timeScale = 1f;
        gameObject.SetActive(false);

        // Báo ngược về LevelUp để reset trạng thái
        if (levelUp != null)
            levelUp.OnUpgradeChosen();
    }

    /// <summary>
    /// Xóa listeners khi panel tắt (tránh lỗi memory leak)
    /// </summary>
    private void OnDisable()
    {
        foreach (var ui in upgradeButtons)
        {
            if (ui.button != null)
                ui.button.onClick.RemoveAllListeners();
        }
    }
}
