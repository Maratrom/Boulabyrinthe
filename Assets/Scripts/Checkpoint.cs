using Unity.VisualScripting;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public GameObject associatedBar;
    public GameObject associatedCanvaElem;
    public SwitchCamera switchCamera;
    public int cameraFocusIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && associatedBar != null)
        {
            if (switchCamera != null)
            {
                switchCamera.TempCamera(cameraFocusIndex);
            }

            if (associatedBar != null)
            {
                associatedBar.SetActive(false);
            }

            if (gameObject != null)
            {
                gameObject.SetActive(false);
            }

            if (switchCamera != null)
            {
                associatedCanvaElem.SetActive(false);
            } else
            {
                associatedCanvaElem.SetActive(true);
            }

                return;
        }



    }
}
