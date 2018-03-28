using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Cursor.visible = true;
	}
}
