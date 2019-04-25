using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatusManager : MonoBehaviour {

    public GameObject blood;

    public PlayerMainShip playerMainShip;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        blood.transform.position = new Vector3(
            -12+(playerMainShip.hp * 10f / playerMainShip.maxHp)/2,9,0);
        blood.transform.localScale = new Vector3(
            playerMainShip.hp * 10f / playerMainShip.maxHp, 1,1);
    }
}
