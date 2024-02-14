using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



namespace Map
{
    //Node Class를 정의
    public class Node : MonoBehaviour
    {
        public Point point; //Node의 좌표값을 저장할 Point 형 변수
        public List<Node> connected; //이 Node와 연결된 다른 Node의 좌표를 저장할 List
        public NodeType nodeType; //NodeType을 저장할 변수
        public Vector2 position; //실제 위치를 표현할 Vector2 변수
        public NodeStates state = NodeStates.Locked; //NodeStates를 저장할 변수, 초기는 Locked로 고정.
        public SpriteRenderer sR; //SpriteRender 저장 변수
        public Image image; //Image 저장 변수



        //Node Class의 값 넣기?
        public Node(NodeType nodeType, Point point)
        {
            this.nodeType = nodeType;
            this.point = point;
            position = new Vector2(this.point.x, this.point.y);
       }



        //Node Class의 값 넣기?
        public Node(NodeType nodeType, Point point, List<Node> connected)
        {
            this.nodeType = nodeType;
            this.point = point;
            this.connected = connected;
            position = new Vector2(this.point.x, this.point.y);
        }


        public void addInfo(Node n)
        {
            point = n.point;
            connected = n.connected;
            nodeType = n.nodeType;
            position = n.position;
            state = n.state;

        }//addInfo



        //Node 연결 정보를 추가하는 함수 
        public void AddConnections(Node n)
        {
            if (connected.Any(e => e.point.Equals(n.point)))
                return;

            connected.Add(n);

        }//AddConnections


        //Node의 연결 정보를 제거하는 함수
        public void RemoveConnections(Node n)
        {

            connected.RemoveAll(e => e.point.Equals(n.point));

        }//RemoveConnections


        //Node의 이미지 변경? 하는 함수
        public void setUp()
        {
            sR.sprite = MapManager.instance.nodeSprites.FirstOrDefault(nS => nS.nodeType == this.nodeType).sprite;
            image.sprite = MapManager.instance.nodeSprites.FirstOrDefault(nS => nS.nodeType == this.nodeType).sprite;

        }//setUp





    }//Node Class

}

 
