using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float health;
    public bool isLive;

    Rigidbody2D rigid;
    SpriteRenderer spriter;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() // 물리적인 이동이 아니므로 fixedUpdate를 씀
    {
        rigid.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
    }

}
