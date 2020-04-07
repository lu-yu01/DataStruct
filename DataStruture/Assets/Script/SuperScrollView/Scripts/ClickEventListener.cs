using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
    public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        public static ClickEventListener Get(GameObject obj)
        {
            ClickEventListener listener = obj.GetComponent<ClickEventListener>();
            if (listener == null)
            {
                listener = obj.AddComponent<ClickEventListener>();
            }
            return listener;
        }

        System.Action<GameObject> mClickedHandler = null;
        System.Action<GameObject> mDoubleClickedHandler = null;
        System.Action<GameObject> mOnPointerDownHandler = null;
        System.Action<GameObject> mOnPointerUpHandler = null;
        bool mIsPressed = false;

        public bool IsPressd
        {
            get { return mIsPressed; }
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.clickCount == 2)
            {
                Debug.Log("mDoubleClickedHandler");
                if (mDoubleClickedHandler != null)
                {
                    mDoubleClickedHandler(gameObject);
                }
            }
            else
            {
                if (mClickedHandler != null)
                {
                    Debug.Log("mClickedHandler");
                    mClickedHandler(gameObject);
                }
            }

        }
        public void SetClickEventHandler(System.Action<GameObject> handler)
        {
            Debug.Log("SetClickEventHandler");
            mClickedHandler = handler;
        }

        public void SetDoubleClickEventHandler(System.Action<GameObject> handler)
        {
            Debug.Log("SetDoubleClickEventHandler");
            mDoubleClickedHandler = handler;
        }

        public void SetPointerDownHandler(System.Action<GameObject> handler)
        {
            Debug.Log("SetPointerDownHandler");
            mOnPointerDownHandler = handler;
        }

        public void SetPointerUpHandler(System.Action<GameObject> handler)
        {
            Debug.Log("SetPointerUpHandler");
            mOnPointerUpHandler = handler;
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("OnPointerDown");
            mIsPressed = true;
            if (mOnPointerDownHandler != null)
            {
                mOnPointerDownHandler(gameObject);
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Debug.Log("OnPointerUp");
            mIsPressed = false;
            if (mOnPointerUpHandler != null)
            {
                mOnPointerUpHandler(gameObject);
            }
        }

    }

}
