using DevA;         // ProgrammerA 클래스의 멤버 변수에 접근하기 위한 코드
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA;

    void Start()
    {
        // ProgrammerA 클래스의 public 멤버 변수만 접근이 가능함
        pA.number2 = 20;
    }
}
