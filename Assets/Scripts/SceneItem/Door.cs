using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roomescape
{
    public class Door : SceneObject
    {
        public Transform _doorPanelTrans;
        public bool _opened = false;

        protected override void Start()
        {
            base.Start();

            _doorPanelTrans = transform.Find("Door");
        }

        protected override void OnMouseDown()
        {
            base.OnMouseDown();

            // ���� ���� �ݰ�

            // ���� ���������� ����
            if (_opened == false)
                Open();
            // ���� ���������� �ݰ�
            else if (_opened == true)
                Close();
        }


        public void Open()
        {
            _opened = true;

            _doorPanelTrans = transform.Find("Door");

            float y = _doorPanelTrans.localPosition.y;

            _doorPanelTrans.localPosition = new Vector3(-0.2476f, y, -0.0187f);
            _doorPanelTrans.rotation = Quaternion.Euler(0, -66.905f, 0);
        }

        public void Close()
        {
            _opened = false;

            _doorPanelTrans = transform.Find("Door");

            float y = _doorPanelTrans.localPosition.y;

            _doorPanelTrans.localPosition = new Vector3(0, y, 0);
            _doorPanelTrans.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
