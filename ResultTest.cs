public class ResultTest 
{
	public string GetName(string studentId)
	{
		string result = "";
		switch(studentId)
		{
			case "555555555" :
				result = "Yodsaphon Santad";
				break;
			//TODO: Add your student id here...
			default :
				break;
		}
		return result;
	}

	public string GetGitName(string studentId)
	{
		string result = "";
		switch(studentId)
		{
			case "555555555" :
				result = "yodsaphon";
				break;
			//TODO: Add your student id here...
			default :
				break;
		}
		return result;
	}
}