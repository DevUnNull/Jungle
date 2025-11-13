using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InfomationUiManager : MonoBehaviour
{
    InformationPlayer informationPlayer;

    [SerializeField] TextMeshProUGUI infoDamege;
    [SerializeField] TextMeshProUGUI infoHealth;
    [SerializeField] TextMeshProUGUI infoMoveSpeed;
    [SerializeField] TextMeshProUGUI infoAttackSpeed;

    [SerializeField] TextMeshProUGUI infoCritChance;
    [SerializeField] TextMeshProUGUI infoShield;

    public int health;
    public float moveSpeed;
    public int damage;
    public float attackSpeed;
    public float critChance;
    public int shield;
    public void Start()
    {
        informationPlayer = FindObjectOfType<InformationPlayer>();
    }

    public void Update()
    {
        health = informationPlayer.health;
        moveSpeed = informationPlayer.moveSpeed;
        damage = informationPlayer.damage;
        attackSpeed = informationPlayer.attackSpeed;
        critChance = informationPlayer.critChance;
        shield = informationPlayer.shield;

        infoDamege.text = damage.ToString();
        infoHealth.text = health.ToString();
        infoMoveSpeed.text = moveSpeed.ToString();
        infoAttackSpeed.text = attackSpeed.ToString("F2") + "s";
        infoCritChance.text = (critChance * 100).ToString("F1") + "%";
        infoShield.text =  shield.ToString();
    }

}
