using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



namespace Map
{
    public class MapManager : MonoBehaviour
    {
        //MapManager Class 생성

        public Map CurMap; //현재 Map을 저장할 변수

        [SerializeField]
        public List<NodeList> nodeList;

        [SerializeField]
        public List<NodeSprite> nodeSprites; //NodeSprite 들을 저장할 List

        [SerializeField]
        public NodeList nodes; // nodeList에 있는 것들 중 활용할 node를 저장할 변수 

        public static MapManager instance;

        //싱글턴 패턴 구현
        private void Awake()
        {
            instance = this;

        }

        //시작 시 실행될 함수
        private void Start()
        {            
            nodeList.Add(new NodeList_1()); //NodeList_1 추가

        }

        //종료 시 실행될 함수
        private void OnApplicationQuit()
        {
            
        }


    }


}

