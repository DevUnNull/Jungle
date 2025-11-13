using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Events;

public class HealthPlayer : MonoBehaviour
{
    public InformationPlayer InformationPlayer;

    public int currentHealth;

    public HealthBar healthBar;

    public UnityEvent onDeath;

    
    private void OnEnable() // khi gọi inDeath thì nó sẽ gọi những cái gì có trong OnEnable
    {
        onDeath.AddListener(Death);
        InformationPlayer = GetComponent<InformationPlayer>();
    }

    private void Start()
    {
        currentHealth = InformationPlayer.health;

        healthBar.UpdateBar(currentHealth, InformationPlayer.health);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            onDeath.Invoke();
            _AudioManager.Instance.PlaySoundEffectMusic(_AudioManager.Instance.Dead);
        }

        healthBar.UpdateBar(currentHealth, InformationPlayer.health);
    }
    public void Death()
    {
        Destroy(gameObject);
        GameManager.instance.EnemySkillPlayer();
    }
    public void ResetHealthToFull(float healPercent)
    {
        int healAmount = Mathf.RoundToInt(InformationPlayer.health * healPercent);
        currentHealth = Mathf.Min(currentHealth + healAmount, InformationPlayer.health);

        healthBar.UpdateBar(currentHealth, InformationPlayer.health);
    }


}
