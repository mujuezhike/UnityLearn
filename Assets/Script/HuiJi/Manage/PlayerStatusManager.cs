using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatusManager : MonoBehaviour {

    public GameObject blood;
    public GameObject startMenu;
    public GameObject dl;
    public GameObject gop;

    public PlayerMainShip playerMainShip;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerMainShip.hp < 0)
        {
            //改红色
            int idm = playerMainShip.transform.childCount;
            for (int i = 0; i < idm; i++)
            {
                Material ml = playerMainShip.transform.GetChild(i).GetComponent<Renderer>().material;
                ml.color = new Color(0.1f, 0.1f, 0.1f);
            }
            blood.transform.localScale = new Vector3(
            playerMainShip.hp * 0f / playerMainShip.maxHp, 1, 1);
            
            Invoke("Back", 10);
            gop.SetActive(true);
            return;
        }

        blood.transform.position = new Vector3(
            -12+(playerMainShip.hp * 10f / playerMainShip.maxHp)/2,9,0);
        blood.transform.localScale = new Vector3(
            playerMainShip.hp * 10f / playerMainShip.maxHp, 1,1);
    }

    void Back()
    {
        dl.SetActive(false);
        startMenu.SetActive(true);
    }
}
