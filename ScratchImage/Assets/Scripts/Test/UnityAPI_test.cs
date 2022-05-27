using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityAPI_test : MonoBehaviour
{
    public Camera uiCamera;
    public RectTransform _rectTsf;
    Vector2 localPt = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 按下鼠标
        {
            TTTTT();
        }
    }

    private void TTTTT()
    {
        Vector2 mPos = Input.mousePosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_rectTsf, Input.mousePosition, uiCamera, out localPt);

        Debug.LogFormat("mousePos:{0} , localPos:{1}", mPos, localPt);
    }

    [ContextMenu("Matrix4x4 Test")]
    private void Matrix4x4_Test()
    {
        // get matrix from the Transform
        var matrix = transform.localToWorldMatrix;
        // get position from the last column
        var position = new Vector3(matrix[0, 3], matrix[1, 3], matrix[2, 3]);
        Debug.Log("Transform position from matrix is: " + position);
        Debug.Log("Rotate: " + matrix.rotation);
        Debug.Log("Scale: " + matrix.lossyScale);

        string s = "\n";
        for (int i = 0; i < 4; i++)
            s += matrix.GetRow(i) + "\n";
        Debug.Log(s);
    }
}
