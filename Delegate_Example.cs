//Về Delegate: nó giống như việc bạn giao cho một tổ chức khác (hàm, biến,...) làm thay nhiệm vụ thuộc về trách nhiệm của mình.
// hàm delegate cũng có kiểu trả về, việc gọi hàm cũng tương tự nhưng chỉ khác là nó thông qua một field. 
//vd:
class Overview
{
	public delegate void GetDelegate();
	
	private GetDelegate delegatedFunction;
	  
    static void Main(string[] args)
	{
		delegatedFunction = DelegateFunction;
	    	delegateFunction += SecondDelegateFunction;
        	delegatedFunction();
	    	delegateFunction -= SecondDelegateFunction;
	    	delegatedFunction();
    	}
	
	  
	private void DelegateFunction()
	{  
		Console.Write("Will DelegateFunction");
	}
	
	
	private void SecondDelegateFunction()
	{  
		Console.Write("Will SecondDelegateFunction");
	}
	
	/* Output: 	Will DelegateFunction
			Will SecondDelegateFunction
			Will DelegateFunction */
}
