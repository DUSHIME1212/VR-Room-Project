using UnityEngine;

/// <summary>
/// A functional Flashlight script for VR.
/// Handles light toggling, emission switching for the lens, and sound effects.
/// </summary>
public class Flashlight : MonoBehaviour
{
    [Header("Settings")]
    public bool isOn = false;

    [Header("Components")]
    [Tooltip("The light component to toggle")]
    public Light flashlightLight;
    
    [Tooltip("The renderer for the flashlight lens/bulb to toggle emission")]
    public MeshRenderer lensRenderer;

    [Tooltip("The audio source for toggle sounds")]
    public AudioSource audioSource;

    [Header("Visuals")]
    public Color lightColor = Color.white;
    public float lightIntensity = 1.5f;

    [Header("Audio Clips")]
    public AudioClip toggleOnSound;
    public AudioClip toggleOffSound;

    private static readonly int EmissionColorProperty = Shader.PropertyToID("_EmissionColor");

    private void Awake()
    {
        // Try to auto-assign if components are missing
        if (flashlightLight == null) flashlightLight = GetComponentInChildren<Light>();
        if (lensRenderer == null) lensRenderer = GetComponent<MeshRenderer>();
        if (audioSource == null) audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        UpdateFlashlightState(false); // Silent start
    }

    /// <summary>
    /// Toggles the flashlight on or off with sound feedback.
    /// </summary>
    public void Toggle()
    {
        isOn = !isOn;
        UpdateFlashlightState(true);
        Debug.Log("Flashlight toggled: " + isOn);
    }

    public void TurnOn()
    {
        if (isOn) return;
        isOn = true;
        UpdateFlashlightState(true);
    }

    public void TurnOff()
    {
        if (!isOn) return;
        isOn = false;
        UpdateFlashlightState(true);
    }

    private void UpdateFlashlightState(bool playSound)
    {
        if (flashlightLight != null)
        {
            flashlightLight.enabled = isOn;
            flashlightLight.color = lightColor;
            flashlightLight.intensity = lightIntensity;
        }

        if (lensRenderer != null)
        {
            // Simple emission toggle using a fixed color or black
            Color emission = isOn ? lightColor : Color.black;
            lensRenderer.material.SetColor(EmissionColorProperty, emission);
            
            if (isOn)
                lensRenderer.material.EnableKeyword("_EMISSION");
            else
                lensRenderer.material.DisableKeyword("_EMISSION");
        }

        if (playSound && audioSource != null)
        {
            AudioClip clip = isOn ? toggleOnSound : toggleOffSound;
            if (clip != null)
            {
                audioSource.PlayOneShot(clip);
            }
        }
    }

    private void OnValidate()
    {
        if (Application.isPlaying) return;
        
        // Ensure visual state matches in editor toggle
        if (flashlightLight != null) flashlightLight.enabled = isOn;
    }
}
