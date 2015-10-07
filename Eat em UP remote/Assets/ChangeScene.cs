using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {


    //Changes the scene to the next 
	public void ChangeToScene (string sceneToChangeTo) {
        Application.LoadLevel(sceneToChangeTo);
	}
}
