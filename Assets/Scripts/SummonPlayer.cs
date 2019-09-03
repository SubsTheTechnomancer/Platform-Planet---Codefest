using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SummonPlayer : MonoBehaviour {

    public GameObject platform;
    public GameObject freeze;
    public int outofbounds = -10;
    public string level;

    private bool delclone = false;

    GameObject clone, prev; 

	// Use this for initialization
	void Start () {
        clone = Instantiate(platform, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {

        if(delclone == true)
        {
            if (clone.GetComponent<BoxCollider2D>().IsTouching(prev.GetComponent<BoxCollider2D>()))
                Destroy(prev);
            delclone = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            prev = clone;
            Destroy(clone.GetComponent<Rigidbody2D>());
            Destroy(clone.GetComponent<PlayerMovement>());
            Destroy(clone.GetComponent<Animator>());
            Instantiate(freeze, clone.transform.position, clone.transform.rotation);
            clone = Instantiate(platform, transform.position, transform.rotation);
            delclone = true;
        }

        if(clone.transform.position.y <= outofbounds)
        {
            Destroy(clone);
            clone = Instantiate(platform, transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadSceneAsync(level);
        }
	}
}
