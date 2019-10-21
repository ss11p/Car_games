using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;
public class Car : MonoBehaviour
{
    public static Car inatatic;
    public List<AxeleInfo> axleInfos;//個々の車軸の情報
    public float maxMotorTorque;//ホイールに適用可能な最大トルク
    public float maxSteeringAngle=30;//適用可能な最大ハンドル角度
    public float maxBreakeTorque;
    public void Start()
    {
        maxMotorTorque = 900;
        transform.Rotate(0, 180, 0);
    }
    public void ApplyLocalPosiitonToVisuals(WheelCollider collider)
    {
        // Wheelコライダーの子要素がない場合は処理終了。
        if (collider.transform.childCount == 0)
            return;
        //タイヤビジュアルを取得
        Transform visual = collider.transform.GetChild(0);
        //コライダーの位置と回転を取得
        Vector3 pos;
        Quaternion q;
        collider.GetWorldPose(out pos, out q);
        //タイヤビジュアルに、コライダーの値を設定。
        visual.transform.position = pos;
        //タイヤを回す
        visual.transform.rotation = q  ;
        
    }

        // Start is called before the first frame update
        public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        bool beake = Input.GetKey(KeyCode.B);
        foreach(AxeleInfo axeleInfo in axleInfos)
        {
            if (axeleInfo.steering)
            {
                axeleInfo.leftWheel.steerAngle = steering;
                axeleInfo.rightWheel.steerAngle = steering;
            }
            if (axeleInfo.motor)
            {
                axeleInfo.leftWheel.motorTorque = motor;
                axeleInfo.rightWheel.motorTorque = motor;
            }
            if (beake)
            {
                axeleInfo.leftWheel.brakeTorque = maxBreakeTorque;
                axeleInfo.rightWheel.brakeTorque = maxBreakeTorque;
            }
            else
            {
                axeleInfo.leftWheel.brakeTorque = 0;
                axeleInfo.rightWheel.brakeTorque = 0;
            }
            ApplyLocalPosiitonToVisuals(axeleInfo.leftWheel);
            ApplyLocalPosiitonToVisuals(axeleInfo.rightWheel);
        }
        var timers = Timer.instar;
        if (timers.timer <= 0)
        {
            maxMotorTorque = 0;
        }
        if (timers.timer == 60)
        {
            maxMotorTorque = 900;
        }
      
    }
 
}
[System.Serializable]
public class AxeleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;//このホイールがエンジンにアタッチされているかどうか
    public bool steering;//このホイールがハンドルの角度を反映しているかどうか
   public bool beake;
}
