using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {


    void Awake()
    {
        DontDestroyOnLoad(gameObject);  // 不死身
    }


    // Use this for initialization
    void Start () {
        SceneManager.LoadScene("Scenes/Title/Title");
	}
	
	// Update is called once per frame
	void Update () {
	}
}
