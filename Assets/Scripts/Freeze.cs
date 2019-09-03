using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour {

    private SpriteRenderer s;
    public Sprite[] sp;
    public float delay = 0.05f;

    private void Awake()
    {
        s = GetComponent<SpriteRenderer>();
        StartCoroutine(frames());
    }

    IEnumerator frames()
    {
        for(int i = 0; i < sp.Length; i++)
        {
            s.sprite = sp[i];
            yield return new WaitForSeconds(delay);
        }

        Destroy(gameObject);
    }
}
