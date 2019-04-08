﻿using HMUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CustomUI.UIElements
{
    public class ClickableText : TextMeshProUGUI, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
    {
        public Color highlightColor = Color.cyan;
        public Color defaultColor = Color.white;
        public Action OnClickEvent, PointerEnterEvent, PointerExitEvent;
        public void OnPointerClick(PointerEventData eventData)
        {
            color = defaultColor;
            OnClickEvent?.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            color = highlightColor;
            PointerEnterEvent?.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            color = defaultColor;
            PointerExitEvent?.Invoke();
        }
    }
}
