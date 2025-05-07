using UnityEngine;

// ĳ������ �⺻ �ɷ�ġ�� �����ϰ� �����ϴ� Ŭ����
public class StatHandler : MonoBehaviour
{
    // ü�� (1 ~ 100 ���� ���� ����ؾ� �Ѵ�.)
    [Range(1, 100)][SerializeField] private int health = 10;
    // �ܺο��� ���� ������ ������Ƽ (�� ���� �� �ڵ����� 0~100 ���̷� �����Ѵ�.)
    public int Health
    {
        get => health;
        set => health = Mathf.Clamp(value, 0, 100);
    }

    // �̵� �ӵ� (1f ~ 20f ���� ���� ����Ѵ�.)
    [Range(1f, 20f)][SerializeField] private float speed = 3;
    // �ܺο��� ���� ������ ������Ƽ (�� ���� �� 0~20f�� �����ϴ°� ����.)
    public float Speed
    {
        get => speed;
        set => speed = Mathf.Clamp(value, 0, 20);
    }
}