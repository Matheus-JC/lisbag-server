using LisbagServer.Domain.Exceptions;

namespace LisbagServer.Domain.Entities;

public class Link : Content
{
	private string _url = "";

    public string Url { 
		get 
		{ 
			return _url; 
		}
		set
		{
			if (!Uri.IsWellFormedUriString(value, UriKind.Absolute)) 
			{
                throw new DomainException("Url with invalid format");
            }

			_url = value;
        }
    }

	public Link(string name, string url) : base(name)
	{
		Url = url;
	}
}
