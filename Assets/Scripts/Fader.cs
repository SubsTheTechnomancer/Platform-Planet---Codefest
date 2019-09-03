using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour {

    public Image fader;

    IEnumerator Fade()
    {
        Color alpha = fader.color;
        while(alpha.a > 0)
        {
            alpha.a -= 0.1f;
            yield return new WaitForSeconds(0.1f);
            fader.color = alpha;
        }
        Destroy(fader);
    }
    // Use this for initialization
    void Start () {
        StartCoroutine(Fade());
	}

}
