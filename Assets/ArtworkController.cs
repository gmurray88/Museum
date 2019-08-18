using UnityEngine;

public class ArtworkController : MonoBehaviour
{
    public GameObject image;
    public Transform frame;

    public void SetArtInfo(ArtInfo info)
    {
        Renderer rend = image.GetComponent<Renderer>();
        Material material = rend.material;
        material.mainTexture = info.image;
        Debug.Log("Pre method Image Height " + info.orig_height);
        Debug.Log("Pre method Image Width " + info.orig_width);
        frame.localScale = TextureToScale(info.orig_height, info.orig_width, frame.localScale.z);

    }

    private Vector3 TextureToScale(float height, float width, float depth)
    {
        Vector3 scale = Vector3.one;
        scale.z = depth;
        Debug.Log("Orig Image Height " + height);
        Debug.Log("Orig Image Width " + width);

        scale.y = (float)((height * 1.05) / 36);
        scale.x = (float)((width * 1.05) / 36);

        return scale;
    }
}