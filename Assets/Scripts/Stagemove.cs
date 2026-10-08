//ライブラリの宣言：これからこの機能を使うよ
using UnityEngine;
using UnityEngine.InputSystem;


public class Stagemove : MonoBehaviour
{
    //変数
    //データ型( int,string,InputAction )　+　変数名(num,name)
    private InputAction moveInput;
    
    //目的(抽象的課題)：ステージを回転させること
    //手段(具体的課題)：actionmapを使用してプレイヤーの入力を受け取る
    //      受け取った入力を元にステージをRotationさせる

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("move");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());
        
        //模範解答
        Vector3 rotation;
        float threshold = 0.2f;
        rotation = new Vector3( moveInput.ReadValue<Vector2>().y*threshold, 0, moveInput.ReadValue<Vector2>().x*threshold );

        //↓自分で書いたやつ
        //Vector2 input = moveInput.ReadValue<Vector2>();
        //Vector3 rotation = new Vector3(input.y, 0, input.x);
        //this.transform.Rotate(rotation);


       this.transform.Rotate(rotation);

        
    }
}
