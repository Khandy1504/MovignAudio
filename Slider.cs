using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Slide : MonoBehaviour
    {
        [SerializeField]
        private GameObject cube1;
        [SerializeField]
        private GameObject cube2;
        public float Speed;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(MoveAtoB(cube1, cube2, Speed));
        }

        IEnumerator MoveAtoB(GameObject object1, GameObject object2, float speed)
        {
            while (object1.transform.position != object2.transform.position)
            {
                object1.transform.position = Vector3.MoveTowards(object1.transform.position, object2.transform.position, speed * Time.deltaTime);
                yield return null;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

