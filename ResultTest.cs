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
			case "1550700445" :
				result = "Kwanchanok Im-Amornchai";
				break;
            		case "1550700262":
        			 result = "Pongpak Aumpaipannasun";
        		        break;
            		case "1550700155":
                		result = "Thanawat Thumbal";
                		break;
			case "1550701062":
                		result = "Parakorn Bungaruang";
                		break;
                	case "1550701369":
                		result = "Yanisa Dangkrue";
                		break;
                	case "1550701633":
                		result = "Jidapa Chanpen";
                		break;
                	case "1550700411";
                	        result = "Anucha langsui";
                	        break;
			case "1560700021":
				result = "Surakit Kornongklang";               		
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
			case "1550700445" :
				result = "kwanchanok";
				break;
        		case "1550700262":
        			result = "Pongpak";
                		break;
            		case "1550700155":
                		result = "STIKKIK";
                		break;
			case "1550701062":
                		result = "parakorn1";
                		break;
                	case "1550701369":
                		result = "jommjomm";
                		break;
                	case "1550701633":
                		result = "nannvip";
                		break;
                	case "1550700411";
                	        result = "toomlangsui";
                	        break;
			Case "150700021"
				result = "surakit003";
            		default :
				break;
		}
		return result;
	}
}
