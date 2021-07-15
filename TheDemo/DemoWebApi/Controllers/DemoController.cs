using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return new Post
            {
                Data = new Data
                {
                    Id = id,
                    Title = $"Title #{id} {new string('*', id % 8 + 1)}",
                },
            };
        }
    }

    public partial class Post
    {
        [JsonPropertyName("meta")]
        public object Meta { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }
    }

}
