using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiroBehaviour : MonoBehaviour
{
    private float force;
    [SerializeField] private Rigidbody2D rb;
    public float reforce;
    private bool space = false;
    [SerializeField] private GameObject tiro;
   
    private void Start()
    {
        ShootBoss();
      //  reforce = force;
    }

    void ShootBoss()
    {
        force = Random.Range(280, 460);
        rb.AddForce(new Vector2(-force, force));
    }

    private void Update()
    {
        if(transform.position.y <= -5.19f)
        {
            Destroy(this.gameObject);
        }
        if(transform.position.x >= 10f)
        {
            Destroy(this.gameObject);
        }

        if(Input.GetKeyDown("space")){
            space = true;
        }
    }

    public void AtirarPlayer()
    {
        if(space)
        {
            rb.AddForce(new Vector2(force, force));
            rb.AddForce(new Vector2(force, force));
            tiro.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        
    }
}
