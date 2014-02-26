using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public Material redMat;
    public Material yellowMat;

	// Use this for initialization
	void Start () {
        EventManager.colorChange += ColorChange;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void ColorChange(bool red) {
        if (red) {
            gameObject.GetComponent<MeshRenderer>().material = redMat;
        } else {
            gameObject.GetComponent<MeshRenderer>().material = yellowMat;
        }
    }
}
