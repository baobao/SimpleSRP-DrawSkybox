using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu]
public class SampleRenderPipelineAsset : RenderPipelineAsset
{
    protected override RenderPipeline CreatePipeline()
    {
        return new SampleRenderPipeline();
    }
}