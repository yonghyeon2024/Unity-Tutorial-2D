using UnityEngine;

public class Calculator : MonoBehaviour
{
    // ��� ���� = �ʵ�
    public int number1, number2;

    void Start()
    {
        // �Լ� ȣ��
        int addResult = AddMethod();
        int minusResult = MinusMethod();

        Debug.Log($"���� ��: {addResult}, �� ��: {minusResult}");
    }

    int AddMethod()
    {
        // result: ���� ����
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }

    
}
