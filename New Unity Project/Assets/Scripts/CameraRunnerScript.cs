using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {


    public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float pPos = player.position.x;
        float cPos = pPos + 6;
        if(this.transform != null)
             transform.position = new Vector3(cPos, 0, -10);
	}
}
