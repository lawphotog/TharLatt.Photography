using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TharLattPhotography.Controllers
{
    public class PhotosController : ApiController
    {
        public IEnumerable<photo> GetPhotos()
        {
            return new List<photo>
            {
                new photo { id = 1, href = "/content/images/1 (1).jpg", type = "portraits" },
                new photo { id = 2, href = "/content/images/1 (2).jpg", type = "portraits" },
                new photo { id = 3, href = "/content/images/1 (3).jpg", type = "portraits" },
                new photo { id = 4, href = "/content/images/1 (4).jpg", type = "portraits" },
                new photo { id = 5, href = "/content/images/1 (5).jpg", type = "portraits" },
                new photo { id = 6, href = "/content/images/1 (6).jpg", type = "portraits" },
                new photo { id = 7, href = "/content/images/1 (7).jpg", type = "portraits" },
                new photo { id = 8, href = "/content/images/1 (8).jpg", type = "portraits" },
                new photo { id = 9, href = "/content/images/1 (9).jpg", type = "portraits" },
                new photo { id = 10, href = "/content/images/1 (10).jpg", type = "portraits" },
                new photo { id = 11, href = "/content/images/1 (11).jpg", type = "portraits" },
                new photo { id = 12, href = "/content/images/1 (12).jpg", type = "portraits" }
            };
        }
    }

    public class photo
    {
        public int id { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    } 
}
