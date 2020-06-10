using UnityEngine;

// We need the UnityEngine.XR.WSA namespace to access Holographic Settings which contain 
// functions which effect the performance and presentation of Holograms on Windows 
// Holographic platforms.
using UnityEngine.XR.WSA;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        // Check if the MR headset display is transparent (not opaque).
        if (!HolographicSettings.IsDisplayOpaque)
        {
            // If that is the case, then we need to hide the virtual living room
            GameObject[] HMDUOnlyObjects = GameObject.FindGameObjectsWithTag("HMDUOnly");
            for (int i = 0; i < HMDUOnlyObjects.Length; i++)
            {
                // Set active to false disables the object.
                HMDUOnlyObjects[i].SetActive(false);
            }
        }
    }
}