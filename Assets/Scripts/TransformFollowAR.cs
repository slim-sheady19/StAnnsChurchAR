using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TransformFollowAR : MonoBehaviour
{
    [SerializeField] Transform _followTransform;

    private void Awake() {
        if (_followTransform == null) enabled = false;
    }

    private void Start()
    {
        RenderPipelineManager.beginCameraRendering += OnBeforeRender;
    }

    private void Update()
    {
        transform.position = _followTransform.position;
        transform.rotation = _followTransform.rotation;
    }

    private void FixedUpdate()
    {
        transform.position = _followTransform.position;
        transform.rotation = _followTransform.rotation;
    }

    private void LateUpdate()
    {
        transform.position = _followTransform.position;
        transform.rotation = _followTransform.rotation;
    }

    void OnBeforeRender(ScriptableRenderContext context, Camera camera)
    {
        transform.position = _followTransform.position;
        transform.rotation = _followTransform.rotation;
    }

    void OnDestroy()
    {
        RenderPipelineManager.beginCameraRendering -= OnBeforeRender;
    }
}
