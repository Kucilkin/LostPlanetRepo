using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_SnakeBehaviour : MonoBehaviour
{
    protected float maxHP;
    protected float currHP;
    [SerializeField]
    protected float moveSpeed;
    protected float damage;

    protected Rigidbody2D rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        maxHP = 3f;
        currHP = maxHP;
        damage = 8f;
        
    }
    private void FixedUpdate()
    {
        Movement();
    }

    protected virtual void Movement()
    {
        rb.MovePosition(transform.position - transform.right * moveSpeed);
    }
}
