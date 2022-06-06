using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CinemachineFunctions : MonoBehaviour
{
    
    public static CinemachineFunctions Instance { get; private set; }

    private CinemachineVirtualCamera cVC;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        cVC = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakeCamera(float intensity)
    {
        CinemachineBasicMultiChannelPerlin cBMCP = cVC.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cBMCP.m_AmplitudeGain = intensity;
    }

}
