using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float velx = 1;
    public float force = 100;
    public Sprite[] idle;

    private int isjumping = 0;

    private bool flag = true;

    private void Start()
    {
        StartCoroutine(idleanim());
    }

    IEnumerator idleanim()
    {
        do
        {
            GetComponent<SpriteRenderer>().sprite = idle[0];
            yield return new WaitForSeconds(0.5f);
            GetComponent<SpriteRenderer>().sprite = idle[1];
            yield return new WaitForSeconds(0.5f);
        } while (GetComponent<Rigidbody2D>());
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.W) && (flag == true || GetComponent<Rigidbody2D>().velocity.y == 0))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,force));
        }

        if (Input.GetKey(KeyCode.A)){
            GetComponent<Animator>().SetInteger("Moving", 2);
            transform.position -= new Vector3(velx, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Animator>().SetInteger("Moving", 1);
            transform.position += new Vector3(velx, 0, 0);
        }
        else
        { 
            GetComponent<Animator>().SetInteger("Moving", 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        flag = true;
        isjumping = 0;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        flag = false;
        isjumping = 1;
    }
}
