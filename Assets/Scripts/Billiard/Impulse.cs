using UnityEngine;

namespace Assets.Scripts.Billiard
{
    public class Impulse : MonoBehaviour
    {
        [SerializeField] private GameObject obj;
        [SerializeField] private Vector3 end;
        [SerializeField] private float speed;

        private void Start()
        {

            //�������� ������ �� Rigidbody
            var body = obj.GetComponent<Rigidbody>();

            //��������� ������� �������, ������� ����� �������
            var start = obj.transform.position;

            //��������� ���������� �� �����, ���� ��� ����� �������
            float distance = Vector3.Distance(start, end);

            //��������� �����������, �� ���� ������
            Vector3 direction = (end - start).normalized;

            //���������� ���������� "�" ��� 0.5f, ��� ��� ��� ���� 45 ��������

            //�������-�� ��������� ����, ��-�������� ���� �� ������������ Physics.gravity, �� � 
            //�������������� ���������� = 9.81f
            var force = Mathf.Sqrt(distance * 9.81f) * direction * body.mass;

            //�������!
            body.AddForce(force, ForceMode.Impulse);


        }

    }

}

