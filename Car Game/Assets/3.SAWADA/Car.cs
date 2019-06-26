using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;
public class Car : MonoBehaviour
{
    public List<AxeleInfo> axleInfos;//個々の車軸の情報
    public float maxMotorTorque=400;//ホイールに適用可能な最大トルク
    public float maxSteeringAngle=30;//適用可能な最大ハンドル角度
    public void ApplyLocalPosiitonToVisuals(WheelCollider collider)
    {
        //Wheelコライダーの子要素がない場合は処理終了
        if (collider.transform.childCount == 0)
         return;
            //タイヤビジュアルを取得
            Transform visual = collider.transform.GetChild(0);
        //コライダーの位置と回転を取得
        Vector3 pos;
        Quaternion q;
        collider.GetWorldPose(out pos, out q);
        //タイヤビジュアルに、コライダーの値を設定。
        //単純な車の場合、Z軸を90f回転させる必要がある
        visual.transform.position = pos;
        visual.transform.rotation = q * Quaternion.Euler(0f, 0f,0f); ;
        
    }
    // Start is called before the first frame update
   public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
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
            ApplyLocalPosiitonToVisuals(axeleInfo.leftWheel);
            ApplyLocalPosiitonToVisuals(axeleInfo.rightWheel);
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
}
