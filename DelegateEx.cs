//Về Delegate: nó giống như việc bạn giao cho một tổ chức khác (hàm, biến,...) làm thay nhiệm vụ thuộc về trách nhiệm của mình.
//vd:
class Overview
{
	public delegate void GetDelegate();
	
	private GetDelegate delegatedFunction;
	  
    static void Main(string[] args)
	{
		delegatedFunction = DelegateFunction;
        delegatedFunction();
    }
	  
	private void DelegateFunction()
	{  
		Console.Write("Will DelegateFunction");
	}
	
	// Output: Will DelegateFunction
}