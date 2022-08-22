using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roomescape
{
    public class UiManager : MonoBehaviour
    {
        public static UiManager I;

        public GameObject _backBtnObj;
        public GameObject _leftBtnObj;
        public GameObject _rightBtnObj;

        public UI_Inventory _ui_Inven;

        void Awake()
        {
            I = this;
        }

        void Start()
        {
            _backBtnObj = transform.Find("BackButton").gameObject;
            _leftBtnObj = transform.Find("LeftButton").gameObject;
            _rightBtnObj = transform.Find("RightButton").gameObject;

            _ui_Inven = transform.Find("Inventory").GetComponent<UI_Inventory>();

            bool mainView = true;
            OnChangeView(mainView);
        }

        public void OnChangeView(bool isMainView) //true: 메인 뷰 상태, false: 확대된 상태
        {
            _backBtnObj.SetActive(!isMainView);
            _leftBtnObj.SetActive(isMainView);
            _rightBtnObj.SetActive(isMainView);
        }


        void Update()
        {

        }
    }
}
