using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnvironment : MonoBehaviour {

	public GameObject env;

	public void destroyObj(){
		Destroy (env);
	}
}
