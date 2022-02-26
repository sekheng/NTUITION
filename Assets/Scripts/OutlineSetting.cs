using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineSetting : MonoBehaviour
{

    public void ChangeOutlineX(float _sizeX)
    {
        OutlineManager.Instance.ChangeOutlineSizeX(_sizeX);
    }
    public void ChangeOutlineY(float _sizeY)
    {
        OutlineManager.Instance.ChangeOutlineSizeY(_sizeY);
    }

}
