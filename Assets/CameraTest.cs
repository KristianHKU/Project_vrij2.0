using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public Transform target;           
    public float followSpeed = 5f;      

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position;
            Vector3 cameraPosition = targetPosition;
            cameraPosition.z = transform.position.z;

            transform.position = Vector3.Lerp(transform.position, cameraPosition, followSpeed * Time.deltaTime);
        }
    }
}
