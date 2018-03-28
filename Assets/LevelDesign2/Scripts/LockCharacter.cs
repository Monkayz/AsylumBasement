using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCharacter : MonoBehaviour {

	public void Lock(){
		if (Invector.CharacterController.vThirdPersonController.instance != null) {
			Invector.CharacterController.vThirdPersonController.instance.gameObject.SetActive (false);
		}
	}
}
