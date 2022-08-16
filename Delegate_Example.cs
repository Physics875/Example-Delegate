//Về Delegate: nó giống như việc bạn giao cho một tổ chức khác (hàm, biến,...) làm thay nhiệm vụ thuộc về trách nhiệm của mình.
// hàm delegate cũng có kiểu trả về, việc gọi hàm cũng tương tự nhưng chỉ khác là nó thông qua một field. 
//vd:
using UnityEngine;
class Overview
{
	public delegate void GetDelegate();
	
	private GetDelegate delegatedFunction;
	  
    	private void Start()
	{
		delegatedFunction = DelegateFunction;
	    	delegateFunction += SecondDelegateFunction;
        	delegatedFunction();
	    	delegateFunction -= SecondDelegateFunction;
	    	delegatedFunction();
    	}
	
	  
	private void DelegateFunction()
	{  
		Debug.Log("Will DelegateFunction");
	}
	
	
	private void SecondDelegateFunction()
	{  
		Debug.Log("Will SecondDelegateFunction");
	}
	
	/* Output: 	Will DelegateFunction
			Will SecondDelegateFunction
			Will DelegateFunction */
}
