using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StarController : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("pointer down");
    }

    public void OnBeginDrag(PointerEventData eventData) {

    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("dragging" + eventData.position);
        Vector2 position = (Vector2)transform.position;
        position += eventData.delta;
        transform.position = position;
    }

    public void OnEndDrag(PointerEventData eventData) {

    }


    // Start is called before the first frame update
    void Start()
    {
        //transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

}
