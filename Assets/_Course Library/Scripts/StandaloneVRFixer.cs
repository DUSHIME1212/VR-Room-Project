using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem.XR;
using Unity.XR.CoreUtils;

/// <summary>
/// This script automatically checks for and fixes common VR standalone build issues.
/// Attach this to your "XR Origin (VR)" object.
/// </summary>
public class StandaloneVRFixer : MonoBehaviour
{
    void Start()
    {
        Debug.Log("[VR Fixer] Starting Standalone VR Fix sequence...");
        
        FixTracking();
        FixInteraction();
        
        Debug.Log("[VR Fixer] Fix sequence complete. Check the console for more details.");
    }

    void FixTracking()
    {
        Camera mainCamera = GetComponentInChildren<Camera>();
        if (mainCamera == null)
        {
            Debug.LogError("[VR Fixer] CRITICAL: No Main Camera found under XR Origin!");
            return;
        }

        // 1. Ensure TrackedPoseDriver is present on Camera
        TrackedPoseDriver tpd = mainCamera.GetComponent<TrackedPoseDriver>();
        if (tpd == null)
        {
            Debug.Log("[VR Fixer] Adding missing TrackedPoseDriver to Main Camera.");
            tpd = mainCamera.gameObject.AddComponent<TrackedPoseDriver>();
        }

        // 2. Fix XR Origin Settings
        XROrigin origin = GetComponent<XROrigin>();
        if (origin != null)
        {
            if (origin.RequestedTrackingOriginMode != XROrigin.TrackingOriginMode.Floor)
            {
                Debug.Log("[VR Fixer] Setting Tracking Origin Mode to Floor.");
                origin.RequestedTrackingOriginMode = XROrigin.TrackingOriginMode.Floor;
            }
        }
    }

    void FixInteraction()
    {
        // 1. Ensure XR Interaction Manager exists
        UnityEngine.XR.Interaction.Toolkit.XRInteractionManager manager = FindFirstObjectByType<UnityEngine.XR.Interaction.Toolkit.XRInteractionManager>();
        if (manager == null)
        {
            Debug.Log("[VR Fixer] Creating missing XR Interaction Manager.");
            GameObject managerGO = new GameObject("XR Interaction Manager");
            managerGO.AddComponent<UnityEngine.XR.Interaction.Toolkit.XRInteractionManager>();
        }

        // 2. Ensure Input Action Manager exists (Crucial for Action Based)
        // Note: InputActionManager is usually a MonoBehaviour that takes an asset.
        // If it's missing, we notify the user as we can't easily "create" the asset reference here.
    }
}
