using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BackgroundController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private RectTransform _parentRectTransform;
    [SerializeField] private RawImage _image;
    [Header("Settings")]
    [SerializeField] private Vector2 repeatCount;
    [SerializeField] private Vector2 scroll;
    [SerializeField] private Vector2 offset;

    private void Awake()
    {
        if (!_image) _image = GetComponent<RawImage>();

        _image.uvRect = new Rect(offset, repeatCount);
    }

    private void Start()
    {
        if (!_rectTransform) _rectTransform = GetComponent<RectTransform>();
        if (!_parentRectTransform) _parentRectTransform = GetComponentInParent<RectTransform>();

        SetScale();
    }

    private void Update()
    {
        SetScale();
        offset += scroll * Time.deltaTime;
        _image.uvRect = new Rect(offset, repeatCount);
    }

    private void SetScale()
    {
        var parentCorners = new Vector3[4];
        _parentRectTransform.GetLocalCorners(parentCorners);
        var diagonal = Vector3.Distance(parentCorners[0], parentCorners[2]);
        _rectTransform.sizeDelta = new Vector2(diagonal, diagonal);
    }
}