#pragma strict

var speed : float = 0.01;

function Update ()
{
	transform.Translate(Input.GetAxis("Horizontal")*speed,0,Input.GetAxis("Vertical")*speed);
}