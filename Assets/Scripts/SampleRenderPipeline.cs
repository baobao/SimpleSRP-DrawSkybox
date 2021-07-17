using UnityEngine;
using UnityEngine.Rendering;

public class SampleRenderPipeline : RenderPipeline
{
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        context.DrawSkybox(cameras[0]);
        context.Submit();
    }
}