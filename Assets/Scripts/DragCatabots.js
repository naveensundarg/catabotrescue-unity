#pragma strict


function Start () {

}

function Update () {

}

function OnMouseDown () {
    var mainCamera = FindCamera();
		
	// We need to actually hit an object
	var hit : RaycastHit2D;
	
	hit=Physics2D.Raycast(mainCamera.transform.position, Input.mousePosition, 1000);
	
	if (!hit)
	{	
		Debug.Log("Hit Nothing");

		return;
	
	}
	// We need to hit a rigidbody that is not kinematic
	if (!hit.rigidbody || hit.rigidbody.isKinematic)
	{	
		Debug.Log("Hit Something Useless");

		return; 
	}
	
	
	
	Debug.Log("Selected");
	

}

function OnMouseDrag () {
}

function FindCamera ()
{
	if (camera)
		return camera;
	else
		return Camera.main;
		
		
}