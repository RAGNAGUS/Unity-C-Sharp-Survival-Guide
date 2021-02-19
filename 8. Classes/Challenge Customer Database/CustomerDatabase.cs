using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    public Customer jonathan;
    public Customer jannet;
    public Customer jessica;
    public Customer eric;

    public void Start()
    {
        jonathan = new Customer("Jonathan", "Weinberger", 26, "M", "Software Engineer");
        jannet = new Customer("Jannet", "", 55, "F", "Instructor");
        jessica = new Customer("Jessica", "Lang", 23, "F", "Scientist");
    }
}
