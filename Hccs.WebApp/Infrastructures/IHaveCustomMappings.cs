using AutoMapper;

namespace Hccs.WebApp.Infrastructures
{
	public interface IHaveCustomMappings
	{
		void CreateMappings(IConfiguration configuration);
	}
}