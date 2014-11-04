using UnityEngine;
using System.Collections;

public class TouchControl : MonoBehaviour {
	public Transform oneball;
	public Transform twoball;
	public Transform threeball;
	public Transform fourball;
	public Transform fiveball;

	public int forcefactor;
	//TODO:serialize the record
	public static int shootingballmode;
	public static int ballnumber;
	public static int ballmodecounter;

	public float horizonforce;
	public float verticalforce;
	public float forwardforce;

	private Transform shootingball;
	// Use this for initialization
	void Start () {
		shootingballmode = 1;
		ballnumber = 10;
		ballmodecounter = 0;
	}
	public void detector()
	{
		Debug.Log ("contacted");
	}
	// Update is called once per frame
	void Update () {
	 if (Input.GetMouseButtonDown (0)) {

//			Transform shootingball = (Transform)Instantiate(oneball,Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,2.0f)),oneball.rotation);
//			Transform shootingball = (Transform)Instantiate(twoball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);
//			Transform shootingball = (Transform)Instantiate(fiveball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);

			float forcex = (Input.mousePosition.x -  Screen.width/2)/(Screen.width/2);
			float forcey = (Input.mousePosition.y -  Screen.height/2)/(Screen.height/2);

			switch(shootingballmode){
			case 1:
				shootingball = (Transform)Instantiate(oneball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);
				foreach(Transform ballchild in shootingball)
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce,forwardforce),ForceMode.Acceleration);
				}
				break;
			case 2:
				//Two ball shooting
				shootingball = (Transform)Instantiate(twoball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);
				int i = 0;
				foreach(Transform ballchild in shootingball)
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+(200.0f*i),forcey*verticalforce,forwardforce),ForceMode.Acceleration);
					i++;
				}
				break;
			case 3:
			//three ball shooting
				shootingball = (Transform)Instantiate(threeball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);

			foreach(Transform ballchild in shootingball)
			{
				if(ballchild.tag=="topball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce+50.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="leftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-100.0f,forcey*verticalforce-150.0f,forwardforce),ForceMode.Acceleration);	
				}else if(ballchild.tag=="rightball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+100.0f,forcey*verticalforce-150.0f,forwardforce),ForceMode.Acceleration);
				}
			}
				break;
			case 4:
			//four ball shooting
			shootingball = (Transform)Instantiate(fourball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);
			foreach(Transform ballchild in shootingball)
			{
				if(ballchild.tag=="topball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce+50.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="downball")
				{  
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce-150.0f,forwardforce),ForceMode.Acceleration);	
				}else if(ballchild.tag=="rightball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+100.0f,forcey*verticalforce-50.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="leftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-100.0f,forcey*verticalforce-50.0f,forwardforce),ForceMode.Acceleration);
				}
			}
				break;
			case 5:
			//five ball shooting
			shootingball = (Transform)Instantiate(fiveball,Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,0.0f)),twoball.rotation);
			foreach(Transform ballchild in shootingball)
			{
				if(ballchild.tag=="topleftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-100.0f,forcey*verticalforce+50.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="toprightball")
				{  
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+100.0f,forcey*verticalforce+50.0f,forwardforce),ForceMode.Acceleration);	
				}else if(ballchild.tag=="middleball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce-50.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="downleftball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce-100.0f,forcey*verticalforce-150.0f,forwardforce),ForceMode.Acceleration);
				}else if(ballchild.tag=="downrightball")
				{
					ballchild.rigidbody.AddForce(new Vector3(forcex*horizonforce+100.0f,forcey*verticalforce-150.0f,forwardforce),ForceMode.Acceleration);
				}
			}
				break;
			}

			if(--TouchControl.ballnumber <= 0)
			{
				//TODO:game over
				Debug.Log("game over");
			}

//			shootingball.rigidbody.AddForce(new Vector3(forcex*horizonforce,forcey*verticalforce,forwardforce),ForceMode.Acceleration);
//			shootingball.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,2.0f));
//			Debug.Log(Screen.height);
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		}
	}
}
