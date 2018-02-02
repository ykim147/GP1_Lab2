using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDisplay : MonoBehaviour {

    [SerializeField]
    private Sprite sprite;

    private void OnMouseDown()
    {
        GameObject.Find("Player").GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
