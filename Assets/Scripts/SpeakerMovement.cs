using UnityEngine;
using UnityEngine.XR.WSA;
// namespace for the TwoHandManipulatable script
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
// namespace for the TapToPlace script
using HoloToolkit.Unity.SpatialMapping;

public class SpeakerMovement : MonoBehaviour
{

    void Start()
    {
        if (!HolographicSettings.IsDisplayOpaque)
        {
            GetComponent<TwoHandManipulatable>().enabled = false;
            GetComponent<TapToPlace>().enabled = true;
        }
    }
}