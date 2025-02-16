using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == currentCameraIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchToNextCamera();
        }
    }

    void SwitchToNextCamera()
    {
        SwitchToCamera((currentCameraIndex + 1) % cameras.Length);
    }

    public void SwitchToCamera(int index)
    {
        cameras[currentCameraIndex].gameObject.SetActive(false);
        cameras[index].gameObject.SetActive(true);
        currentCameraIndex = index;
    }

    public void TempCamera(int focus)
    {
        StartCoroutine(TempCameraCoroutine(focus));
    }

    private IEnumerator TempCameraCoroutine(int focus)
    {
        int actual = currentCameraIndex;
        SwitchToCamera(focus);
        yield return new WaitForSeconds(4);
        SwitchToCamera(actual);
    }
}
