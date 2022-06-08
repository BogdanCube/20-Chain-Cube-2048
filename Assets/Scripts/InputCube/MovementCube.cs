using Core.Cube;
using Core.Environment;
using UnityEngine;

namespace InputCube
{
    public class MovementCube : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private LossZone _lossZone;
        private Cube _currentCube;
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SelectCube();
            }
            if (Input.GetMouseButtonUp(0) && _currentCube)
            {
                SelectCube();
            }
        }

        private void SelectCube()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue))
            {
                if (raycastHit.collider.gameObject.TryGetComponent(out Cube cube))
                {
                    _currentCube = cube;
                    // влево вправо перемещения
                }
            }
        }

        private void LaunchCube()
        {
            _currentCube.Physisc.Launch();
            _currentCube = null;
            // октл зону програша
        }
    }
}