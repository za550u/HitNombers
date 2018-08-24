using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VSBtn : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("Scenes/Other/Match", LoadSceneMode.Additive);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
