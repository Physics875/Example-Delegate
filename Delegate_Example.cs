//Về Delegate: nó giống như việc bạn giao cho một tổ chức khác (hàm, biến,...) làm thay nhiệm vụ thuộc về trách nhiệm của mình.
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
	
	// Output: 	Will DelegateFunction
			Will SecondDelegateFunction
			Will DelegateFunction
}
