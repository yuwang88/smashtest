using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public float cameraspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,0,cameraspeed*Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("collision");
//		animator.SetBool ();
		transform.GetComponent<Animator> ().SetBool ("cameracontact",true);
	}
	public void AfterShake()
	{
		transform.GetComponent<Animator> ().SetBool ("cameracontact",false);
	}
}
