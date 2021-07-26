using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed; // Playerspeed
    private float xInput; // Spielereingabe
    private float towardsY = 0f; // Winkel zu dem dem sich der PLayer um eigene Achse dreht
    
    public float jumpPush = 5f; // Sprungkraft
    private bool onGround = false;

    public Rigidbody2D RB;
    public GameObject playerModel;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal"); //Eingabesignal fürs laufen

        //Drehen:
        //if (xInput > 0f) // nach rechts gehen
        //    towardsY = 0f;
        //else if (xInput < 0f) // nach links gehen
        //    towardsY = 180f;

        //playerModel.transform.rotation = Quaternion.Lerp(playerModel.transform.rotation, Quaternion.Euler(0f, towardsY, 0f), Time.deltaTime * 10f);

        //Springen:
        //RaycastHit2D hit2D;
        //onGround = Physics.Raycast(transform.position (Vector3.up * 0, 1f), Vector3.down, out hit2D, 0,1f);

        if (Input.GetAxisRaw("Jump") > 0f)
        {
            Vector2 JumpPower = RB.velocity;
            JumpPower.y = jumpPush;
            RB.velocity = JumpPower;
        }
        

    }

    private void FixedUpdate()
    {
        RB.velocity = new Vector2(xInput * Speed, RB.velocity.y); //Vorfärtsbewegung
    }
}
