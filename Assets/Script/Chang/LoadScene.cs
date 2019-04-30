using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public delegate void CallBack(params object[] args);

public class LoadScene : MonoBehaviour {

    public static LoadScene Instance;

    public GameObject gom;

    private AsyncOperation ao = null;


    // Use this for initialization
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(gom);
    }

    public void LoadCScene(string sceneName, CallBack callBack, params object[] args)
    {
        StartCoroutine(IELoadScene(sceneName, callBack,args));
    }


    IEnumerator IELoadScene(string sceneName, CallBack callBack, params object[] args)
    {
        ao = SceneManager.LoadSceneAsync(sceneName);
        
        yield return ao;
        if (null!=callBack)
        {
            callBack(args);
        }
    }
}
