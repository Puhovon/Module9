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

            //Получаем ссылку на Rigidbody
            var body = obj.GetComponent<Rigidbody>();

            //Сохраняем позицию объекта, который будем швырять
            var start = obj.transform.position;

            //Вычисляем расстояние до точки, куда нам нужно попасть
            float distance = Vector3.Distance(start, end);

            //Вычисляем направление, сиё есть вектор
            Vector3 direction = (end - start).normalized;

            //Выставляем координату "у" под 0.5f, что даёт нам угол 45 градусов

            //Наконец-то вычисляем силу, по-хорошему надо бы использовать Physics.gravity, но я 
            //воспользовался константой = 9.81f
            var force = Mathf.Sqrt(distance * 9.81f) * direction * body.mass;

            //Швыряем!
            body.AddForce(force, ForceMode.Impulse);


        }

    }

}

