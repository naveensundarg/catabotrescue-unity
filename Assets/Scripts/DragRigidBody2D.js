var spring = 50.0;
var damper = 5.0;
var drag = 10.0;
var angularDrag = 5.0;
var distance = 0.2;
var attachToCenterOfMass = false;
var obj;
private var springJoint : SpringJoint2D;

function Update ()
{
	// Make sure the user pressed the mouse down
	if (!Input.GetMouseButtonDown (0))
		return;

	var mainCamera = FindCamera();
		
	// We need to actually hit an object
		var hit : RaycastHit2D;
		
		hit=Physics2D.Raycast(mainCamera.transform.position, Input.mousePosition, 1000);
	if (!hit)
		return;
	// We need to hit a rigidbody that is not kinematic
	if (!hit.rigidbody || hit.rigidbody.isKinematic)
		return;
	
//	if (!springJoint)
//	{
	//	var go = new GameObject("Rigidbody dragger");
	//	var body : Rigidbody2D = go.AddComponent ("Rigidbody2D") as Rigidbody2D;
	//	springJoint = go.AddComponent ("SpringJoint2D");
	//	body.isKinematic = true;
//	}
	
	//springJoint.transform.position = hit.point;
	if (attachToCenterOfMass)
	{
	//	var anchor = transform.TransformDirection(hit.rigidbody.centerOfMass) + hit.rigidbody.transform.position;
	//	anchor = springJoint.transform.InverseTransformPoint(anchor);
	//	springJoint.anchor = anchor;
	}
	else
	{
	//	springJoint.anchor = Vector3.zero;
	}
	obj=hit.rigidbody;
	//springJoint.spring = spring;
//	springJoint.dampingRatio = damper;
//	springJoint.distance = distance;
//	springJoint.connectedAnchor = hit.rigidbody.transform.position;
//	
	StartCoroutine ("DragObject", hit.point);
}

function DragObject (point : Vector2 )
{
//	var oldDrag = springJoint.connectedBody.drag;
//	var oldAngularDrag = springJoint.connectedBody.angularDrag; 
//	springJoint.connectedBody.drag = drag;
//	springJoint.connectedBody.angularDrag = angularDrag;
	var mainCamera = FindCamera();
	while (Input.GetMouseButton (0))
	{
		//var ray = mainCamera.ScreenPointToRay (Input.mousePosition);
		//var point : Vector3 =ray.GetPoint(distance);
	//	springJoint.transform.position = point;
		obj.transform.position= new Vector2(mainCamera.ScreenToWorldPoint(Input.mousePosition).x,mainCamera.ScreenToWorldPoint(Input.mousePosition).y) ;
		Debug.Log("(" +point.x+","+point.y+")");
		yield;
	}
//	if (springJoint.connectedBody)
//	{
//		//springJoint.connectedBody.drag = oldDrag;
//		//springJoint.connectedBody.angularDrag = oldAngularDrag;
//		springJoint.connectedBody = null;
//	}
}

function FindCamera ()
{
	if (camera)
		return camera;
	else
		return Camera.main;
}