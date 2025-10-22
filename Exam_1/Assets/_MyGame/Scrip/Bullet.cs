using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 2f;
    private Rigidbody2D rb;
    public int diem;

    public int minDamage =4;
    public int maxDamage;
    InformationPlayer player;
    Enemy enemyS;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<InformationPlayer>();
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;
        Destroy(gameObject, lifeTime);
        maxDamage = player.damage;
        Debug.Log(maxDamage);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            enemyS = collision.GetComponent<Enemy>();
            InvokeRepeating("DamageEnemy", 0, 0.1f);
            Destroy(gameObject);  
        }
    }

    void DamageEnemy()
    {
        int dame = UnityEngine.Random.Range(minDamage, maxDamage);
        enemyS.TakeDamageEnemy(dame); 
    }

}
