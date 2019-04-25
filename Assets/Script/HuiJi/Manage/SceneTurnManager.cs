using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTurnManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Coroutine e1 = StartCoroutine("Test");
        //StopCoroutine(e1);
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey("p"))
        //{
        //    SceneManager.LoadScene("Resources/Scene/SMScene");
        //}
        //StopCoroutine("");
	}

    IEnumerator Test()
    {
        Debug.Log("JMDS1");
        yield return new WaitForFixedUpdate();
        Debug.Log("JMDS2");
    }
    
}
