using UnityEngine;

public class SkyBoxManager : MonoBehaviour
{
    public void SetSkybox(Material skyboxMaterial)
    {
        RenderSettings.skybox = skyboxMaterial;
    }
}
