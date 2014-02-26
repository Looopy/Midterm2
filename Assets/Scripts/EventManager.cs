using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {
    public delegate void ColorChange(bool red);
    public static event ColorChange colorChange;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public static void CallColorChange(bool isRed) {
        colorChange(isRed);
    }
}
