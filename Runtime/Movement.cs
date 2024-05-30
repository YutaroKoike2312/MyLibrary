using UnityEngine;

namespace MyLibrary
{
    public static class Movement
    {
        // �v���C���[�̈ړ����͂��擾���A�ړ��x�N�g����Ԃ�
        public static Vector3 KeyMoveVector(float speed)
        {
            // ���͂��擾
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            // �ړ��x�N�g�����쐬
            return new Vector3(moveX, moveY, 0f) * speed * Time.deltaTime;
        }
    }
}
