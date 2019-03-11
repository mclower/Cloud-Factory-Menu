using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout : MonoBehaviour {

    public SceneLoader loader;

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(60);
        loader.LoadScene(0);
    }
}
