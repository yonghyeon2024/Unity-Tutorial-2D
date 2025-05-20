using UnityEngine;

public class Calculator : MonoBehaviour
{
    // 멤버 변수 = 필드
    public int number1, number2;

    void Start()
    {
        // 함수 호출
        int addResult = AddMethod();
        int minusResult = MinusMethod();

        Debug.Log($"더한 값: {addResult}, 뺀 값: {minusResult}");
    }

    int AddMethod()
    {
        // result: 지역 변수
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }

    
}
