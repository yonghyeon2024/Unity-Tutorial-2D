using DevA;         // ProgrammerA Ŭ������ ��� ������ �����ϱ� ���� �ڵ�
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA;

    void Start()
    {
        // ProgrammerA Ŭ������ public ��� ������ ������ ������
        pA.number2 = 20;
    }
}
