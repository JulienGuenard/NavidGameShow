using UnityEngine;
using UnityEngine.AI;

public class SC_Agent : MonoBehaviour {

    public Transform _target;
    private NavMeshAgent _navMeshAgent;
    private Animator _animator;


    void Start () {
		_navMeshAgent = this.transform.GetComponent<NavMeshAgent>();
        _animator = this.transform.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                _navMeshAgent.destination = hit.point;
                _animator.SetBool("Walk", true);
            }
        }
    }
}
