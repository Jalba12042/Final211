using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private string itemName;

    [TextArea][SerializeField] private string itemExtraInfo;

    [SerializeField] private InspectControls inspectControls;

    public void ShowObjectName()
    {
        inspectControls.ShowName(itemName);
    }

    public void HideObjectName()
    {
        inspectControls.HideName();
    }

    public void ShowExtraInfo()
    {
        Debug.Log("Show");
        inspectControls.ShowAdditionalInfo(itemExtraInfo);
    }
}
