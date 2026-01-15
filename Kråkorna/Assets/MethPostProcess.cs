using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MethPostProcess : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Rendering.VolumeProfile profile = GameObject.Find("PostProcess").GetComponent<UnityEngine.Rendering.Volume>().profile;
        UnityEngine.Rendering.Universal.ChromaticAberration myChromaticAberration;
        profile.TryGet(out myChromaticAberration);
        myChromaticAberration.intensity.Override(0);
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Rendering.VolumeProfile profile = GameObject.Find("PostProcess").GetComponent<UnityEngine.Rendering.Volume>().profile;
        UnityEngine.Rendering.Universal.ChromaticAberration myChromaticAberration;
        profile.TryGet(out myChromaticAberration);

        if (CodeCheckerScript.Instance.meth == true)
        {
            myChromaticAberration.intensity.Override(1);

        }
        else
        {
            myChromaticAberration.intensity.Override(0);

        }
    }
}
