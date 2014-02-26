using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
    public bool isRed;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.Find("Player");
        if ((player.transform.position - transform.position).magnitude < 1.7) {
            EventManager.CallColorChange(isRed);
        }
	}
}
