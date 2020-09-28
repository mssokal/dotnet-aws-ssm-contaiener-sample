using System;
using System.Net;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace ssmtest
{
    class Program
    {
        static async Task Main(string[] args)
        {
		string _region = "eu-west-1";
                using var client = new AmazonSimpleSystemsManagementClient(
                RegionEndpoint.GetBySystemName(_region));

                var request = new GetParameterRequest()
                {
                    Name = "DD_API_KEY",
                    WithDecryption = true
                };

                GetParameterResponse response = await client.GetParameterAsync(request);
		Console.WriteLine(RegionEndpoint.GetBySystemName(_region));
	        Console.WriteLine(response.Parameter.Name);	
                Console.WriteLine(response.Parameter.Value);
                Console.WriteLine("I am done.");
        }
    }
}
