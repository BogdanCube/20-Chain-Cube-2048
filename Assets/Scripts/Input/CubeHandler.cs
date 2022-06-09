using Core.Cube;
using Core.Environment;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InputCube
{
    public class CubeHandler : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private LossZone _lossZone;
        [SerializeField] private SpawnerCube _spawner;
        [SerializeField] private CounterLaunch _counterLaunch;
        private Cube _currentCube;
        
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                SelectCube();
            }
            if (Input.GetMouseButtonUp(0) && _currentCube)
            {
                LaunchCube();
            }

            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        private void SelectCube()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue))
            {
                if (hit.collider.gameObject.TryGetComponent(out Cube cube))
                {
                    if (cube.IsTapped == false)
                    {
                        _currentCube = cube;
                        _currentCube.Movement.Move(hit.point);
                    }
                }
            }
        }

        private void LaunchCube()
        {
            _currentCube.Movement.Launch();
            _currentCube = null;
            _spawner.Spawn();
            _counterLaunch.AddCount();
        }
    }
}